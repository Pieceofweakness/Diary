using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryApp.Models
{
    public class Film
    {
        public int id_film { get;set;}
        public string name_film { get; set; }
        public string director { get; set; }
        public DateOnly start { get; set; }
        public DateOnly finish { get; set; }
        public string status { get; set; }
        public double grade { get; set; }
        public string note { get; set; }

    }
}
