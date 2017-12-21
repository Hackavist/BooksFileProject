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
    public partial class ViewAllAuthors : Form
    {
        public ViewAllAuthors()
        {
            InitializeComponent();
        }

        List<Author> ListOfAuthors = new List<Author>();
        private void DisplayInGridView(SortedDictionary<string, Author> ToDisplay)
        {
            dataGridView1.Rows.Clear();
            foreach (var tmp in ToDisplay)
            {
                string[] x = new string[3];

                x[0] = tmp.Value.AuthorID;
                x[1] = (tmp.Value.AuthorName);
                x[2] = tmp.Value.AuthorEmail;

                dataGridView1.Rows.Add(x);
            }
        }

        private void ViewAllAuthors_Load(object sender, EventArgs e)
        {
            FileStream f = new FileStream("Authors.txt", FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(f);

            while (sr.Peek() != -1)
            {
                char[] id = new char[5];
                char[] name = new char[20];
                char[] email = new char[25];
                char[] togetfromfile = new char[50];

                sr.Read(togetfromfile, 0, 50);

                string tmp = new string(togetfromfile);

                tmp.CopyTo(0, id, 0, 5);
                tmp.CopyTo(5, name, 0, 20);
                tmp.CopyTo(25, email, 0, 25);

                string[] x = new string[3];

                x[0] = new string(id);
                x[1] = new string(name);
                x[2] = new string(email);

                Author toadd = new Author(x[0], x[1], x[2]);

                dataGridView1.Rows.Add(x);

                ListOfAuthors.Add(toadd);

            }

            sr.Close();
            f.Close();

        }

        private void SortById_Click(object sender, EventArgs e)
        {
            SortedDictionary<string, Author> todisplay = new SortedDictionary<string, Author>();

            for (int i = 0; i < ListOfAuthors.Count; i++)
            {
                todisplay[ListOfAuthors[i].AuthorID] = ListOfAuthors[i];
            }

            DisplayInGridView(todisplay);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SortedDictionary<string, Author> todisplay = new SortedDictionary<string, Author>();

            for (int i = 0; i < ListOfAuthors.Count; i++)
            {
                todisplay[ListOfAuthors[i].AuthorName] = ListOfAuthors[i];
            }

            DisplayInGridView(todisplay);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SortedDictionary<string, Author> todisplay = new SortedDictionary<string, Author>();

            for (int i = 0; i < ListOfAuthors.Count; i++)
            {
                todisplay[ListOfAuthors[i].AuthorEmail] = ListOfAuthors[i];
            }

            DisplayInGridView(todisplay);
        }

        private void SortByName_Click(object sender, EventArgs e)
        {
            SortedDictionary<string, Author> todisplay = new SortedDictionary<string, Author>();

            for (int i = 0; i < ListOfAuthors.Count; i++)
            {
                todisplay[ListOfAuthors[i].AuthorName] = ListOfAuthors[i];
            }

            DisplayInGridView(todisplay);
        }

        private void SortByEmail_Click(object sender, EventArgs e)
        {
            SortedDictionary<string, Author> todisplay = new SortedDictionary<string, Author>();

            for (int i = 0; i < ListOfAuthors.Count; i++)
            {
                todisplay[ListOfAuthors[i].AuthorEmail] = ListOfAuthors[i];
            }

            DisplayInGridView(todisplay);
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
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            UserWelcome uw = new UserWelcome();
            uw.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
