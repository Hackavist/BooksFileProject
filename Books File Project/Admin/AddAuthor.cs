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

namespace Books_File_Project.Admin
{
    public partial class AddAuthor : Form
    {
        public AddAuthor()
        {
            InitializeComponent();
        }


        private void AddAuthroButton_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("Authors.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);

            string name  = AuthorNameText.Text;
            string id    = AuthorIDText.Text;
            string email = AuthorEmailText.Text;

            char[] record = new char[50];

            id.CopyTo(0, record, 0, id.Length);
            name.CopyTo(0, record, 5, name.Length);
            email.CopyTo(0, record, 25, email.Length);

            sw.Write(record, 0, 50);

            sw.Close();

            AuthorNameText.Text  = "";
            AuthorIDText.Text    = "";
            AuthorEmailText.Text = "";

            MessageBox.Show("Author added.");
        }

        private void BackBTN_Click(object sender, EventArgs e)
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

        private void AuthorNameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            bool exist = false;
            

            string name = AuthorNameText.Text;
            string id = AuthorIDText.Text;
            string email = AuthorEmailText.Text;

            if (name == "" || id == "" || email == "")
            {
                MessageBox.Show("Please enter the required data.");
            }
           else if(id.Length < 5 )
            {
                MessageBox.Show("ID must be 5 digits");
            }
            else
            {
                FileStream fss = new FileStream("Authors.txt", FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fss);

                while (sr.Peek() != -1 && exist == false)
                {
                    char[] authorid= new char[5], authorname=new char[20], authoremail=new char[25];
                    char[] record = new char[50];
                    
                    sr.Read(record, 0, 50);
                    string Srecord = new string(record);
                    Srecord.CopyTo(0, authorid, 0, 5);
                    Srecord.CopyTo(5, authorname, 0, 20);
                    Srecord.CopyTo(25, authoremail, 0, 25);

                    if (new string (authorname).Trim('\0')==name)
                    {
                        exist = true;
                        MessageBox.Show("Author name already exists.");
                    }
                    else if (new string(authorid).Trim('\0') == id)
                    {
                        exist = true;
                        MessageBox.Show("ID already exists.");
                    }
                    else if (new string(authoremail).Trim('\0') == email)
                    {
                        exist = true;
                        MessageBox.Show("Email already exists.");
                    }
                }

                sr.Close();
                fss.Close();

                if (exist == false)
                {
                    FileStream fs = new FileStream("Authors.txt", FileMode.Append);
                    StreamWriter sw = new StreamWriter(fs);
                    char[] record = new char[50];

                    id.CopyTo(0, record, 0, id.Length);
                    name.CopyTo(0, record, 5, name.Length);
                    email.CopyTo(0, record, 25, email.Length);

                    sw.Write(record, 0, 50);

                    sw.Close();
                    fs.Close();

                    AuthorNameText.Text = "";
                    AuthorIDText.Text = "";
                    AuthorEmailText.Text = "";

                    MessageBox.Show("Author added.");
                }
            }
        }

        private void AddAuthor_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Admin.AddBook book = new Admin.AddBook();
            book.Show();
            this.Hide();
        }
    }
}
