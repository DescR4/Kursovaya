using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSQLApp1
{
    internal class DBAuto
    {
        MySqlConnection connection = new MySqlConnection("server=localhost; port=3306; username=root; password=root; database= db");

        //Доступ к открытию файла
        public void openConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                    connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подключения к базе данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Закрывает БД
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        //Проверка соединения
        public MySqlConnection getConnection()
        { 
            return connection;
        }

    }
}