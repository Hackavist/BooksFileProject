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
    public partial class ViewBooksOfSpecificAuthor : Form
    {
        public ViewBooksOfSpecificAuthor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("Authors.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);

        }
    }
}
