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
                MessageBox.Show("Please Enter Username And Password");

            }
            else
            {
                FileStream fs = new FileStream("Admin.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                while (sr.Peek() != -1 && find == false)
                {
                    record = sr.ReadLine().Split('#');

                    for (int i = 0; i < record.Length-1; i++)
                    {
                        field = record[i].Split('@');
                        string un = field[0];
                        string pass = field[1];

                        if (username == un && password == pass)
                        {
                            find = true;
                            MessageBox.Show("Successful Log In");
                            AdminControls ad = new AdminControls();
                            ad.Show();
                            this.Close();

                        }
                        else if(username!=un || password!=pass)
                        {
                            MessageBox.Show("Wrong Username Or Password");
                        }
                    }
                    if (find == false)
                {
                    MessageBox.Show("Admin Not Found");
                }

                }
               
                sr.Close();
                fs.Close();
            }
        }
    }
}
