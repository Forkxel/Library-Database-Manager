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
                Price = reader.GetDecimal(5),
                State = Enum.Parse<State>(reader.GetString(6))
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
            Price = reader.GetDecimal(5),
            State = Enum.Parse<State>(reader.GetString(6))
        };
        
        return book;
    }

    public void Add(Book entity)
    {
        using var connection = GetConnection();
        using var command = new SqlCommand(
            "INSERT INTO Book(title,categoryId,authorId,isAvailable,price,state) VALUES(@title,@categoryId,@authorId,@isAvailable,@price,@state)", connection);
        
        command.Parameters.AddWithValue("@title", entity.BookTitle);
        command.Parameters.AddWithValue("@categoryId", entity.CategoryId);
        command.Parameters.AddWithValue("@authorId", entity.AuthorId);
        command.Parameters.AddWithValue("@isAvailable", entity.isAvailable);
        command.Parameters.AddWithValue("@price", entity.Price);
        command.Parameters.AddWithValue("@state", entity.State!.Value.ToString());
        connection.Open();
        
        command.ExecuteNonQuery();
    }

    public void Update(Book book)
    {
        var updates = new List<string>();
        var command = new SqlCommand();

        if (!string.IsNullOrWhiteSpace(book.BookTitle))
        {
            updates.Add("title = @title");
            command.Parameters.AddWithValue("@title", book.BookTitle);
        }

        if (book.AuthorId.HasValue)
        {
            updates.Add("authorID = @authorID");
            command.Parameters.AddWithValue("@authorID", book.AuthorId.Value);
        }

        if (book.CategoryId.HasValue)
        {
            updates.Add("categoryID = @categoryID");
            command.Parameters.AddWithValue("@categoryID", book.CategoryId.Value);
        }

        if (book.Price.HasValue)
        {
            updates.Add("price = @price");
            command.Parameters.AddWithValue("@price", book.Price.Value);
        }

        if (book.isAvailable.HasValue)
        {
            updates.Add("isAvailable = @isAvailable");
            command.Parameters.AddWithValue("@isAvailable", book.isAvailable.Value);
        }
        
        if (book.State.HasValue)
        {
            updates.Add("state = @state");
            command.Parameters.AddWithValue("@state", book.State.Value.ToString());
        }

        if (updates.Count == 0)
        {
            return;
        }

        command.CommandText = $"UPDATE Book SET {string.Join(", ", updates)} WHERE id = @id";

        command.Parameters.AddWithValue("@id", book.BookId);

        using var conn = GetConnection();
        command.Connection = conn;
        conn.Open();
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