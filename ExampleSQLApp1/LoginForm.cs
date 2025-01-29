using MySql.Data.MySqlClient;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.passfield.AutoSize = false;
            this.passfield.Size = new Size(this.passfield.Size.Width, 64);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Кнопка входа
        private void button1_Click(object sender, EventArgs e)
        {
            String loginUser = loginField.Text;
            String PassUser = passfield.Text;

            DBAuto db = new DBAuto();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `pass` = @uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = PassUser;

            try
            {
                db.openConnection();
                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Успешная авторизация!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Base baseForm = new Base(loginUser); // Передаем логин
                    baseForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при входе: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        // Обработчик кнопки "Войти без авторизации"
        private void guestButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы вошли в режиме гостя. Доступ к редактированию данных заблокирован.",
                            "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            Fake fakeForm = new Fake();
            fakeForm.ShowDialog();
            this.Close();
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.White;
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Coral;
        }

        Point lastPoint;
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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
