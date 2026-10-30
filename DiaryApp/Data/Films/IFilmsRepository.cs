using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiaryApp.Models;

namespace DiaryApp.Data.Films
{
    public interface IFilmsRepository
    {
        List<Film> GetAllFilms();
        bool AddFilm(Film film);
        bool UpdateFilm(Film film);
        bool DeleteFilm(Film film);
    }
}
