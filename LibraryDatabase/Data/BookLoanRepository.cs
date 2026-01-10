using System.Data.SqlClient;
using LibraryDatabase.Modules;

namespace LibraryDatabase.Data;

/// <summary>
/// Class for Book statistics report
/// </summary>
public class BookLoanRepository : BaseRepository
{
    /// <summary>
    /// Gets the statistics from database using view
    /// </summary>
    /// <returns>List of books and their statistics</returns>
    public List<BookLoanReport> GetBookLoanStats()
    {
        var result = new List<BookLoanReport>();

        using var connection = GetConnection();
        using var command = new SqlCommand("SELECT BookTitle, Category, LoanCount, FirstLoan, LastReturn FROM bookLoanStats", connection);
        
        using var reader = command.ExecuteReader();

        while (reader.Read())
        {
            DateTime? firstLoan;

            if (reader.IsDBNull(3))
            {
                firstLoan = null;
            }
            else
            {
                firstLoan = reader.GetDateTime(3);
            }
            
            DateTime? lastReturn;

            if (reader.IsDBNull(4))
            {
                lastReturn = null;
            }
            else
            {
                lastReturn = reader.GetDateTime(4);
            }

            result.Add(new BookLoanReport
            {
                BookTitle = reader.GetString(0),
                Category = reader.GetString(1),
                LoanCount = reader.GetInt32(2),
                FirstLoan = firstLoan,
                LastReturn = lastReturn
            });
        }

        return result;
    }
}