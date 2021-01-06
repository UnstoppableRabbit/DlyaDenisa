using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAdminApp
{
    public class Books
    {
        
        public Books(string title, string author, string author_id, string count, string price, string id)
            {
            this.title = title;
            this.author = author;
            this.author_id = author_id;
            this.count = count;
            this.price = price;
            this.id = id;
            }
        public string title { get; set; }
        public string author { get; set; }
        public string author_id { get; set; }
        public string count { get; set; } 
        public string price { get; set; }
        public string id { get; set; }
    }
}
