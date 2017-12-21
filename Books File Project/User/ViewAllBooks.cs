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
using Books_File_Project.Classes;
namespace Books_File_Project.User
{
    public partial class ViewAllBooks : Form
    {
        UserWelcome UW = new UserWelcome();
        public ViewAllBooks(UserWelcome uw)
        {

            InitializeComponent();
            UW = uw;
        }

        List<String> s = new List<string>();

        private void ViewAllBooks_Load(object sender, EventArgs e)
        {
            Book bk = new Book();

            FileStream fs = new FileStream("Books.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            string[] fields;
            string[] records;
            int hight = 180;

            while (sr.Peek() != -1)
            {
                records = sr.ReadLine().Split('#');

                for (int i = 0; i < records.Length-1 ; i++)
                {
                    fields = records[i].Split('@');
                    VALB v = new VALB(fields[0], fields[1], fields[2], fields[3]);


                    flowLayoutPanel1.Controls.Add(v);
                    v.Location = new Point(100, hight);


                    hight += 60;



                }

            }
            sr.Close();
            fs.Close();

        }



        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            UW.Show();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}