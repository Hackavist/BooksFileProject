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
using Books_File_Project.Admin;
using Books_File_Project.User;

namespace Books_File_Project
{
    public partial class AdminLogIn : Form
    {
        public AdminLogIn()
        {
            InitializeComponent();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {

            string username = UserName.Text;
            string password = Password.Text;

            string[] record, field;

            bool find = false;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter username and password.");
            }
            else
            {
                FileStream fs = new FileStream("Admin.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);

                while (sr.Peek() != -1 && find == false)
                {
                    record = sr.ReadLine().Split('#');

                    for (int i = 0; i < record.Length - 1; i++)
                    {
                        field = record[i].Split('@');

                        string un = field[0];
                        string pass = field[1];

                        if (username == un && password == pass)
                        {
                            find = true;

                            AdminControls ad = new AdminControls();
                            ad.Show();
                            this.Hide();
                            this.Close();

                        }
                        else if (username == un && password != pass)
                        {
                            find = true;
                            MessageBox.Show("Wrong password.");
                        }
                    }

                    if (find == false)
                    {
                        MessageBox.Show("Admin not found.");
                    }

                }

                sr.Close();
                fs.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UserWelcome ad = new UserWelcome();
            ad.Show();
            this.Hide();
            this.Close();
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            UserWelcome ad = new UserWelcome();
            ad.Show();
            this.Hide();
            this.Close();
        }

        private void AdminLogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
