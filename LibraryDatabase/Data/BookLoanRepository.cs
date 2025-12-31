using System.Data.SqlClient;
using LibraryDatabase.Modules;

namespace LibraryDatabase.Data;

public class BookLoanRepository : BaseRepository
{
    public List<BookLoanReport> GetBookLoanStats()
    {
        var result = new List<BookLoanReport>();

        using var connection = GetConnection();
        using var command = new SqlCommand("SELECT BookTitle, LoanCount, FirstLoan, LastReturn FROM BookLoanStats", connection);

        connection.Open();
        using var reader = command.ExecuteReader();

        while (reader.Read())
        {
            result.Add(new BookLoanReport
            {
                BookTitle = reader.GetString(0),
                LoanCount = reader.GetInt32(1),
                FirstLoan = reader.GetDateTime(2),
                LastReturn = reader.GetDateTime(3)
            });
        }

        return result;
    }
}