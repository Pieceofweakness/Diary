using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiaryApp.Models;

namespace DiaryApp.Data.Films
{
    public class FilmsRepository: IFilmsRepository
    {



        public List<Film> GetAllFilms()
        {
            return null;
        }


        public bool AddFilm(Film film)
        {
            return false;
        }

        public bool UpdateFilm(Film film)
        {
            return false;
        }

        public bool DeleteFilm(Film film)
        {
            return false;   
        }


    }
}
