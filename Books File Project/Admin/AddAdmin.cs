﻿using System;
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

   

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("Admin.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
           string username= usernametextbox.Text;
            string passward = passwardtextbox.Text;
            if(username.Length<=0||passward.Length<=0)
            {
                MessageBox.Show("Please enter the required data");
            }
            string All = username + "@" + passward + "#";
            sw.Write(All);
            sw.Close();
            fs.Close();
            MessageBox.Show("The Author is added");
        }

     
    }
}