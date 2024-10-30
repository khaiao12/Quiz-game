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
            listCauHoi = new List<Question>();
            listCauHoi.Add(new Question("Câu hỏi 1: Thủ đô của Việt Nam là gì?", "Hà Nội", "TP.HCM", "Đà Nẵng", "Nha Trang", "Hà Nội"));
            listCauHoi.Add(new Question("Câu hỏi 2: Màu sắc của lá cây là gì?", "Đỏ", "Xanh lá", "Vàng", "Trắng", "Xanh lá"));
            listCauHoi.Add(new Question("Câu hỏi 3: 1 + 1 bằng mấy?", "1", "2", "3", "4", "2"));
            listCauHoi.Add(new Question("Câu hỏi 4: Động vật nào sống dưới nước?", "Chó", "Cá", "Mèo", "Gà", "Cá"));
            listCauHoi.Add(new Question("Câu hỏi 5: Ngày quốc khánh Việt Nam là ngày nào?", "1/5", "30/4", "2/9", "20/11", "2/9"));
            listCauHoi.Add(new Question("Câu hỏi 6: Nước nào nổi tiếng với món sushi?", "Trung Quốc", "Việt Nam", "Hàn Quốc", "Nhật Bản", "Nhật Bản"));
            listCauHoi.Add(new Question("Câu hỏi 7: Môn thể thao nào dùng vợt và cầu?", "Bóng đá", "Bóng rổ", "Cầu lông", "Bơi lội", "Cầu lông"));
            listCauHoi.Add(new Question("Câu hỏi 8: Tác giả của Truyện Kiều là ai?", "Nguyễn Du", "Nguyễn Trãi", "Nguyễn Đình Chiểu", "Hồ Xuân Hương", "Nguyễn Du"));
            listCauHoi.Add(new Question("Câu hỏi 9: Trái Đất quay quanh hành tinh nào?", "Mặt Trăng", "Sao Hỏa", "Mặt Trời", "Sao Kim", "Mặt Trời"));
            listCauHoi.Add(new Question("Câu hỏi 10: Mùa đông có đặc điểm thời tiết như thế nào?", "Nắng gắt", "Lạnh", "Mưa nhiều", "Nóng ẩm", "Lạnh"));
        }

    }
}
