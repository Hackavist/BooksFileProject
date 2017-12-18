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
    public partial class ViewBooksOfSpecificAuthor : Form
    {
        public ViewBooksOfSpecificAuthor()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, EventArgs e)
        {

            FileStream fs = new FileStream("Authors.txt", FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);

            string searchID = "";
            string name = authorName.Text;
            bool found = false;

            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";

            char[] recArr = new char[50];
            string record;

            if (string.IsNullOrEmpty(authorName.Text) || string.IsNullOrWhiteSpace(authorName.Text))
            {
                MessageBox.Show("Please enter author name.");
            }
            else
            {
                while ((sr.Peek() != -1) && (found == false))
                {
                    sr.Read(recArr, 0, 50);
                    record = new string(recArr);

                    string id = record.Substring(0, 5);
                    string name2 = record.Substring(5, 20);
                    string email = record.Substring(25, 25);

                    id = id.Trim('\0');
                    name2 = name2.Trim('\0');
                    email = email.Trim('\0');


                    if (name == name2)
                    {
                        searchID = id;
                        found = true;

                    }
                }
                if (found == false)
                {
                    MessageBox.Show("Author does not exist.");
                }
            }
            sr.Close();
            fs.Close();

            FileStream fss = new FileStream("Books.txt", FileMode.OpenOrCreate);
            StreamReader srr = new StreamReader(fss);

            bool found2 = false;
            Book b = new Book();

            string[] record2, field2;
            List<Book> x = new List<Book>();

            while ((srr.Peek() != -1) && (found2 == false))
            {


                record2 = srr.ReadLine().Split('#');

                for (int i = 0; i < record2.Length - 1; i++)
                {

                    field2 = record2[i].Split('@');

                    b = new Book(field2[0], field2[1], field2[2], field2[3]);

                    if (searchID == field2[3])
                    {
                        label2.Text = "Serial Number";
                        label3.Text = "Book Name";
                        label4.Text = "Publish Year";
                        label5.Text = "Author ID";
                        x.Add(b);
                        found2 = true;
                    }
                }
                if (found2 == false)
                {
                    MessageBox.Show("Author did not publish any books.");
                }
            }
            srr.Close();
            fss.Close();


            for (int i = 0; i < x.Count; i++)
            {
                label6.Text += x[i].SerialNumber + '\n';
                label7.Text += x[i].BookName + '\n';
                label8.Text += x[i].PublishYear + '\n';
                label9.Text += x[i].AuthorId + '\n';

                authorName.Text = "";
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            UserWelcome uw = new UserWelcome();
            uw.Show();
            this.Hide();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UserWelcome uw = new UserWelcome();
            uw.Show();
            this.Hide();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("Authors.txt", FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);

            string searchID = "";
            string name = authorName.Text;
            bool found = false;

            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";

            char[] recArr = new char[50];
            string record;

            if (string.IsNullOrEmpty(authorName.Text) || string.IsNullOrWhiteSpace(authorName.Text))
            {
                MessageBox.Show("Please enter author name.");
            }
            else
            {
                while ((sr.Peek() != -1) && (found == false))
                {
                    sr.Read(recArr, 0, 50);
                    record = new string(recArr);

                    string id = record.Substring(0, 5);
                    string name2 = record.Substring(5, 20);
                    string email = record.Substring(25, 25);

                    id = id.Trim('\0');
                    name2 = name2.Trim('\0');
                    email = email.Trim('\0');


                    if (name == name2)
                    {
                        searchID = id;
                        found = true;

                    }
                }
                if (found == false)
                {
                    MessageBox.Show("Author does not exist.");
                }
            }
            sr.Close();
            fs.Close();

            FileStream fss = new FileStream("Books.txt", FileMode.OpenOrCreate);
            StreamReader srr = new StreamReader(fss);

            bool found2 = false;
            Book b = new Book();

            string[] record2, field2;
            List<Book> x = new List<Book>();

            while ((srr.Peek() != -1) && (found2 == false))
            {


                record2 = srr.ReadLine().Split('#');

                for (int i = 0; i < record2.Length - 1; i++)
                {

                    field2 = record2[i].Split('@');

                    b = new Book(field2[0], field2[1], field2[2], field2[3]);

                    if (searchID == field2[3])
                    {
                        label2.Text = "Serial Number";
                        label3.Text = "Book Name";
                        label4.Text = "Publish Year";
                        label5.Text = "Author ID";
                        x.Add(b);
                        found2 = true;
                    }
                }
                if (found2 == false)
                {
                    MessageBox.Show("Author did not publish any books.");
                }
            }
            srr.Close();
            fss.Close();


            for (int i = 0; i < x.Count; i++)
            {
                label6.Text += x[i].SerialNumber + '\n';
                label7.Text += x[i].BookName + '\n';
                label8.Text += x[i].PublishYear + '\n';
                label9.Text += x[i].AuthorId + '\n';

                authorName.Text = "";
            }
        }

        private void ViewBooksOfSpecificAuthor_Load(object sender, EventArgs e)
        {

        }
    }
}

