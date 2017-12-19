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
using Books_File_Project.Properties;
using Books_File_Project;
namespace Books_File_Project.User
{
    public partial class UserWelcome : Form
    {
        public UserWelcome()
        {
            InitializeComponent();
        }

        public static string GeneralManager = "admin1";
        private void books_Click(object sender, EventArgs e)
        {
            UserWelcome UW = new UserWelcome();

            ViewAllBooks vb = new ViewAllBooks(UW);
            vb.Show();
            this.Hide();
            this.Close();
        }

        
        private void admin_Click(object sender, EventArgs e)
        {

            AdminLogIn ad = new AdminLogIn();
            ad.Show();
            this.Hide();
            this.Close();
        }

        private void books_MouseHover(object sender, EventArgs e)
        {
            books.Image = Resources.view_all_books;

        }
        private void books_MouseLeave_1(object sender, EventArgs e)
        {
            books.Image = Resources.books;
        }

       

        private void UserWelcome_Load(object sender, EventArgs e)
        {
            admin.Size = new Size(42, 42);
        }

        private void shakes_MouseHover(object sender, EventArgs e)
        {
            shakes.Image = Resources.view_all_authors;
        }

        private void shakes_MouseLeave(object sender, EventArgs e)
        {
            shakes.Image = Resources.shakespeare;
        }

        private void calender_MouseHover(object sender, EventArgs e)
        {
            calender.Image = Resources.view_books_in_a_specific_year;
        }

        private void calender_MouseLeave(object sender, EventArgs e)
        {
            calender.Image = Resources.calendar__2_;
        }

        private void name_MouseHover(object sender, EventArgs e)
        {
            name.Image = Resources.view_books_by_specific_author;
        }

        private void name_MouseLeave(object sender, EventArgs e)
        {
            name.Image = Resources.user_name;
        }

        private void admin_MouseHover(object sender, EventArgs e)
        {
            admin.Image = Resources.admin_with_cogwheels_after;
            
            admin.Size = new Size(50, 50);
        }

        private void admin_MouseLeave(object sender, EventArgs e)
        {
            admin.Image = Resources.admin_with_cogwheels_before;
            admin.Size = new Size(42, 42);
        }

        private void shakes_Click(object sender, EventArgs e)
        {
            ViewAllAuthors va = new ViewAllAuthors();
            va.Show();
            this.Hide();
            this.Close();
        }

        private void calender_Click(object sender, EventArgs e)
        {
            ViewBooksInSpecificYear vsy = new ViewBooksInSpecificYear();
            vsy.Show();
            this.Hide();
            this.Close();
        }

        private void name_Click(object sender, EventArgs e)
        {
            ViewBooksOfSpecificAuthor vsa = new ViewBooksOfSpecificAuthor();
            vsa.Show();
            this.Hide();
            this.Close();
        }
    }
}
