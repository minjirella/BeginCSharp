using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Step 2 저장프로시저를 활용하기
namespace Database.Step2
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
            command.CommandText = "Album_Search"; // 이건 예시
            command.CommandType = CommandType.StoredProcedure;

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

            int count = 0;
            int sum = 0;

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

                count++;
                sum += albumId;
            }

            connection.Close();
            Console.WriteLine(sum / count);
        }
    }
}
