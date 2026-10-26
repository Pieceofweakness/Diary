using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryApp.Models
{
    public class Game
    {
        public int id_game { get; set; }
        public string name_game { get; set; }
        public string studio { get; set; }
        public DateOnly start { get; set; }
        public DateOnly finish { get; set; }
        public string status { get; set; }
        public double grade { get; set; }
        public string note { get; set; }
    }
}
