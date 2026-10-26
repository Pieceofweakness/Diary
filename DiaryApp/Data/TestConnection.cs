using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace DiaryApp.Data
{
    public class TestConnection
    {
        public string connectionString = $"Host=localhost;Port=5432;Database=diaryDB;Username=postgres;Password=1234";


        public IDbConnection GetConnection()
        {
            return new NpgsqlConnection(connectionString);
        }

        public string Test()
        {
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    return "LIKE";
                }
            }
            catch
            {
                return "DISLIKE";
            }
            
        }
    }

}
