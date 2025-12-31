using System.Data.SqlClient;
using System.Data.SqlTypes;
using LibraryDatabase.Modules;

namespace LibraryDatabase.Data;

public class BookRepository : BaseRepository, IRepository<Book>
{
    public List<Book> GetAll()
    {
        var books = new List<Book>();
        
        using var connection = GetConnection();
        using var command = new SqlCommand("SELECT * FROM Book", connection);
        
        connection.Open();
        using var reader = command.ExecuteReader();

        while (reader.Read())
        {
            books.Add(new Book
            {
                BookId = reader.GetInt32(0),
                BookTitle = reader.GetString(1),
                CategoryId = reader.GetInt32(2),
                AuthorId = reader.GetInt32(3),
                isAvailable = reader.GetBoolean(4),
                Price = reader.GetFloat(5)
            });
        }
        
        return books;
    }

    public Book? GetById(int id)
    {
        using var connection = GetConnection();
        using var command = new SqlCommand("SELECT * FROM Book WHERE id = @id", connection);
        
        command.Parameters.AddWithValue("@id", id);
        connection.Open();
        
        using var reader = command.ExecuteReader();
        
        if (!reader.Read())
        {
            return null;
        }

        var book = new Book
        {
            BookId = reader.GetInt32(0),
            BookTitle = reader.GetString(1),
            CategoryId = reader.GetInt32(2),
            AuthorId = reader.GetInt32(3),
            isAvailable = reader.GetBoolean(4),
            Price = reader.GetFloat(5)
        };
        
        return book;
    }

    public void Add(Book entity)
    {
        using var connection = GetConnection();
        using var command = new SqlCommand(
            "INSERT INTO Book(title,categoryId,authorId,isAvailable,price) VALUES(@title,@categoryId,@authorId,@isAvailable,@price)", connection);
        
        command.Parameters.AddWithValue("@title", entity.BookTitle);
        command.Parameters.AddWithValue("@categoryId", entity.CategoryId);
        command.Parameters.AddWithValue("@authorId", entity.AuthorId);
        command.Parameters.AddWithValue("@isAvailable", entity.isAvailable);
        command.Parameters.AddWithValue("@price", entity.Price);
        connection.Open();
        
        command.ExecuteNonQuery();
    }

    public void Update(Book entity)
    {
        using var connection = GetConnection();
        using var command = new SqlCommand(
            "UPDATE Book SET title = @title,categoryId=@categoryId,authorId=@authorId,isAvailable=@isAvailable,price=@price WHERE id=@id", connection);
        
        command.Parameters.AddWithValue("@id", entity.BookId);
        command.Parameters.AddWithValue("@title", entity.BookTitle);
        command.Parameters.AddWithValue("@categoryId", entity.CategoryId);
        command.Parameters.AddWithValue("@authorId", entity.AuthorId);
        command.Parameters.AddWithValue("@isAvailable", entity.isAvailable);
        command.Parameters.AddWithValue("@price", entity.Price);
        
        connection.Open();
        command.ExecuteNonQuery();
    }

    public void Delete(int id)
    {
        using var connection = GetConnection();
        using var command = new SqlCommand("DELETE FROM Book WHERE id = @id", connection);
        
        command.Parameters.AddWithValue("@id", id);
        
        connection.Open();
        command.ExecuteNonQuery();
    }
}