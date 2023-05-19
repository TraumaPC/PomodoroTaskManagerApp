using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroTaskManagerApp.Data
{
    internal class User
    {
        private int Uid { get; set; }
        private string FName, LName, Ulogin, Upass;

        public User() { }

        public User(string fName, string lName, string login, string pass)
        {
            FName = fName;
            LName = lName;
            Ulogin = login;
            Ulogin = pass;
        }
    }
}
