using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizgame
{
    internal class TaiKhoan
    {
        private string userName;

        public string UserName
        {
            get => userName;
            set => userName = value;
        }

        private string password;

        public string Password
        {
            get => password;
            set => password = value;
        }

        public TaiKhoan(string userName, string password)
        {
            this.UserName = userName;
            this.Password = password;
        }
    }
}
