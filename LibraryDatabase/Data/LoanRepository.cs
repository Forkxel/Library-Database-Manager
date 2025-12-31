using System.Data.SqlClient;
using LibraryDatabase.Modules;

namespace LibraryDatabase.Data;

public class LoanRepository : BaseRepository, IRepository<Loan>
{
    public List<Loan> GetAll()
    {
        var loans = new List<Loan>();
        
        using var connection = GetConnection();
        using var command = new SqlCommand("SELECT * FROM Loan", connection);
        
        connection.Open();
        using var reader = command.ExecuteReader();

        while (reader.Read())
        {
           loans.Add(new Loan
           {
               LoanId = reader.GetInt32(0),
               MemberId = reader.GetInt32(1),
               BookId = reader.GetInt32(2),
               LoanDate = reader.GetDateTime(3),
               ReturnDate = reader.GetDateTime(4)
           }); 
        }
        
        return loans;
    }

    public Loan? GetById(int id)
    {
        using var connection = GetConnection();
        using var command = new SqlCommand("SELECT * FROM Loan WHERE id = @id", connection);
        
        command.Parameters.AddWithValue("@id", id);
        connection.Open();
        
        using var reader = command.ExecuteReader();

        if (!reader.Read())
        {
            return null;
        }

        var loan = new Loan
        {
            LoanId = reader.GetInt32(0),
            MemberId = reader.GetInt32(1),
            BookId = reader.GetInt32(2),
            LoanDate = reader.GetDateTime(3),
            ReturnDate = reader.GetDateTime(4)
        };
        
        return loan;
    }

    public void Add(Loan entity)
    {
        using var connection = GetConnection();
        using var command = new SqlCommand("INSERT INTO Loan(memberId,bookId,loanDate,returnDate) VALUES (@memberId,@bookId,@loanDate,@returnDate)", connection);
        
        command.Parameters.AddWithValue("@memberId", entity.LoanId);
        command.Parameters.AddWithValue("@bookId", entity.BookId);
        command.Parameters.AddWithValue("@loanDate", entity.LoanDate);
        command.Parameters.AddWithValue("@returnDate", entity.ReturnDate);
        
        connection.Open();
        command.ExecuteNonQuery();
    }

    public void Update(Loan entity)
    {
        using var connection = GetConnection();
        using var command = new SqlCommand("UPDATE Loan SET memberId=@memberId,bookId=@bookId,loanDate=@loanDate,returnDate=@returnDate WHERE id=@id", connection);
        
        command.Parameters.AddWithValue("@memberId", entity.LoanId);
        command.Parameters.AddWithValue("@bookId", entity.BookId);
        command.Parameters.AddWithValue("@loanDate", entity.LoanDate);
        command.Parameters.AddWithValue("@returnDate", entity.ReturnDate);
        command.Parameters.AddWithValue("@id", entity.LoanId);
        
        connection.Open();
        command.ExecuteNonQuery();
    }

    public void Delete(int id)
    {
        using var connection = GetConnection();
        using var command = new SqlCommand("DELETE FROM Loan WHERE id = @id", connection);
        
        command.Parameters.AddWithValue("@id", id);
        
        connection.Open();
        command.ExecuteNonQuery();
    }
}