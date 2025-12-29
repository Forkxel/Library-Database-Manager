using System.Data.SqlClient;
using LibraryDatabase.Modules;

namespace LibraryDatabase.Data;

public class AuthorRepository : BaseRepository, IRepository<Author>
{
    public List<Author> GetAll()
    {
        var authors = new List<Author>();
        
        using var connection = GetConnection(); 
        using var command = new SqlCommand("SELECT * FROM Author", connection);
        
        connection.Open();
        using var reader = command.ExecuteReader();

        while (reader.Read())
        {
            authors.Add(new Author
            {
                AuthorID = reader.GetInt32(0),
                FirstName = reader.GetString(1),
                LastName = reader.GetString(2)
            });
        }
        
        return authors;
    }

    public Author? GetById(int id)
    {
        using var connection = GetConnection();
        using var command = new SqlCommand("SELECT * FROM Author WHERE AuthorID = @id", connection);
        
        command.Parameters.AddWithValue("@id", id);
        
        connection.Open();
        using var reader = command.ExecuteReader();
        
        if (!reader.Read())
        {
            return null;
        }
        
        var author = new Author
        {
            AuthorID = reader.GetInt32(0),
            FirstName = reader.GetString(1),
            LastName = reader.GetString(2)
        };
        
        return author;
    }

    public void Add(Author entity)
    {
        using var connection = GetConnection();
        using var command = new SqlCommand("INSERT INTO Author(firstName, lastName) VALUES(@firstName, @lastName)", connection);
        
        command.Parameters.AddWithValue("@firstName", entity.FirstName);
        command.Parameters.AddWithValue("@lastName", entity.LastName);
        
        connection.Open();
        command.ExecuteNonQuery();
    }

    public void Update(Author entity)
    {
        using var connection = GetConnection();
        using var command = new SqlCommand("UPDATE Author SET firstName=@firstName,lastName=@lastName WHERE id=@id", connection);
        
        command.Parameters.AddWithValue("@firstName", entity.FirstName);
        command.Parameters.AddWithValue("@lastName", entity.LastName);
        command.Parameters.AddWithValue("@id", entity.AuthorID);
        
        connection.Open();
        command.ExecuteNonQuery();
    }

    public void Delete(int id)
    {
        using var connection = GetConnection();
        using var command = new SqlCommand("DELETE FROM Author WHERE AuthorID = @id", connection);
        
        command.Parameters.AddWithValue("@id", id);
        
        connection.Open();
        command.ExecuteNonQuery();
    }
}