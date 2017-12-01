using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_File_Project.Classes
{
    class Author
    {
        public string AuthorName { get; set; }
        public string AuthorID { get; set; }
        public string AuthorEmail { get; set; }

        public Author()
        {
            AuthorName = "";
            AuthorID = "";
            AuthorEmail = "";
        }
        public Author(string id, string name, string email)
        {
            AuthorName = name;
            AuthorID = id;
            AuthorEmail = email;
        }
    }
}
