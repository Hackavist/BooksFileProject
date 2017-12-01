using System;
using System.IO;
using System.Windows.Forms;

namespace Books_File_Project.Admin
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void AddBookBtn_Click(object sender, EventArgs e)
        {
            FileStream File = new FileStream("Books.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(File);

            sw.Write(SerialNumber.Text);
            sw.Write('@');
            sw.Write(BookName.Text);
            sw.Write('@');
            sw.Write(PublishYear.Text);
            sw.Write('@');
            if (AuthorId.Text.Length > 5)
            {
                MessageBox.Show("Author Id Must Not Exceed 5 Characters ! ");
            }
            else
            {
                sw.Write(AuthorId.Text);
                sw.Write('#');
            }

            sw.Close();
            File.Close();
        }

    }
}
