using System.Data.SqlClient;

namespace LibraryDatabase.Data;

public class DatabaseRepository : BaseRepository
{
    public void CreateTables() 
    {
        using var connection = GetConnection();
        connection.Open();
        
        try
        {
            using (SqlCommand command = new SqlCommand(
                "CREATE TABLE Author (" +
                "id INT IDENTITY(1,1) PRIMARY KEY, " +
                "firstName VARCHAR(50) NOT NULL, " +
                "lastName VARCHAR(50) NOT NULL);", connection))
            {
                command.ExecuteNonQuery();
            }
        }
        catch (Exception e) {}

        try
        {
            using (SqlCommand command = new SqlCommand(
                "CREATE TABLE Category (" +
                "id INT IDENTITY(1,1) PRIMARY KEY, " +
                "name VARCHAR(50) NOT NULL);", connection))
            {
                command.ExecuteNonQuery();
            }
        }
        catch (Exception e) {}

        try
        {
            using (SqlCommand command = new SqlCommand(
                "CREATE TABLE Members (" +
                "id INT IDENTITY(1,1) PRIMARY KEY, " +
                "firstName VARCHAR(50) NOT NULL, " +
                "lastName VARCHAR(50) NOT NULL, " +
                "email VARCHAR(100) NOT NULL);", connection))
            {
                command.ExecuteNonQuery();
            }
        }
        catch (Exception e) {}

        try
        {
            using (SqlCommand command = new SqlCommand(
                "CREATE TABLE Book (" +
                "id INT IDENTITY(1,1) PRIMARY KEY, " +
                "title VARCHAR(100) NOT NULL, " +
                "categoryId INT REFERENCES Category(id), " +
                "authorId INT REFERENCES Author(id), " +
                "isAvailable BIT NOT NULL, " +
                "price DECIMAL(10,2) NOT NULL, " +
                "state VARCHAR(10) NOT NULL CHECK (state IN ('New','Damaged','Used')));", connection))
            {
                command.ExecuteNonQuery();
            }
        }
        catch (Exception e) {}

        try
        {
            using (SqlCommand command = new SqlCommand(
                "CREATE TABLE Loan (" +
                "id INT IDENTITY(1,1) PRIMARY KEY, " +
                "memberId INT REFERENCES Members(id), " +
                "bookId INT REFERENCES Book(id), " +
                "loanDate DATETIME NOT NULL, " +
                "returnDate DATETIME NULL);", connection))
            {
                command.ExecuteNonQuery();
            }
        }
        catch (Exception e) {}
    }

    public void DropTables()
    {
        using var connection = GetConnection();
        connection.Open();
        
        try
        {
            using (SqlCommand command = new SqlCommand("DROP TABLE Loan;", connection))
            {
                command.ExecuteNonQuery();
            }
        }
        catch (Exception e) {}

        try
        {
            using (SqlCommand command = new SqlCommand("DROP TABLE Book;", connection))
            {
                command.ExecuteNonQuery();
            }
        }
        catch (Exception e) {}

        try
        {
            using (SqlCommand command = new SqlCommand("DROP TABLE Members;", connection))
            {
                command.ExecuteNonQuery();
            }
        }
        catch (Exception e) {}

        try
        {
            using (SqlCommand command = new SqlCommand("DROP TABLE Author;", connection))
            {
                command.ExecuteNonQuery();
            }
        }
        catch (Exception e) {}

        try
        {
            using (SqlCommand command = new SqlCommand("DROP TABLE Category;", connection))
            {
                command.ExecuteNonQuery();
            }
        }
        catch (Exception e) {}
    }
}