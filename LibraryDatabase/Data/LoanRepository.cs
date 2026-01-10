using System.Data.SqlClient;
using LibraryDatabase.Modules;

namespace LibraryDatabase.Data;

/// <summary>
/// Class for handling loan table data from database
/// </summary>
public class LoanRepository : BaseRepository, IRepository<Loan>
{
    /// <summary>
    /// Get all loans from the table
    /// </summary>
    /// <returns>List of all the loans</returns>
    public List<Loan> GetAll()
    {
        var loans = new List<Loan>();
        
        using var connection = GetConnection();
        using var command = new SqlCommand("SELECT * FROM Loan", connection);
        
        using var reader = command.ExecuteReader();

        while (reader.Read())
        {
           loans.Add(new Loan
           {
               LoanId = reader.GetInt32(0),
               MemberId = reader.GetInt32(1),
               BookId = reader.GetInt32(2),
               LoanDate = reader.GetDateTime(3),
               ReturnDate = reader.IsDBNull(4) 
                   ? null 
                   : reader.GetDateTime(4)
           }); 
        }
        
        return loans;
    }

    /// <summary>
    /// Add new loan to the table
    /// </summary>
    /// <param name="entity">Loan to add</param>
    public void Add(Loan entity)
    {
        using var connection = GetConnection();
        using var command = new SqlCommand("INSERT INTO Loan(memberId,bookId,loanDate,returnDate) VALUES (@memberId,@bookId,@loanDate,@returnDate)", connection);
        
        command.Parameters.AddWithValue("@memberId", entity.MemberId);
        command.Parameters.AddWithValue("@bookId", entity.BookId);
        command.Parameters.AddWithValue("@loanDate", entity.LoanDate);
        command.Parameters.AddWithValue("@returnDate", entity.ReturnDate);
        
        command.ExecuteNonQuery();
    }

    /// <summary>
    /// Updates loan based by number of filled boxes in form
    /// </summary>
    /// <param name="entity">Loan to update</param>
    public void Update(Loan entity)
    {
        var updates = new List<string>();
        var command = new SqlCommand();

        if (entity.MemberId.HasValue)
        {
            updates.Add("memberId=@memberId");
            command.Parameters.AddWithValue("@memberId", entity.MemberId.Value);
        }

        if (entity.BookId.HasValue)
        {
            updates.Add("bookId=@bookId");
            command.Parameters.AddWithValue("@bookId", entity.BookId.Value);
        }

        if (entity.LoanDate.HasValue)
        {
            updates.Add("loanDate=@loanDate");
            command.Parameters.AddWithValue("@loanDate", entity.LoanDate.Value);
        }

        if (entity.ReturnDate.HasValue)
        {
            updates.Add("returnDate=@returnDate");
            command.Parameters.AddWithValue("@returnDate", entity.ReturnDate.Value);
        }

        if (updates.Count == 0)
        {
            return;
        }
        
        command.CommandText = $"UPDATE Loan SET {string.Join(", ", updates)} WHERE id = @id";
        
        command.Parameters.AddWithValue("@id", entity.LoanId);
        
        using var connection = GetConnection();
        command.Connection = connection;
        command.ExecuteNonQuery();
    }

    /// <summary>
    /// Deletes the loan from the table
    /// </summary>
    /// <param name="id">ID of the loan</param>
    public void Delete(int id)
    {
        using var connection = GetConnection();
        using var command = new SqlCommand("DELETE FROM Loan WHERE id = @id", connection);
        
        command.Parameters.AddWithValue("@id", id);
        
        command.ExecuteNonQuery();
    }
    
    public void BorrowBook(int bookId, int memberId)
    {
        using var connection = GetConnection();
        connection.Open();

        using var transaction = connection.BeginTransaction();

        try
        {
            var checkLoanCmd = new SqlCommand("SELECT COUNT(*) FROM Loan WHERE bookId = @bookId AND returnDate IS NULL",
                connection, transaction);

            checkLoanCmd.Parameters.AddWithValue("@bookId", bookId);

            int activeLoans = (int)checkLoanCmd.ExecuteScalar();

            if (activeLoans > 0)
            {
                throw new Exception("Book is already borrowed");
            }

            
            var insertLoan = new SqlCommand("INSERT INTO Loan (memberId, bookId, loanDate) VALUES (@memberId, @bookId, @loanDate)",connection, transaction);

            insertLoan.Parameters.AddWithValue("@memberId", memberId);
            insertLoan.Parameters.AddWithValue("@bookId", bookId);
            insertLoan.Parameters.AddWithValue("@loanDate", DateTime.Now);
            insertLoan.ExecuteNonQuery();

            var updateBook = new SqlCommand("UPDATE Book SET isAvailable = 0 WHERE id = @id", connection, transaction);

            updateBook.Parameters.AddWithValue("@id", bookId);
            updateBook.ExecuteNonQuery();

            transaction.Commit();
        }
        catch
        {
            transaction.Rollback();
            throw;
        }
    }
    
    public void ReturnBook(int loanId)
    {
        using var connection = GetConnection();

        using var transaction = connection.BeginTransaction();

        try
        {
            var getBookCmd = new SqlCommand("SELECT bookId FROM Loan WHERE id = @id AND returnDate IS NULL", connection, transaction);

            getBookCmd.Parameters.AddWithValue("@id", loanId);

            var bookIdObj = getBookCmd.ExecuteScalar();

            if (bookIdObj == null)
            {
                throw new Exception("Loan does not exist");
            }

            int bookId = (int)bookIdObj;
            
            var updateLoan = new SqlCommand("UPDATE Loan SET returnDate = @returnDate WHERE id = @id", connection, transaction);

            updateLoan.Parameters.AddWithValue("@id", loanId);
            updateLoan.Parameters.AddWithValue("@returnDate", DateTime.Now);
            updateLoan.ExecuteNonQuery();
            
            var updateBook = new SqlCommand("UPDATE Book SET isAvailable = 1 WHERE id = @bookId", connection, transaction);

            updateBook.Parameters.AddWithValue("@bookId", bookId);
            updateBook.ExecuteNonQuery();

            transaction.Commit();
        }
        catch
        {
            transaction.Rollback();
            throw;
        }
    }

}