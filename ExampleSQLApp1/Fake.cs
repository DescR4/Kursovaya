using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleSQLApp1
{
	public partial class Fake : Form
	{
		public Fake()
		{
			InitializeComponent();
			RestrictControls();
		}

		private void RestrictControls()
		{
			foreach (Control control in this.Controls)
			{
				if (control is TextBox textBox)
				{
					textBox.ReadOnly = true;  // Блокировка ввода
				}
			}
		}

		private void closeButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		Point lastPoint;
		private void Fake_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.Left += e.X - lastPoint.X;
				this.Top += e.Y - lastPoint.Y;
			}
		}

		private void Fake_MouseDown(object sender, MouseEventArgs e)
		{
			lastPoint = new Point(e.X, e.Y);
		}

		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.Left += e.X - lastPoint.X;
				this.Top += e.Y - lastPoint.Y;
			}
		}
		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			lastPoint = new Point(e.X, e.Y);
		}

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

		private void label1_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.Left += e.X - lastPoint.X;
				this.Top += e.Y - lastPoint.Y;
			}
		}

		private void label1_MouseMove(object sender, MouseEventArgs e)
		{
			lastPoint = new Point(e.X, e.Y);
		}

		private void txtPhoneNumber_Enter(object sender, EventArgs e)
		{
			// Проверяем, если текст равен "Введите номер", то очищаем его
			if (txtPhoneNumber.Text == "Введите номер")
			{
				txtPhoneNumber.Text = string.Empty; // Очищаем текст
				txtPhoneNumber.ForeColor = Color.Black; // Меняем цвет текста на черный (для нормального ввода)
			}
		}

		private void txtPhoneNumber_Leave(object sender, EventArgs e)
		{
			// Если поле осталось пустым, возвращаем текст по умолчанию
			if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
			{
				txtPhoneNumber.Text = "Введите номер";
				txtPhoneNumber.ForeColor = Color.Gray; // Меняем цвет текста на серый
			}
		}
	}
}
