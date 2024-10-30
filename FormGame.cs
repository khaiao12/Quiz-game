using Quizgame;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace Quizgame
{
    public partial class FormGame : Form
    {
        List<Question> listCauHoi = QuestList.Instance.ListCauHoi;
        List<Question> selectedQuestions;
        private int currentQuestionIndex;
        private int score;
        private int timeLeft;

        public FormGame()
        {
            InitializeComponent();
            InitializeQuestions();
            LoadQuestion();
            playBackBtn.Visible = false; // Ẩn nút playBackBtn khi bắt đầu
        }

        private void InitializeQuestions()
        {
            currentQuestionIndex = 0;
            score = 0;
            selectedQuestions = GetRandomQuestions(10);
        }

        private List<Question> GetRandomQuestions(int number)
        {
            Random random = new Random();
            return listCauHoi.OrderBy(q => random.Next()).Take(number).ToList();
        }

        private void LoadQuestion()
        {
            if (currentQuestionIndex < selectedQuestions.Count)
            {
                var question = selectedQuestions[currentQuestionIndex];
                labelQuestion.Text = question.Text;
                radioButtonA.Text = question.OptionA;
                radioButtonB.Text = question.OptionB;
                radioButtonC.Text = question.OptionC;
                radioButtonD.Text = question.OptionD;
                labelResult.Text = "";

                timeLeft = 30;
                timerQuestion.Start();
                UpdateTimerLabel();
                playBackBtn.Visible = false; // Ẩn nút playBackBtn khi đang làm bài
            }
            else
            {
                labelResult.Text = $"Kết thúc! Điểm số của bạn: {score}/{selectedQuestions.Count}";
                buttonSubmit.Enabled = false;
                timerQuestion.Stop();
                playBackBtn.Visible = true; // Hiển thị nút playBackBtn khi hoàn thành tất cả câu hỏi
            }
        }

        private void timerQuestion_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            UpdateTimerLabel();        

            if (timeLeft <= 0)
            {
                timerQuestion.Stop();
                labelResult.Text = "Hết thời gian!";
                currentQuestionIndex++;
                LoadQuestion();
            }
        }

        private void UpdateTimerLabel()
        {
            // Cập nhật label hiển thị thời gian còn lại
            labelTimer.Text = $"Thời gian còn lại: {timeLeft} giây";
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            timerQuestion.Stop();
            var selectedOption = "";
            if (radioButtonA.Checked) selectedOption = radioButtonA.Text;
            else if (radioButtonB.Checked) selectedOption = radioButtonB.Text;
            else if (radioButtonC.Checked) selectedOption = radioButtonC.Text;
            else if (radioButtonD.Checked) selectedOption = radioButtonD.Text;

            if (selectedOption == selectedQuestions[currentQuestionIndex].CorrectAnswer)
            {
                score++;
                labelResult.Text = "Đúng!";
            }
            else
            {
                labelResult.Text = "Sai!";
            }

            currentQuestionIndex++;
            LoadQuestion();
        }

        private void FormGame_Load(object sender, EventArgs e)
        {

        }

        private void playBackBtn_Click(object sender, EventArgs e)
        {
            InitializeQuestions(); // Khởi tạo lại danh sách câu hỏi và đặt lại các giá trị
            LoadQuestion();
            buttonSubmit.Enabled = true; // Cho phép bấm nút trả lời
            playBackBtn.Visible = false; // Ẩn nút playBackBtn khi bắt đầu lại
        }
    }
}
