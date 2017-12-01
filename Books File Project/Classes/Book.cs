using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_File_Project.Classes
{
    class Book
    {
        public string BookName { get; set; }
        public string SerialNumber { get; set; }
        public string PublishYear { get; set; }
        public string AuthorId { get; set; }

        public Book()
        {
            BookName = "";
            SerialNumber = "";
            PublishYear = "";
            AuthorId = "";
        }

        public Book( string bn, string sn ,string py , string ai)
        {
            BookName = bn;
            SerialNumber = sn;
            PublishYear = py;
            AuthorId = ai;
        }

    }

    
}
