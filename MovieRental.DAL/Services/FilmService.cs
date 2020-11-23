using ADOLibrary;
using MovieRental.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;


namespace MovieRental.DAL.Services
{
    public class FilmService : ServiceBase<int, Film>
    {
        private Film Converter(SqlDataReader reader)
        {
            return new Film(

                 (int)reader["FilmId"],
                 reader["Title"].ToString(),
                 reader["Description"].ToString(),
                 (int)reader["ReleaseYear"],
                 (int)reader["LanguageId"],
                 (int)reader["RentalDuration"],
                 (decimal)reader["RentalPrice"],
                 (int)reader["Length"],
                 (decimal)reader["ReplacementCost"],
                 (int)reader["RatingId"]
                 );
        }

        public IEnumerable<Film> GetByActor(string last)
        {
            Command cmd = new Command("GetFilmByActor", true);
            cmd.AddParameter("LastName", last);
            return connection.ExecuteReader<Film>(cmd, Converter);
        }
        public IEnumerable<Film> GetByCategory(string last)
        {
            Command cmd = new Command("GetFilmByCategory", true);
            cmd.AddParameter("catName", last);
            return connection.ExecuteReader<Film>(cmd, Converter);
        }
        public IEnumerable<Film> GetByLanguage(string last)
        {
            Command cmd = new Command("GetFilmByLanguage", true);
            cmd.AddParameter("Language", last);
            return connection.ExecuteReader<Film>(cmd, Converter);
        }
        public IEnumerable<Film> GetByTitle(string last)
        {
            Command cmd = new Command("GetFilmByTitle", true);
            cmd.AddParameter("Title", last);
            return connection.ExecuteReader<Film>(cmd, Converter);
        }
        public IEnumerable<Film> GetByKeyword(string last)
        {
            Command cmd = new Command("GetFilmByKeyWord", true);
            cmd.AddParameter("KeyWord", last);
            return connection.ExecuteReader<Film>(cmd, Converter);
        }



        public override bool Delete(int key)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Film> GetAll()
        {
            Command cmd = new Command("GetAllFilm", true);
            return connection.ExecuteReader<Film>(cmd, Converter);
        }

      

        public override Film GetById(int key)
        {
            throw new NotImplementedException();
        }

        public override int Insert(Film entity)
        {
            throw new NotImplementedException();
        }

        public override bool Update(Film entity)
        {
            throw new NotImplementedException();
        }
    }
}
