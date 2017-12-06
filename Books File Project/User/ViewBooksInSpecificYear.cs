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

        private void EnterButton_Click(object sender, EventArgs e)
        {

            label2.Text = "Serial Number";
            label3.Text = "Book Name";
            label4.Text = "Publish Year";
            label5.Text = "Author ID";

            FileStream fs = new FileStream("Books.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            string year = YearTextBox.Text;
            bool find = false;

            string[] field, record;

            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";

            Book b = new Book();
            List<Book> x = new List<Book>();

            if (string.IsNullOrEmpty(YearTextBox.Text) || string.IsNullOrWhiteSpace(YearTextBox.Text) /* || mesh arkam */)
            {
                MessageBox.Show("Please Enter Publish Year ");
            }
            else
            {
                while (sr.Peek() != -1 && find == false)
                {


                    record = sr.ReadLine().Split('#');

                    for (int i = 0; i < record.Length - 1; i++)
                    {

                        field = record[i].Split('@');

                        b = new Book(field[0], field[1], field[2], field[3]);




                        if (year == field[2])
                        {
                            x.Add(b);
                            find = true;
                        }
                    }

                    if (find == false)
                    {
                        MessageBox.Show("No Books Published in " + year);
                    }
                }
            }
            sr.Close();
            fs.Close();

            for (int i = 0; i < x.Count; i++)
            {
                label6.Text += x[i].SerialNumber + '\n';
                label7.Text += x[i].BookName + '\n';
                label8.Text += x[i].PublishYear + '\n';
                label9.Text += x[i].AuthorId + '\n';
            }
            YearTextBox.Text = "";

        }

        private void Back_Click(object sender, EventArgs e)
        {
            UserWelcome uw = new UserWelcome();
            uw.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UserWelcome uw = new UserWelcome();
            uw.Show();
            this.Hide();
        }
    }
}
