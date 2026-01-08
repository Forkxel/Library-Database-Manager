using System.Configuration;
using System.Data.SqlClient;

namespace LibraryDatabase.Data;

public abstract class BaseRepository
{
    protected string connectionString;

    protected BaseRepository()
    {
        connectionString = ConfigLoader.Load().ConnectionString;
    }
    
    protected SqlConnection GetConnection()
    {
        return new SqlConnection(connectionString);
    }
}