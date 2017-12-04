using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_File_Project.Classes
{
    public class AdminClass
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public AdminClass()
        {
            Username = "";
            Password = "";
        }
        public AdminClass(string User, string pass)
        {
            Username = User;
            Password = pass;
        }
    }
}
