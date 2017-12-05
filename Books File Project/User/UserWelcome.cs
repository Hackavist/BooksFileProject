using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Books_File_Project.User;

namespace Books_File_Project.User
{
    public partial class UserWelcome : Form
    {
        public UserWelcome()
        {
            InitializeComponent();
        }

        private void VIewAllBooks_Click(object sender, EventArgs e)
        {
            ViewAllBooks vb = new ViewAllBooks();
            vb.Show();
            this.Hide();
            this.Close();
        }

        private void ViewAllAuthors_Click(object sender, EventArgs e)
        {
            User.ViewAllAuthors va = new ViewAllAuthors();
            va.Show();
            this.Hide();
            this.Close();
        }

        private void ViewBooksInYear_Click(object sender, EventArgs e)
        {
            User.ViewBooksInSpecificYear vby = new ViewBooksInSpecificYear();
            vby.Show();
            this.Hide();
            this.Close();
        }

        private void AdminSign_Click(object sender, EventArgs e)
        {
            AdminLogIn ad = new AdminLogIn();
            ad.Show();
            this.Hide();
            this.Close();
        }

        private void UserWelcome_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            ViewAllBooks vb = new ViewAllBooks();
            vb.Show();
            this.Hide();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            User.ViewAllAuthors va = new ViewAllAuthors();
            va.Show();
            this.Hide();
            this.Close();
        }
    }
}
