using System;
using System.IO;
using System.Windows.Forms;

namespace Books_File_Project.Admin
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void AddBookBtn_Click(object sender, EventArgs e)
        {
            FileStream File = new FileStream("Books.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(File);


            if (AuthorId.Text.Length > 5)
            {
                MessageBox.Show("Author Id Must Not Exceed 5 Characters ! ");
            }
            else
            {
                MessageBox.Show("The Book is being Added ");
                //writes the book using '@' dilimter only if the auther id is valid 
                sw.Write(SerialNumber.Text);
                sw.Write('@');
                sw.Write(BookName.Text);
                sw.Write('@');
                sw.Write(PublishYear.Text);
                sw.Write('@');
                sw.Write(AuthorId.Text);
                sw.Write('#');

                // Confirms the addition to the user 
                MessageBox.Show("The Books has been Added Sucssefully ");

                //resets the text boxes 
                SerialNumber.Clear();
                BookName.Clear();
                PublishYear.Clear();
                AuthorId.Clear();
            }

            sw.Close();
            File.Close();
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

            FileStream File = new FileStream("Books.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(File);


            if (AuthorId.Text.Length > 5)
            {
                MessageBox.Show("Author Id Must Not Exceed 5 Characters ! ");
            }
            else
            {
                MessageBox.Show("The Book is being Added ");
                //writes the book using '@' dilimter only if the auther id is valid 
                sw.Write(SerialNumber.Text);
                sw.Write('@');
                sw.Write(BookName.Text);
                sw.Write('@');
                sw.Write(PublishYear.Text);
                sw.Write('@');
                sw.Write(AuthorId.Text);
                sw.Write('#');

                // Confirms the addition to the user 
                MessageBox.Show("The Books has been Added Sucssefully ");

                //resets the text boxes 
                SerialNumber.Clear();
                BookName.Clear();
                PublishYear.Clear();
                AuthorId.Clear();
            }

            sw.Close();
            File.Close();
        }
    }
}
