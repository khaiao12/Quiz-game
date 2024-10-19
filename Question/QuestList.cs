using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            listCauHoi= new List<Question>();
            listCauHoi.Add(new Question("Câu hỏi 1: Thủ đô của Việt Nam là gì?", "Hà Nội", "TP.HCM", "Đà Nẵng", "Nha Trang", "Hà Nội"));
            listCauHoi.Add(new Question("Câu hỏi 2: Màu sắc của lá cây là gì?", "Đỏ", "Xanh lá", "Vàng", "Trắng", "Xanh lá"));
        }
    }
}
