using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExampleSQLApp1
{
	public partial class Base : Form
	{
		private string currentUserLogin;

		public Base(string userLogin, bool guestMode = false)
		{
			InitializeComponent();
			currentUserLogin = userLogin;
		}

		// Загрузка пользователей из БД
		private void Base_Load(object sender, EventArgs e)
		{
			// Загрузка роли текущего пользователя из базы данных
			using (var dbConnection = new MySqlConnection("server=localhost; port=3306; username=root; password=root; database=db"))
			{
				try
				{
					dbConnection.Open();

					// Запрос для получения роли текущего пользователя
					string query = "SELECT `role` FROM `users` WHERE `login` = @currentUserLogin";
					using (var cmd = new MySqlCommand(query, dbConnection))
					{
						cmd.Parameters.AddWithValue("@currentUserLogin", currentUserLogin);

						var role = cmd.ExecuteScalar()?.ToString();

						if (role != null)
						{
							// Если роль администратора, показываем административные кнопки
							if (role.Equals("admin", StringComparison.OrdinalIgnoreCase))
							{
								btnViewLogs.Visible = true;
							}
							else
							{
								// Если обычный пользователь, скрываем административные кнопки
								btnViewLogs.Visible = false;
							}
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Ошибка при получении данных о пользователе: {ex.Message}",
									"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private System.Media.SoundPlayer currentSoundPlayer;

		// Показ иконки учреждения
		private void ShowImageForNumber(string phoneNumber)
		{
			try
			{
				// Получаем путь к папке images внутри проекта
				string projectDirectory = Directory.GetParent(Application.StartupPath).Parent.Parent.Parent.FullName;
				string imagesFolder = Path.Combine(projectDirectory, "images");
				string imagePath = Path.Combine(imagesFolder, $"{phoneNumber}.png");

				// Проверяем, существует ли файл
				if (!File.Exists(imagePath))
				{
					MessageBox.Show($"Изображение для номера {phoneNumber} не найдено! Путь: {imagePath}",
									 "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				// Освобождаем предыдущее изображение, если оно загружено
				if (pictureBox1.Image != null)
				{
					pictureBox1.Image.Dispose();
					pictureBox1.Image = null;
				}

				// Загружаем изображение в PictureBox
				pictureBox1.Image = Image.FromFile(imagePath);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Ошибка загрузки изображения: {ex.Message}",
								 "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		// Проигрывание звука для учреждения
		private void PlaySoundForNumber(string phoneNumber)
		{
			string projectDirectory = Directory.GetParent(Application.StartupPath).Parent.Parent.Parent.FullName;
			string audioFolder = Path.Combine(projectDirectory, "Sound");
			string audioPath = Path.Combine(audioFolder, $"{phoneNumber}.wav");

			if (File.Exists(audioPath))
			{
				// Создаем новый проигрыватель и проигрываем звук
				currentSoundPlayer = new System.Media.SoundPlayer(audioPath);
				currentSoundPlayer.Play();
			}
			else
			{
				MessageBox.Show($"Аудиофайл для номера {phoneNumber} не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// Крестик
		private void closeButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		// Кнопка соединения

		private void btnDial_Click(object sender, EventArgs e)
		{
			string phoneNumber = txtPhoneNumber.Text;

			if (phoneNumber.Length == 3)
			{
				using (var dbConnection = new MySqlConnection("server=localhost; port=3306; username=root; password=root; database=db"))
				{
					try
					{
						dbConnection.Open();

						// Проверка, есть ли активное соединение у пользователя
						string checkQuery = "SELECT connected_to FROM `users` WHERE `login` = @currentUserLogin";
						using (var checkCmd = new MySqlCommand(checkQuery, dbConnection))
						{
							checkCmd.Parameters.AddWithValue("@currentUserLogin", currentUserLogin);
							var connectedTo = checkCmd.ExecuteScalar()?.ToString();

							// Если пользователь уже подключен, не даем звонить
							if (!string.IsNullOrEmpty(connectedTo))
							{
								MessageBox.Show("Вы не можете звонить другому номеру, пока не завершите текущий звонок.",
												"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
								return; // Останавливаем выполнение
							}
						}

						// Проверка статуса номера
						string statusQuery = "SELECT `status`, `description` FROM `numbers` WHERE `number` = @phoneNumber";
						using (var statusCmd = new MySqlCommand(statusQuery, dbConnection))
						{
							statusCmd.Parameters.AddWithValue("@phoneNumber", phoneNumber);
							using (var reader = statusCmd.ExecuteReader())
							{
								if (reader.Read())
								{
									string status = reader["status"]?.ToString() ?? "неизвестно";
									string description = reader["description"]?.ToString() ?? "Нет описания";

									// Проверяем, доступен ли номер для вызова
									if (status != "доступен")
									{
										MessageBox.Show($"Номер {phoneNumber} недоступен для вызова. Статус: {status}.",
														"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
										return; // Останавливаем выполнение
									}

									// Если номер доступен, продолжаем выполнение
									MessageBox.Show($"Набираем номер: {phoneNumber}\nОписание: {description}",
													"Вызов", MessageBoxButtons.OK, MessageBoxIcon.Information);

									ShowImageForNumber(phoneNumber);
									PlaySoundForNumber(phoneNumber);
								}
								else
								{
									MessageBox.Show($"Данные для номера {phoneNumber} не найдены в базе!",
													"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
									return;
								}
							}
						}

						// Обновление connected_to в таблице users
						using (var transaction = dbConnection.BeginTransaction())
						{
							string updateQuery = "UPDATE `users` SET `connected_to` = @phoneNumber WHERE `login` = @currentUserLogin";
							using (var updateCmd = new MySqlCommand(updateQuery, dbConnection, transaction))
							{
								updateCmd.Parameters.AddWithValue("@phoneNumber", phoneNumber);
								updateCmd.Parameters.AddWithValue("@currentUserLogin", currentUserLogin);
								updateCmd.ExecuteNonQuery();
							}

							transaction.Commit(); // Завершаем транзакцию
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show($"Ошибка подключения к базе данных:\n{ex.Message}",
										"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			else
			{
				MessageBox.Show("Введите корректный номер (3 цифры).",
								"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}



		Point lastPoint; // Чтобы хватать в любом месте и перемещать
		private void Base_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.Left += e.X - lastPoint.X;
				this.Top += e.Y - lastPoint.Y;
			}
		}

		private void Base_MouseDown(object sender, MouseEventArgs e)
		{
			lastPoint = new Point(e.X, e.Y);
		}

		// Мини-АТС скрытая кнопка
		private void label1_Click(object sender, EventArgs e)
		{
			MessageBox.Show($"Приложение разработано: Спирьяновым Михаилом, 2024 год", "Мини-АТС", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}


		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.Left += e.X - lastPoint.X;
				this.Top += e.Y - lastPoint.Y;
			}
		}

		private void label1_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.Left += e.X - lastPoint.X;
				this.Top += e.Y - lastPoint.Y;
			}
		}

		// Кнопка закрытия
		private void Base_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Escape)
				this.Close();
		}

		// Кнопка статуса
		private void btn_Status_Click(object sender, EventArgs e)
		{
			using (var dbConnection = new MySqlConnection("server=localhost; port=3306; username=root; password=root; database=db"))
			{
				try
				{
					dbConnection.Open();

					// Запрос для получения статуса пользователя
					string query = "SELECT role FROM `users` WHERE `login` = @currentUserLogin";
					using (var cmd = new MySqlCommand(query, dbConnection))
					{
						cmd.Parameters.AddWithValue("@currentUserLogin", currentUserLogin);

						using (var reader = cmd.ExecuteReader())
						{
							if (reader.Read())
							{
								string status = reader["role"]?.ToString() ?? "Нет данных";

								// Отобразить сообщение с логином и статусом
								MessageBox.Show($"Логин: {currentUserLogin}\nВаш статус: {status}",
									"Статус аккаунта", MessageBoxButtons.OK, MessageBoxIcon.Information);
							}
							else
							{
								MessageBox.Show("Не удалось получить статус пользователя.", "Ошибка",
									MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Ошибка подключения к базе данных:\n{ex.Message}",
						"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		// Кнопка смена пользователя
		private void btn_Logout_Click(object sender, EventArgs e)
		{
			// Спрашиваем у пользователя подтверждение выхода
			DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти?",
				"Выход из аккаунта", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				// Возвращаемся к форме авторизации
				this.Hide();
				LoginForm loginForm = new LoginForm();
				loginForm.ShowDialog();
				this.Close();
			}
		}

		// Метод для выключения звука
		private void StopSound()
		{
			if (currentSoundPlayer != null)
			{
				currentSoundPlayer.Stop();
				currentSoundPlayer = null; // Обнуляем ссылку
			}
		}

		// Метод для удаления картинки
		private void RemoveImage()
		{
			// Убираем изображение из PictureBox
			pictureBox1.Image = null;
			pictureBox1.Visible = true;
		}

		// Кнопка для разрыва соединения с абонентом
		private void btn_Disconnect_Click(object sender, EventArgs e)
		{
			using (var dbConnection = new MySqlConnection("server=localhost; port=3306; username=root; password=root; database=db"))
			{
				try
				{
					dbConnection.Open();

					// Проверяем, есть ли активное соединение у пользователя
					string checkQuery = "SELECT connected_to FROM `users` WHERE `login` = @currentUserLogin";
					using (var checkCmd = new MySqlCommand(checkQuery, dbConnection))
					{
						checkCmd.Parameters.AddWithValue("@currentUserLogin", currentUserLogin);

						var connectedTo = checkCmd.ExecuteScalar()?.ToString();

						if (string.IsNullOrEmpty(connectedTo))
						{
							MessageBox.Show("Нет активного соединения для разрыва.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
							return;
						}

						// Обновляем соединение в базе данных
						string disconnectQuery = "UPDATE `users` SET `connected_to` = NULL WHERE `login` = @currentUserLogin";
						using (var disconnectCmd = new MySqlCommand(disconnectQuery, dbConnection))
						{
							disconnectCmd.Parameters.AddWithValue("@currentUserLogin", currentUserLogin);
							disconnectCmd.ExecuteNonQuery();

							MessageBox.Show($"Соединение с абонентом {connectedTo} успешно разорвано.", "Разрыв соединения", MessageBoxButtons.OK, MessageBoxIcon.Information);

							// Останавливаем звук
							StopSound();

							// Убираем картинку
							RemoveImage();
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Ошибка при разрыве соединения:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		// Для нажатия на кнопку администрации
		private void btnViewLogs_Click(object sender, EventArgs e)
		{
			ShowSystemStats();
		}

		// Метод для показа статуса пользователей
		private void ShowSystemStats()
		{
			using (var dbConnection = new MySqlConnection("server=localhost; port=3306; username=root; password=root; database=db"))
			{
				try
				{
					dbConnection.Open();
					string query = "SELECT COUNT(*) FROM `users`";
					using (var cmd = new MySqlCommand(query, dbConnection))
					{
						var userCount = cmd.ExecuteScalar();
						MessageBox.Show($"Количество пользователей: {userCount}");
					}

					// Выводим количество активных соединений
					query = "SELECT COUNT(*) FROM `users` WHERE `connected_to` IS NOT NULL";
					using (var cmd = new MySqlCommand(query, dbConnection))
					{
						var activeConnections = cmd.ExecuteScalar();
						MessageBox.Show($"Количество активных соединений: {activeConnections}");
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Ошибка при получении статистики: {ex.Message}");
				}
			}
		}

		// Для скрытия надписи при вводе данных
		private void txtPhoneNumber_Enter(object sender, EventArgs e)
		{
			// Проверяем, если текст равен "Введите номер", то очищаем его
			if (txtPhoneNumber.Text == "Введите номер")
			{
				txtPhoneNumber.Text = string.Empty; // Очищаем текст
				txtPhoneNumber.ForeColor = Color.Black; // Меняем цвет текста на черный (для нормального ввода)
			}
		}

		// Для красивой надписи, перед нажатием на строку ввода номера
		private void txtPhoneNumber_Leave(object sender, EventArgs e)
		{
			// Если поле осталось пустым, возвращаем текст по умолчанию
			if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
			{
				txtPhoneNumber.Text = "Введите номер";
				txtPhoneNumber.ForeColor = Color.Gray; // Меняем цвет текста на серый
			}
		}

		// Кнопка помощи (Справка)
		private void btnHelp_Click(object sender, EventArgs e)
		{
			using (var dbConnection = new MySqlConnection("server=localhost; port=3306; username=root; password=root; database=db"))
			{
				try
				{
					dbConnection.Open();

					// Запрос для получения всех номеров и их описаний
					string query = "SELECT `number`, `description` FROM `numbers`";
					using (var cmd = new MySqlCommand(query, dbConnection))
					{
						using (var reader = cmd.ExecuteReader())
						{
							StringBuilder helpText = new StringBuilder("Справка по номерам:\n\n");

							// Читаем данные из таблицы
							while (reader.Read())
							{
								string number = reader["number"].ToString();
								string description = reader["description"].ToString();

								// Добавляем информацию о номере в справку
								helpText.AppendLine($"Номер: {number}");
								helpText.AppendLine($"Описание: {description}\n");
							}

							// Отображаем справку в отдельном окне
							MessageBox.Show(helpText.ToString(), "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Ошибка при получении данных для справки:\n{ex.Message}",
									"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}


		// Кнопка администрации - показ всех участников БД
		private void btnManageUsers_Click(object sender, EventArgs e)
		{
			using (var dbConnection = new MySqlConnection("server=localhost; port=3306; username=root; password=root; database=db"))
			{
				try
				{
					dbConnection.Open();
					string query = "SELECT `login`, `role` FROM `users`";
					using (var cmd = new MySqlCommand(query, dbConnection))
					{
						using (var reader = cmd.ExecuteReader())
						{
							StringBuilder userList = new StringBuilder("Список пользователей:\n\n");
							while (reader.Read())
							{
								string login = reader["login"].ToString();
								string role = reader["role"].ToString();
								userList.AppendLine($"Логин: {login}, Роль: {role}");
							}
							MessageBox.Show(userList.ToString(), "Просмотр пользователей", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Ошибка при прочтении пользователей: {ex.Message}");
				}
			}
		}
	}
}
