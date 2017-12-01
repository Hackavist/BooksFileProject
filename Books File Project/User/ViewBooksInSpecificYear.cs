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
    public partial class ViewBooksInSpecificYear : Form
    {
        public ViewBooksInSpecificYear()
        {
            InitializeComponent();
        }

        //object of Books class
        Books b = new Books();

        List<Books> x = new List<Books>();

        private void EnterButton_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("Books.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            string year = YearTextBox.Text;
            bool find = false;


            string[] field, record;

            while(sr.Peek()!=-1 && find==false)
            {
                record = sr.ReadLine().Split('#');

                for(int i=0;i<record.Length;i++)
                {
                    field = record[i].Split('@');

                    b = new book(field[0], field[1], field[2], field[3]);
                    

                    if(year==field[2])//field of published year
                    {
                        x.Add(b);
                        //display
                        find = true;
                    }
                }

                if(find == false)
                {
                    MessageBox.Show("No Books Published in " + year);
                }
            }

           
        }

        private void DisplayBooks_Scroll(object sender, ScrollEventArgs e)
        {
            
        }
    }
}
