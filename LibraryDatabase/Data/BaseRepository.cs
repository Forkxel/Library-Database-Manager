using System.Configuration;
using System.Data.SqlClient;

namespace LibraryDatabase.Data;

/// <summary>
/// Class for connection to the database for all the repositories
/// </summary>
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