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
            if (string.IsNullOrEmpty(SerialNumber.Text) || string.IsNullOrEmpty(BookName.Text) || string.IsNullOrEmpty(PublishYear.Text) || string.IsNullOrEmpty(AuthorId.Text) || string.IsNullOrWhiteSpace(SerialNumber.Text) || string.IsNullOrWhiteSpace(Book_Name.Text) || string.IsNullOrWhiteSpace(PublishYear.Text) || string.IsNullOrWhiteSpace(AuthorId.Text))
            {
                MessageBox.Show("PLease enter the required data.");
            }
            else
            {

                FileStream File = new FileStream("Books.txt", FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(File);


                if (AuthorId.Text.Length > 5)
                {
                    MessageBox.Show("Author ID must not exceed 5 characters.");
                }
                else
                {
                    MessageBox.Show("The book is being added.");
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
                    MessageBox.Show("Book added sucssefully.");

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


            if (AuthorId.Text == "" || SerialNumber.Text == "" || PublishYear.Text == "" || BookName.Text == "")
            {
                MessageBox.Show("Please enter the required data.");
            }
            else
            {
                if (AuthorId.Text.Length > 5)
                {
                    MessageBox.Show("Author ID must not exceed 5 characters.");
                }
                else
                {
                    MessageBox.Show("The book is being added.");
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
                    MessageBox.Show("Book added sucssefully.");

                    //resets the text boxes 
                    SerialNumber.Clear();
                    BookName.Clear();
                    PublishYear.Clear();
                    AuthorId.Clear();
                }
            }
            sw.Close();
            File.Close();
        }

        private void AddBook_Load(object sender, EventArgs e)
        {

        }
    }
}
