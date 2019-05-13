using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Step1
{
    class Program
    {
        static void Main(string[] args)
        {
            //CTRL + . (컨트롤쩜)
            SqlConnection connection = new SqlConnection();

            connection.ConnectionString = "server=10.10.14.65;Database=RealChinook;User Id=sa;Password = jj1234;";

            connection.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "select * from Album where ArtistId < @ArtistId and Title like @Title + '%'";

            SqlParameter artitstIdParameter = new SqlParameter();
            artitstIdParameter.ParameterName = "@ArtistId";
            artitstIdParameter.Value = 50;
            artitstIdParameter.SqlDbType = SqlDbType.Int;
            command.Parameters.Add(artitstIdParameter);

            SqlParameter titleParameter = new SqlParameter();
            titleParameter.ParameterName = "@Title";
            titleParameter.Value = "b";
            titleParameter.SqlDbType = SqlDbType.NVarChar;
            titleParameter.Size = 50;
            command.Parameters.Add(titleParameter);

            // 동기 vs 비동기
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                //// 방법1
                //reader.GetInt32(0);
                //reader.GetString(1);
                //reader.GetInt32(2);

                //방법2 - 인덱서 사용
                int albumId = (int)reader["AlbumId"];
                string title = (string)reader["Title"];
                int artistId = (int)reader["ArtistId"];

                Console.WriteLine($"{albumId}\t{title}\t{artistId}");
            }

            connection.Close();

            //using()
        }
    }
}
