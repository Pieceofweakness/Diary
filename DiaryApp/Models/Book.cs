using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryApp.Models
{
    public class Book
    {
        public int id_book { get; set; }
        public string name_book { get; set; }
        public string author { get; set; }
        public DateOnly start { get; set; }
        public DateOnly finish { get; set; }
        public string status { get; set; }
        public double grade { get; set; }
        public string note { get; set; }
    }
}
