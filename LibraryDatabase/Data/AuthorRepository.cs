using System.Data.SqlClient;
using LibraryDatabase.Modules;

namespace LibraryDatabase.Data;

public class AuthorRepository : BaseRepository, IRepository<Modules.Author>
{
    public List<Modules.Author> GetAll()
    {
        var authors = new List<Modules.Author>();
        
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

    public Modules.Author? GetById(int id)
    {
        using var connection = GetConnection();
        using var command = new SqlCommand("SELECT * FROM Author WHERE id = @id", connection);
        
        command.Parameters.AddWithValue("@id", id);
        
        connection.Open();
        using var reader = command.ExecuteReader();
        
        if (!reader.Read())
        {
            return null;
        }
        
        var author = new Modules.Author
        {
            AuthorID = reader.GetInt32(0),
            FirstName = reader.GetString(1),
            LastName = reader.GetString(2)
        };
        
        return author;
    }

    public void Add(Modules.Author entity)
    {
        using var connection = GetConnection();
        using var command = new SqlCommand("INSERT INTO Author(firstName, lastName) VALUES(@firstName, @lastName)", connection);
        
        command.Parameters.AddWithValue("@firstName", entity.FirstName);
        command.Parameters.AddWithValue("@lastName", entity.LastName);
        
        connection.Open();
        command.ExecuteNonQuery();
    }

    public void Update(Modules.Author entity)
    {
        var updates = new List<string>();
        var command = new SqlCommand();

        if (!string.IsNullOrWhiteSpace(entity.FirstName))
        {
            updates.Add("firstName = @firstName");
            command.Parameters.AddWithValue("@firstName", entity.FirstName);
        }

        if (!string.IsNullOrWhiteSpace(entity.LastName))
        {
            updates.Add("lastName = @lastName");
            command.Parameters.AddWithValue("@lastName", entity.LastName);
        }

        if (updates.Count == 0)
        {
            return;
        }
        
        command.CommandText = $"UPDATE Author SET {string.Join(", ", updates)} WHERE id = @id";
        
        command.Parameters.AddWithValue("@id", entity.AuthorID);
        
        using var connection = GetConnection();
        command.Connection = connection;
        connection.Open();
        command.ExecuteNonQuery();
    }

    public void Delete(int id)
    {
        using var connection = GetConnection();
        using var command = new SqlCommand("DELETE FROM Author WHERE id = @id", connection);
        
        command.Parameters.AddWithValue("@id", id);
        
        connection.Open();
        command.ExecuteNonQuery();
    }
}