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
    public partial class ViewBooksInSpecificYear : Form
    {
        public ViewBooksInSpecificYear()
        {
            InitializeComponent();
        }

        //object of Books class
        Book b = new Book();

        List<Book> x = new List<Book>();

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

                    b = new Book(field[0], field[1], field[2], field[3]);
                    

                    if(year==field[2])
                    {
                        x.Add(b);
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
