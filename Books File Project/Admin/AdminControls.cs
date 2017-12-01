using System;
using System.IO;
using System.Windows.Forms;

namespace Books_File_Project.Admin
{
    public partial class AdminControls : Form
    {
        public AdminControls()
        {
            InitializeComponent();
        }


        private void AddBook_Click(object sender, EventArgs e)
        {
            FileStream File = new FileStream("Books.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(File);


            sw.Close();
            File.Close();
        }
    }
}
