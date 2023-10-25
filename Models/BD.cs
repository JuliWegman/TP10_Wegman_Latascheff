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

    public static List<Actores> ListarActoresPorSerie(int IdS){
        using (SqlConnection BD = new SqlConnection(_connectionString)){
            string query = "SELECT * FROM Actores WHERE IdSerie=@zIdSerie";
            return BD.Query<Actores>(query,new{zIdSerie=IdS}).ToList();
        }
    }

    public static Series ObtenerSerie(int IdS){
        Series x=null;
        using (SqlConnection BD = new SqlConnection(_connectionString)){
            string query = "SELECT * FROM Series WHERE IdSerie=@zIdSerie";
            x= BD.QueryFirstOrDefault<Series>(query,new{zIdSerie=IdS});
        }
        return x;
    }
}