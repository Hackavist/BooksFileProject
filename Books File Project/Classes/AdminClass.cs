using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
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
        public static List <AdminClass> GetAllAdmins()
        {
            List<AdminClass> ret= new List<AdminClass>();
            FileStream f = new FileStream("Admin.txt", FileMode.OpenOrCreate);
            StreamReader rs = new StreamReader(f);
            string fullfile = rs.ReadLine();
            string[] records = fullfile.Split('#');
            for (int i = 0; i < records.Length - 1; i++)
            {
                string[] fields = records[i].Split('@');
                AdminClass tmp = new AdminClass(fields[0], fields[1]);
                ret.Add(tmp);

            }
            rs.Close();
            f.Close();
            return ret;
        }
    }
}
