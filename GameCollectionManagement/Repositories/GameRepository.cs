using GameCollectionManagement.Models;
using GameCollectionManagement.Models.Mappers;
using GameCollectionManagement.Utilities.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace GameCollectionManagement.Repositories
{
    public class GameRepository : BaseRepository<Game>
    {
        public override List<Game> GetAll()
        {
            string query = "select * from Games";

            DataTable dataTable = ExecuteQuery(query);

            List<Game> games = new List<Game>();

            foreach (DataRow row in dataTable.Rows)
            {

                games.Add(DataMappers.MapToGame(row));
            }

            return games;
        }

        public List<Game> GetList()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("select * from Games", connection);

                SqlDataReader dataReader = command.ExecuteReader();

                List<Game> games = new List<Game>();

                while (dataReader.Read())
                {

                    Game game = new Game();

                    game.Id = Convert.ToInt32(dataReader["Id"]);
                    game.Name = dataReader["Name"].ToString();
                    game.Genre = dataReader["Genre"].ToString();
                    game.Platform = dataReader["Platform"].ToString();
                    game.ReleaseDate = Convert.ToDateTime(dataReader["ReleaseDate"]);
                    game.PlayTime = Convert.ToInt32(dataReader["PlayTime"]);
                    game.CoverImage = dataReader["CoverImage"] as byte[];

                    games.Add(game);
                }

                dataReader.Close();
                return games;
            }


        }

        public override Game GetById(int id)
        {
            string query = "Select * from Games where Id=@Id";

            var parameters = new SqlParameterBuilder()
                              .AddParameter("@Id", id)
                              .Build();

            DataTable dataTable = ExecuteQuery(query, parameters);


            DataRow row = dataTable.Rows[0];



            return DataMappers.MapToGame(row);
        }

        public override void Add(Game entity)
        {
            string query = "insert into Games(Name,Genre,Platform,ReleaseDate,PlayTime,CoverImage) values(@Name,@Genre,@Platform,@ReleaseDate,@PlayTime,@CoverImage)";

           

            var parameters = new SqlParameterBuilder()

                              .AddParameter("@Name", entity.Name)
                              .AddParameter("@Genre", entity.Genre)
                              .AddParameter("@Platform", entity.Platform)
                              .AddParameter("@ReleaseDate", entity.ReleaseDate)
                              .AddParameter("@PlayTime", entity.PlayTime)
                              .AddParameterWithValue("@CoverImage", entity.CoverImage, SqlDbType.VarBinary)
                              .Build();

            ExecuteNonQuery(query, parameters);

        }

        public override void Update(Game entity)
        {
            string query = "update Games Set Name=@Name,Genre=@Genre,Platform=@Platform,ReleaseDate=@ReleaseDate,PlayTime=@PlayTime,CoverImage=@CoverImage where Id=@Id";

            

            var parameters = new SqlParameterBuilder()
                              .AddParameter("@Id", entity.Id)
                              .AddParameter("@Name", entity.Name)
                              .AddParameter("@Genre", entity.Genre)
                              .AddParameter("@Platform", entity.Platform)
                              .AddParameter("@ReleaseDate", entity.ReleaseDate)
                              .AddParameter("@PlayTime", entity.PlayTime)
                              .AddParameterWithValue("@CoverImage", entity.CoverImage, SqlDbType.VarBinary)
                              .Build();

            ExecuteNonQuery(query, parameters);
        }

        public override void Delete(int id)
        {
            string query = "delete from Games where Id=@Id";
           

            var parameters = new SqlParameterBuilder()
                              .AddParameter("@Id", id)
                              .Build();

            ExecuteNonQuery(query, parameters);
        }

        public override void Delete(Game entity)
        {

            string query = "delete from Games where Id=@Id";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter ("@Id",entity.Id)
            };

            ExecuteNonQuery(query, parameters);
        }

        public List<string> GetGenres()
        {
            var games = GetAll();

            List<string> genres = new List<string>();

            foreach (var game in games)
            {
                if (!genres.Contains(game.Genre))
                    genres.Add(game.Genre);
            }

            return genres;

        }
    }
}


