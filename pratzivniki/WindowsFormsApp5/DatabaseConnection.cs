using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    public class DatabaseConnection
    {
        public SqlConnection connection;
        public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\alyona\Downloads\Telegram Desktop\pratzivniki\pratzivniki\WindowsFormsApp5\Database1.mdf"";Integrated Security=True";

 

        // Конструктор класу
        public DatabaseConnection()
        {
            connection = new SqlConnection(connectionString);
        }

        public SqlConnection OpenConnection()
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
            return connection; // Возвращаем объект соединения
        }

        // Метод для закрытия соединения с базой данных
        public void CloseConnection()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        // Метод для получения объекта соединения
        public SqlConnection getConnection()
        {
            return connection;
        }
    }
}
