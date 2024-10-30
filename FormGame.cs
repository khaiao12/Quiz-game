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

                timeLeft = 30; // Đặt lại thời gian còn lại
                timerQuestion.Start(); // Bắt đầu Timer
                UpdateTimerLabel(); // Cập nhật hiển thị thời gian
            }
            else
            {
                labelResult.Text = $"Kết thúc! Điểm số của bạn: {score}/{selectedQuestions.Count}";
                buttonSubmit.Enabled = false;
                timerQuestion.Stop(); // Dừng Timer khi hết câu hỏi
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

    }
}
