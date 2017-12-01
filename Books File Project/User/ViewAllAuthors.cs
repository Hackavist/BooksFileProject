using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Books_File_Project.User
{
    public partial class ViewAllAuthors : Form
    {
        public ViewAllAuthors()
        {
            InitializeComponent();
        }

        private void ViewAllAuthors_Load(object sender, EventArgs e)
        {
            FileStream f = new FileStream(@"C:\Users\hazem\Source\Repos\BooksFileProject\Books File Project\User\Authors.txt", FileMode.Open);
            StreamReader sr = new StreamReader(f);
            while (sr.Peek() != -1)
            {
                char[] id = new char[5];
                char[] name = new char[20];
                char[] email = new char[25];
                sr.Read(id, 0, 5);
                sr.Read(name, 0, 20);
                sr.Read(email, 0, 25);
                string[] x = new string[3];
                x[0] = new string(id);
                x[1] = new string(name);
                x[2] = new string(email);
                dataGridView1.Rows.Add(x);
            }
            sr.Close();
            f.Close();
        }   
    }
}
