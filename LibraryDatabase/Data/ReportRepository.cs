using System.Data.SqlClient;
using LibraryDatabase.Modules;

namespace LibraryDatabase.Data;

public class ReportRepository : BaseRepository
{
    public List<AuthorLoanReport> GetAuthorLoanStats()
    {
        var result = new List<AuthorLoanReport>();

        using var connection = GetConnection();
        using var command = new SqlCommand("SELECT AuthorName, LoanCount, FirstLoan, LastLoan FROM authorLoanStats", connection);

        connection.Open();
        using var reader = command.ExecuteReader();

        while (reader.Read())
        {
            result.Add(new AuthorLoanReport
            {
                AuthorName = reader.GetString(0),
                LoanCount = reader.GetInt32(1),
                FirstLoan = reader.GetDateTime(2),
                LastLoan = reader.GetDateTime(3)
            });
        }

        return result;
    }
}