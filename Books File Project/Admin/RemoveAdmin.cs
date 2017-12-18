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
using Books_File_Project.User;
namespace Books_File_Project.Admin
{
    public partial class RemoveAdmin : Form
    {
        List<AdminClass> listofadmins;
        public RemoveAdmin()
        {
            
            InitializeComponent();
            listofadmins = AdminClass.GetAllAdmins();
            FillTheComboBox();

        }
        void FillTheComboBox()
        {
            AdminsName.Items.Clear();
            foreach (var x in listofadmins)
            {
                if (x.Username != UserWelcome.GeneralManager)
                {
                    AdminsName.Items.Add(x.Username);

                }
            }
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            AdminControls ad = new AdminControls();
            ad.Show();
            this.Hide();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            string username ="";
            
            if (areyousure.Checked == false)
            {
                MessageBox.Show("Mark the checkbox to remove the admin.");
            }
            else if (AdminsName.SelectedIndex==-1)
            {
                MessageBox.Show("Please select some admin to delete");
                
            }
            else
            {
                username = AdminsName.SelectedItem.ToString();
                foreach (var x in listofadmins)
                {
                    if (x.Username == username)
                    {
                        listofadmins.Remove(x);
                        break;
                    }
                }
                FileStream f = new FileStream("Admin.txt", FileMode.OpenOrCreate);
                StreamWriter sw = new StreamWriter(f);
                f.SetLength(0);
                for (int i = 0; i < listofadmins.Count; i++)
                {
                    sw.Write(listofadmins[i].Username + '@' + listofadmins[i].Password + '#');
                }
                sw.Close();
                f.Close();
                MessageBox.Show("The admin deleted");
                AdminsName.SelectedIndex = -1 ;
                FillTheComboBox();
            }
        }

        private void RemoveAdmin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
