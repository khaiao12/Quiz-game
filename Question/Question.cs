using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizgame
{
    internal class Question
    {
        private string text;

        public string Text
        {
            get => text;
            set => text = value;
        }

        private string optionA;

        public string OptionA
        { 
            get => optionA;
            set => optionA = value;
        }

        private string optionB;

        public string OptionB
        {
            get => optionB;
            set => optionB = value;
        }

        private string optionC;

        public string OptionC
        {
            get => optionC;
            set => optionC = value;
        }

        private string optionD;

        public string OptionD
        {
            get => optionD;
            set => optionD = value;
        }

        private string correctAnswer;

        public string CorrectAnswer
        {
            get => correctAnswer;
            set => correctAnswer = value;
        }

        public Question(string text, string optionA, string optionB, string optionC, string optionD, string correctAnswer)
        {
            Text = text;
            OptionA = optionA;
            OptionB = optionB;
            OptionC = optionC;
            OptionD = optionD;
            CorrectAnswer = correctAnswer;
        }
    }
}
