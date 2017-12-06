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


        private void name_Click(object sender, EventArgs e)
        {
            User.ViewBooksOfSpecificAuthor v = new ViewBooksOfSpecificAuthor();
            v.Show();
            this.Hide();
            this.Close();

        }

        private void shakes_Click(object sender, EventArgs e)
        {
            User.ViewAllAuthors va = new ViewAllAuthors();
            va.Show();
            this.Hide();
            this.Close();
        }

        private void books_Click(object sender, EventArgs e)
        {

            ViewAllBooks vb = new ViewAllBooks();
            vb.Show();
            this.Hide();
            this.Close();
        }

        private void calendar_Click(object sender, EventArgs e)
        {
            User.ViewBooksInSpecificYear vby = new ViewBooksInSpecificYear();
            vby.Show();
            this.Hide();
            this.Close();
        }

        private void admin_Click(object sender, EventArgs e)
        {

            AdminLogIn ad = new AdminLogIn();
            ad.Show();
            this.Hide();
            //this.Close();
        }
    }
}
