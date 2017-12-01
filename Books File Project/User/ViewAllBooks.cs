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
    public partial class ViewAllBooks : Form
    {
        public ViewAllBooks()
        {
            InitializeComponent();
        }
        List<String> s = new List<string>();
        private void ViewAllBooks_Load(object sender, EventArgs e)
        {

            FileStream fs = new FileStream("Books.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string[] fields;
            string[] records;

            string SerialNo, BookName, PublishYear, ID;
            while (sr.Peek() != -1)
            {
                records = sr.ReadLine().Split('#');
                for (int i = 0; i < records.Length - 1; i++)
                {
                    fields = records[i].Split('@');
                    SerialNo = fields[0];
                    BookName = fields[1];
                    PublishYear = fields[2];
                    ID = fields[3];


                    s.Add(BookName);
                    s.Add(PublishYear);
                    s.Add(SerialNo);
                    s.Add(ID);
                    s.Add("--------------------------");

                }

            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        { Label d = new Label();

            foreach (var x in s)
            {
                d.Text = x;
                   vScrollBar1.Enter();
            }
        }
    }
}