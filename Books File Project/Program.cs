<<<<<<< HEAD
﻿using Books_File_Project.Admin;
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

            Application.Run(new ViewBooksInSpecificYear());

            Application.Run(new ViewAllBooks());

        }
    }
}
=======
﻿using Books_File_Project.Admin;
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
            Application.Run(new UserWelcome());
        }
    }
}
>>>>>>> 8d5b3702f7fdb0ebc379f14f99f3c4f237181d76
