using System;
using System.IO;
using System.Windows.Forms;
using Books_File_Project.Admin;

namespace Books_File_Project.Admin
{
    public partial class AdminControls : Form
    {
        public AdminControls()
        {
            InitializeComponent();
        }


        private void AddBook_Click(object sender, EventArgs e)
        {
            Admin.AddBook book = new Admin.AddBook();
            book.Show();
            this.Hide();
        }

        private void AddAuther_Click(object sender, EventArgs e)
        {
            Admin.AddAuthor auth = new AddAuthor();
            auth.Show();
            this.Hide();
        }

        private void AddAdmin_Click(object sender, EventArgs e)
        {
            Admin.AddAdmin ad = new Admin.AddAdmin();
            ad.Show();
            this.Hide();

        }

        private void RemoveAdmin_Click(object sender, EventArgs e)
        {
            Admin.RemoveAdmin re = new Admin.RemoveAdmin();
            re.Show();
            this.Hide();
        }

        private void SignOut_Click(object sender, EventArgs e)
        {
            User.UserWelcome uw = new User.UserWelcome();
            uw.Show();
            this.Hide();
            this.Close();
        }
       //
        private void authoradd_Click(object sender, EventArgs e)
        {
            Admin.AddAuthor auth = new AddAuthor();
            auth.Show();
            this.Hide();
        }

        private void adminadd_Click(object sender, EventArgs e)
        {
            Admin.AddAdmin ad = new Admin.AddAdmin();
            ad.Show();
            this.Hide();
        }

        private void adminremove_Click(object sender, EventArgs e)
        {
            Admin.RemoveAdmin re = new Admin.RemoveAdmin();
            re.Show();
            this.Hide();
        }

        private void bookadd_Click(object sender, EventArgs e)
        {
            Admin.AddBook book = new Admin.AddBook();
            book.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            User.UserWelcome uw = new User.UserWelcome();
            uw.Show();
            this.Hide();
            this.Close();
        }
    }
}
