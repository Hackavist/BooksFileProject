using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Books_File_Project
{
    public partial class VALB : UserControl
    {
        string serial, name, year, id;
        public VALB(string a ,string b,string c,string d)
        {
            InitializeComponent();
            serial = a;
            name = b;
            year = c;
            id = d;
        }

        private void VALB_Load(object sender, EventArgs e)
        {
            label1.Text = serial;
            label2.Text = name;
            label3.Text = year;
            label4.Text = id;
        }
    }
}
