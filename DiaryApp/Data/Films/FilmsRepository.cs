using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DiaryApp.Models;
using Npgsql;

namespace DiaryApp.Data.Films
{
    public class FilmsRepository: IFilmsRepository
    {
        private readonly string connectionString = $"Host=localhost;Port=5432;Database=diaryDB;Username=postgres;Password=1234";


        public List<Film> GetAllFilms()
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string sql = @"SELECT * FROM films";

                return conn.Query<Film>(sql).ToList();
            }
        }


        public bool AddFilm(Film film)
        {
            using(var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string sql = @"INSERT INTO films(name_film,director,start,finish,status,grade,note)
                             VALUES (@name_film,@director,@start,@finish,@status::status,@grade,@note)";

                var result = conn.Execute(sql, new
                {
                    film.name_film,
                    film.director,
                    film.start,
                    film.finish,
                    film.status,
                    film.grade,
                    film.note
                });




                return result > 0;
            }
        }

        public bool UpdateFilm(Film film)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string sql = @"UPDATE films set
                             name_film = @name_film,
                             director = @director,
                             start = @start,
                             finish = @finish,
                             status = @status::status,
                             grade = @grade,
                             note = @note
                            WHERE id_film = @id_film";
                return conn.Execute(sql, film) > 0;
            }
        }

        public bool DeleteFilm(Film film)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                string sql = @"DELETE FROM films
                             WHERE id_film = @id_film";
                return conn.Execute(sql,film) > 0;
            }
        }


    }
}
