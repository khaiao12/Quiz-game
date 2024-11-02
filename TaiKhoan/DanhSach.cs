using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizgame
{
    internal class DanhSach
    {
        private static DanhSach instance;

        List<TaiKhoan> listTaiKhoan;

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

        DanhSach()
        {
            listTaiKhoan = new List<TaiKhoan>();
            listTaiKhoan.Add(new TaiKhoan("Demo", "4321"));
            listTaiKhoan.Add(new TaiKhoan("Demo1", "1212"));
            listTaiKhoan.Add(new TaiKhoan("Demo2", "1111"));
            listTaiKhoan.Add(new TaiKhoan("Demo3", "1234"));

        }
    }
}
