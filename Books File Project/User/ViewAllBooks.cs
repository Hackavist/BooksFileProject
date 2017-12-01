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
using Books_File_Project.Classes;
namespace Books_File_Project.User
{
    public partial class ViewAllBooks : Form
    {
        public ViewAllBooks()
        {
            InitializeComponent();
        }
        List<String> s = new List<string>();
        private void ViewAllBooks_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            Book bk = new Book();
            FileStream fs = new FileStream("Books.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string[] fields;
            string[] records;
           
            while (sr.Peek() != -1)
            {
                records = sr.ReadLine().Split('#');
                for (int i = 0; i < records.Length - 1; i++ )
                {
                    fields = records[i].Split('@');
                    label1.Text += fields[0]+'\n';
                    label2.Text += fields[1] + '\n';
                    label3.Text += fields[2] + '\n';
                    label4.Text += fields[3] + '\n';
                }

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}