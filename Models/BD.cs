using System.Data.SqlClient;
using Dapper;
public class BD{
 private static string _connectionString=@"Server=.;DataBase=BDSeries;Trusted_Connection=True;";



    public static List<Series> ListarSeries(){
        using (SqlConnection BD = new SqlConnection(_connectionString)){
            string query = "SELECT * FROM Series";
            return BD.Query<Series>(query).ToList();
        }
    }

     public static List<Temporadas> ListarTemporadasPorSerie(int IdS){
        using (SqlConnection BD = new SqlConnection(_connectionString)){
            string query = "SELECT * FROM Temporadas WHERE IdSerie=@zIdSerie";
            return BD.Query<Temporadas>(query,new{zIdSerie=IdS}).ToList();
        }
    }
}