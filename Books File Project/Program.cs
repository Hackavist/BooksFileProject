
using Books_File_Project.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Books_File_Project.User;
namespace Books_File_Project
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            UserWelcome use = new UserWelcome();
            use.Show();
            Application.Run();

            
            
        }

        public static bool IsNumbers(string x)
        {
            for(int i=0;i<x.Length;i++)
            {
                if(x[i] < '0' || x[i] >'9')
                {
                    return false;
                }
            }

            return true;
        }
       

        public static void trail()
        {

        }
    }
}
