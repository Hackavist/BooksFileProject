using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Books_File_Project.Classes;
using System.IO;
namespace Books_File_Project.Admin
{
    public partial class RemoveAdmin : Form
    {
        public RemoveAdmin()
        {
            InitializeComponent();
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            AdminControls ad = new AdminControls();
            ad.Show();
            this.Hide();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text;
            if (username.Length == 0)
            {
                MessageBox.Show("Please enter the username.");
            }
            else if (areyousure.Checked == false)
            {
                MessageBox.Show("Mark the checkbox to remove the admin.");
            }
            else
            {
                List<AdminClass> listofadmins = new List<AdminClass>();
                FileStream f = new FileStream("Admin.txt", FileMode.OpenOrCreate);
                StreamReader rs = new StreamReader(f);
                string fullfile = rs.ReadLine();
                string[] records = fullfile.Split('#');
                for (int i = 0; i < records.Length - 1; i++)
                {
                    string[] fields = records[i].Split('@');
                    AdminClass tmp = new AdminClass(fields[0], fields[1]);
                    listofadmins.Add(tmp);

                }
                f.SetLength(0);
                rs.Close();
                f.Close();
                bool found = false;
                for (int i = 0; i < listofadmins.Count; i++)
                {
                    if (listofadmins[i].Username == username)
                    {
                        listofadmins.RemoveAt(i);
                        found = true;
                    }
                }


                f = new FileStream("Admin.txt", FileMode.OpenOrCreate);
                StreamWriter sw = new StreamWriter(f);
                for (int i = 0; i < listofadmins.Count; i++)
                {
                    sw.Write(listofadmins[i].Username + '@' + listofadmins[i].Password + '#');
                }
                sw.Close();
                f.Close();
                if (found == true)
                {
                MessageBox.Show("Admin removed.");

                }
                else
                {
                    MessageBox.Show("this Admin name Not found.");
                }
                UsernameTextBox.Text = "";
                areyousure.Checked = false;
            }
        }

        private void RemoveAdmin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
