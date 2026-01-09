using System.Data.SqlClient;
using LibraryDatabase.Modules;

namespace LibraryDatabase.Data;

/// <summary>
/// Class for handling author table data from database
/// </summary>
public class AuthorRepository : BaseRepository, IRepository<Modules.Author>
{
    /// <summary>
    /// Get all authors from the table
    /// </summary>
    /// <returns>List of all the authors</returns>
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

    /// <summary>
    /// Add new author to the table
    /// </summary>
    /// <param name="entity">Author to add</param>
    public void Add(Modules.Author entity)
    {
        using var connection = GetConnection();
        using var command = new SqlCommand("INSERT INTO Author(firstName, lastName) VALUES(@firstName, @lastName)", connection);
        
        command.Parameters.AddWithValue("@firstName", entity.FirstName);
        command.Parameters.AddWithValue("@lastName", entity.LastName);
        
        connection.Open();
        command.ExecuteNonQuery();
    }

    /// <summary>
    /// Updates author based by number of filled boxes in form
    /// </summary>
    /// <param name="entity">Author to update</param>
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

    /// <summary>
    /// Deletes the author from the table
    /// </summary>
    /// <param name="id">ID of the author</param>
    public void Delete(int id)
    {
        using var connection = GetConnection();
        using var command = new SqlCommand("DELETE FROM Author WHERE id = @id", connection);
        
        command.Parameters.AddWithValue("@id", id);
        
        connection.Open();
        command.ExecuteNonQuery();
    }
    
    /// <summary>
    /// Imports the authors from the csv file that user picks in file explorer
    /// </summary>
    /// <param name="filePath">file path</param>
    public void ImportAuthorsFromCsv(string filePath)
    {
        using var connection = GetConnection();
        connection.Open();

        using var transaction = connection.BeginTransaction();

        try
        {
            var lines = File.ReadAllLines(filePath);

            for (int i = 1; i < lines.Length; i++)
            {
                var parts = lines[i].Split(',');

                if (parts.Length != 2)
                {
                    continue;
                }
                
                var cmd = new SqlCommand("INSERT INTO Author (firstName, lastName) VALUES (@firstName, @lastName)", connection, transaction);

                cmd.Parameters.AddWithValue("@firstName", parts[0].Trim());
                cmd.Parameters.AddWithValue("@lastName", parts[1].Trim());

                cmd.ExecuteNonQuery();
            }

            transaction.Commit();
        }
        catch
        {
            transaction.Rollback();
            throw;
        }
    }

}