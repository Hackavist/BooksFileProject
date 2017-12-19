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
    public partial class AddAdmin : Form
    {
        public AddAdmin()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            AdminControls ad = new AdminControls();
            ad.Show();
            this.Hide();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            string username = usernametextbox.Text;
            string passward = passwardtextbox.Text;

            if (username.Length <= 0 || passward.Length <= 0)
            {
                MessageBox.Show("Please enter the required data.");
            }
            else
            {

                FileStream fs = new FileStream("Admin.txt", FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs);
                string thefile = sr.ReadLine();
                if (thefile != null)
                {

                    string[] records = thefile.Split('#');
                    for (int i = 0; i < records.Length - 1; i++)
                    {
                        string[] fields = records[i].Split('@');
                        if (fields[0] == username)
                        {
                            sr.Close();
                            fs.Close();
                            MessageBox.Show("This Admin name already exist!");
                            return;
                        }
                    }

                }
                sr.Close();
                fs.Close();
                fs = new FileStream("Admin.txt", FileMode.Append);
                StreamWriter sw = new StreamWriter(fs);

                string All = username + "@" + passward + "#";

                sw.Write(All);

                sw.Close();
                fs.Close();
                usernametextbox.Clear();
                passwardtextbox.Clear();
                MessageBox.Show("Admin added.");
            }
        }

        private void AddAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
