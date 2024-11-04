using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace QuizGame
{
    public class DatabaseConnection
    {
        // Thông tin kết nối cơ sở dữ liệu
        private string host = "localhost";
        private int port = 3306;
        private string database = "quizgame";
        private string username = "root";  
        private string password = "";      

        private MySqlConnection connection;

        // Phương thức khởi tạo để thiết lập chuỗi kết nối
        public DatabaseConnection()
        {
            string connectionString = $"Server={host};Port={port};Database={database};Uid={username};Pwd={password};";
            connection = new MySqlConnection(connectionString);
        }

        // Phương thức mở kết nối
        public void OpenConnection()
        {
            try
            {
                connection.Open();
                Console.WriteLine("Kết nối cơ sở dữ liệu thành công!");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Lỗi kết nối cơ sở dữ liệu: " + ex.Message);
            }
        }

        // Phương thức đóng kết nối
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                Console.WriteLine("Đã đóng kết nối cơ sở dữ liệu.");
            }
        }

        // Phương thức để lấy kết nối (nếu cần dùng ở nơi khác)
        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
