using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using QuizGame; // Thêm thư viện để sử dụng MySQL

namespace Quizgame
{
    internal class QuestList
    {
        private static QuestList instance;

        List<Question> listCauHoi;

        public static QuestList Instance
        {
            get
            {
                if (instance == null)
                    instance = new QuestList();
                return instance;
            }

            set => instance = value;
        }

        public List<Question> ListCauHoi
        {
            get => listCauHoi;
            set => listCauHoi = value;
        }

        QuestList()
        {
            listCauHoi = new List<Question>();
            LoadQuestionsFromDatabase(); // Gọi phương thức để tải câu hỏi từ cơ sở dữ liệu
        }

        private void LoadQuestionsFromDatabase()
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            dbConnection.OpenConnection();

            string query = "SELECT QuestionText, AnswerA, AnswerB, AnswerC, AnswerD, CorrectAnswer FROM Questions";
            MySqlCommand cmd = new MySqlCommand(query, dbConnection.GetConnection());

            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string questionText = reader.GetString("QuestionText");
                    string answerA = reader.GetString("AnswerA");
                    string answerB = reader.GetString("AnswerB");
                    string answerC = reader.GetString("AnswerC");
                    string answerD = reader.GetString("AnswerD");
                    string correctAnswer = reader.GetString("CorrectAnswer");

                    listCauHoi.Add(new Question(questionText, answerA, answerB, answerC, answerD, correctAnswer));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy câu hỏi từ cơ sở dữ liệu: " + ex.Message);
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }
    }
}
