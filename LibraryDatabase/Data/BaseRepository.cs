using System.Configuration;
using System.Data.SqlClient;

namespace LibraryDatabase.Data;

public abstract class BaseRepository
{
    protected SqlConnection GetConnection()
    {
        try
        {
            var connectionString = ConfigurationManager.ConnectionStrings["LibraryDb"].ConnectionString;
            
            var connection = new SqlConnection(connectionString);
            
            return connection;
        }
        catch (Exception e)
        {
            Console.WriteLine("Error connecting to database" + e.Message);
        }
        return null;
    }
}