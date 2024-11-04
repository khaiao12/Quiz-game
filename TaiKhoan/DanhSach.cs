using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient; // Thêm thư viện để sử dụng MySQL
using QuizGame;
namespace Quizgame
{
    internal class DanhSach
    {
        private static DanhSach instance;
        private List<TaiKhoan> listTaiKhoan;

        public static DanhSach Instance
        {
            get
            {
                if (instance == null)
                    instance = new DanhSach();
                return instance;
            }
            set => instance = value;
        }

        public List<TaiKhoan> ListTaiKhoan
        {
            get => listTaiKhoan;
            set => listTaiKhoan = value;
        }

        private DanhSach()
        {
            listTaiKhoan = new List<TaiKhoan>();
            LoadTaiKhoanFromDatabase(); // Gọi phương thức để tải tài khoản từ cơ sở dữ liệu
        }

        private void LoadTaiKhoanFromDatabase()
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            dbConnection.OpenConnection();

            // Sử dụng bảng 'users' thay vì 'user'
            string query = "SELECT Username, Password FROM users";
            MySqlCommand cmd = new MySqlCommand(query, dbConnection.GetConnection());

            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string username = reader.GetString("Username");
                    string password = reader.GetString("Password");

                    listTaiKhoan.Add(new TaiKhoan(username, password));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy tài khoản từ cơ sở dữ liệu: " + ex.Message);
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }
    }
}
