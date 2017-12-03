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
    public partial class ViewBooksInSpecificYear : Form
    {
        public ViewBooksInSpecificYear()
        {
            InitializeComponent();
        }






        private void EnterButton_Click(object sender, EventArgs e)
        {
            //each label appears only when the button is clicked
            label2.Text = "Serial Number";
            label3.Text = "Book Name";
            label4.Text = "Publish Year";
            label5.Text = "Author ID";
            
            //open the file and read the book's data
            FileStream fs = new FileStream("Books.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            //get the year from textbox
            string year = YearTextBox.Text;
            bool find = false;

            string[] field, record;

            //each time empty the previous data
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";

            //object of class book -> constructor with all the data
            Book BookObj = new Book();

            //list of type book to display all data at once
            List<Book> SaveBookObj = new List<Book>();

            //check if the user didn't enter the year or entered a space
            if (string.IsNullOrEmpty(YearTextBox.Text) || string.IsNullOrWhiteSpace(YearTextBox.Text) /* || mesh arkam */)
            {
                MessageBox.Show("Please Enter Publish Year ");
            }
            else
            {
                while (sr.Peek() != -1 && find == false)
                {


                    record = sr.ReadLine().Split('#');

                    for (int i = 0; i < record.Length - 1; i++)
                    {

                        field = record[i].Split('@');

                        //conctructor overloaded with book's data
                        BookObj = new Book(field[0], field[1], field[2], field[3]);




                        if (year == field[2])
                        {
                            //save the book's data in a list
                            SaveBookObj.Add(BookObj);
                            find = true;
                        }
                    }

                    if (find == false)
                    {
                        MessageBox.Show("No Books Published in " + year);
                    }
                }
            }
                sr.Close();
                fs.Close();

                for (int i = 0; i < SaveBookObj.Count; i++)
                {
                //display every element in the list in each label
                    label6.Text += SaveBookObj[i].SerialNumber + '\n';
                    label7.Text += SaveBookObj[i].BookName + '\n';
                    label8.Text += SaveBookObj[i].PublishYear + '\n';
                    label9.Text += SaveBookObj[i].AuthorId + '\n';
                }
                //empty the textbox for the next entry
                YearTextBox.Text = "";
            
        }
    }
}
