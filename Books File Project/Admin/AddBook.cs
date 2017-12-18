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

namespace Books_File_Project.Admin
{
    public partial class AddBook : Form
    {
        public Dictionary<string, string> dic = new Dictionary<string, string>();
        public AddBook()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            AdminControls ad = new AdminControls();
            ad.Show();
            this.Hide();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AdminControls ad = new AdminControls();
            ad.Show();
            this.Hide();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (SerialNumber.Text == "" || PublishYear.Text == "" || BookName.Text == "")
            {
                MessageBox.Show("Please enter the required data.");
            }
            else
            {
                bool b = false;
                FileStream fs = new FileStream("Books.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string[] fields;
                string[] records;

                while (sr.Peek() != -1)
                {
                    records = sr.ReadLine().Split('#');
                    for (int i = 0; i < records.Length - 1; i++)
                    {
                        fields = records[i].Split('@');
                        if (fields[1] == BookName.Text)
                        {
                            b = true;
                        }

                    }

                }
                sr.Close();
                fs.Close();
                if (b==false)
                {
                    FileStream File = new FileStream("Books.txt", FileMode.Append, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(File);
                    // gets the string value of the combobox 
                    string AuthorId = AutherIDs.SelectedItem.ToString();
                    //writes the book using '@' dilimter only if the auther id is valid 
                    sw.Write(SerialNumber.Text);
                    sw.Write('@');
                    sw.Write(BookName.Text);
                    sw.Write('@');
                    sw.Write(PublishYear.Text);
                    sw.Write('@');
                    sw.Write(dic[AuthorId]);


                    //resets the text boxes 
                    SerialNumber.Clear();
                    BookName.Clear();
                    PublishYear.Clear();
                    AutherIDs.SelectedText = " ";

                    // Confirms the addition to the user 
                    MessageBox.Show("Book added sucssefully.");


                    sw.Close();
                    File.Close();
                }
                else
                {
                    MessageBox.Show("Book already exists.");
                }
            }
        }

        private void AddBook_Load(object sender, EventArgs e)
        {
            FileStream f = new FileStream("Authors.txt", FileMode.Open);
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

                AutherIDs.Items.Add(x[0] + " " + x[1]);
                dic[x[0] + " " + x[1]] = x[0];

            }

            sr.Close();
            f.Close();


            foreach (var item in dic)
            {
                AutherIDs.Items.Add(item.Key);
            }
        }

        private void AutherIDs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Admin.AddAuthor auth = new AddAuthor();
            auth.Show();
            this.Hide();
        }
    }
}
