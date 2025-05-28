using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    public class checkUser
    {
        public string Login
        {
            get; set;
        }
        public bool IsAdmin { get; }

        public string Status => IsAdmin ? "Адмін" : "Працівник";

        public checkUser(string login, bool isAdmin)
        {
            Login = login.Trim();
            IsAdmin = isAdmin;
        }
    }
}
