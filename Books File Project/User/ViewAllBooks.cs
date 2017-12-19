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
            //label1.Text = "";

            Book bk = new Book();

            FileStream fs = new FileStream("Books.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string[] fields;
            string[] records;
            int hight = 180;


            while (sr.Peek() != -1)
            {
                records = sr.ReadLine().Split('#');
                for (int i = 0; i < records.Length - 1; i++)
                {
                    fields = records[i].Split('@');
                    VALB v = new VALB(fields[0], fields[1], fields[2], fields[3]);

                    this.Controls.Add(v);

                    v.Location = new Point(30, hight);
                    hight += 60;



                    /*  label1.Text += fields[0] + '\n';
                         label2.Text += fields[1] + '\n';
                         label3.Text += fields[2] + '\n';
                         label4.Text += fields[3] + '\n';*/

                }

            }
            sr.Close();
            fs.Close();

        }

        private void Back_Click(object sender, EventArgs e)
        {
            UW.Show();
            this.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            UW.Show();
            this.Close();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            UW.Close();
            this.Close();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            UW.Close();
            this.Close();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            UW.Show();
            this.Close();
        }


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }






    }
}