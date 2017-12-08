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
            FileStream fs = new FileStream("Authors.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);

            string name = AuthorNameText.Text;
            string id = AuthorIDText.Text;
            string email = AuthorEmailText.Text;

            if (name == "" || id == "" || email == "")
            {
                MessageBox.Show("Please enter the required data.");
            }
            else
            {
                char[] record = new char[50];

                id.CopyTo(0, record, 0, id.Length);
                name.CopyTo(0, record, 5, name.Length);
                email.CopyTo(0, record, 25, email.Length);

                sw.Write(record, 0, 50);

                sw.Close();

                AuthorNameText.Text = "";
                AuthorIDText.Text = "";
                AuthorEmailText.Text = "";

                MessageBox.Show("Author added.");
            }
        }

        private void AddAuthor_Load(object sender, EventArgs e)
        {

        }
    }
}
