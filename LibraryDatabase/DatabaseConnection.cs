using System.Configuration;
using System.Data.SqlClient;

namespace LibraryDatabase;

public class DatabaseConnection
{
    public static SqlConnection GetConnection()
    {
        try
        {
            var connectionString = ConfigurationManager.ConnectionStrings["LibraryDb"].ConnectionString;
            
            var connection = new SqlConnection(connectionString);
            
            connection.Open();
            return connection;
        }
        catch (Exception e)
        {
            Console.WriteLine("Error connecting to database" + e.Message);
        }
        return null;
    }
}