using System.Data.SqlClient;
using LibraryDatabase.Modules;

namespace LibraryDatabase.Data;

public class CategoryRepository : BaseRepository, IRepository<Modules.Category>
{
    public List<Modules.Category> GetAll()
    {
        var categories = new List<Modules.Category>();
        
        using var connection = GetConnection();
        using var command = new SqlCommand("SELECT * FROM CATEGORY", connection);
        
        connection.Open();
        using var reader = command.ExecuteReader();

        while (reader.Read())
        {
            categories.Add(new Modules.Category
            {
                CategoryId = reader.GetInt32(0),
                CategoryName = reader.GetString(1)
            });
        }
        
        return categories;
    }

    public Modules.Category? GetById(int id)
    {
        using var connection = GetConnection();
        using var command = new SqlCommand("SELECT * FROM CATEGORY WHERE id=@id", connection);
        
        command.Parameters.AddWithValue("@id", id);
        
        connection.Open();
        using var reader = command.ExecuteReader();

        if (!reader.Read())
        {
            return null;
        }

        var category = new Modules.Category
        {
            CategoryId = reader.GetInt32(0),
            CategoryName = reader.GetString(1)
        };
        
        return category;
    }

    public void Add(Modules.Category entity)
    {
        using var connection = GetConnection();
        using var command = new SqlCommand("INSERT INTO Category(name) VALUES (@Name)", connection);
        
        command.Parameters.AddWithValue("@Name", entity.CategoryName);
        
        connection.Open();
        command.ExecuteNonQuery();
    }

    public void Update(Modules.Category entity)
    {
        var updates = new List<string>();
        var command = new SqlCommand();

        if (!string.IsNullOrEmpty(entity.CategoryName))
        {
            updates.Add("name=@name");
            command.Parameters.AddWithValue("@name", entity.CategoryName);
        }

        if (updates.Count == 0)
        {
            return;
        }
        
        command.CommandText = $"UPDATE Category SET {string.Join(", ", updates)} WHERE id = @id";
        
        command.Parameters.AddWithValue("@id", entity.CategoryId);
        
        using var connection = GetConnection();
        command.Connection = connection;
        connection.Open();
        command.ExecuteNonQuery();
    }

    public void Delete(int id)
    {
        using var connection = GetConnection();
        using var command = new SqlCommand("DELETE FROM Category WHERE id=@id", connection);
        
        command.Parameters.AddWithValue("@id", id);
        
        connection.Open();
        command.ExecuteNonQuery();
    }
    
    public void ImportCategoriesFromCsv(string filePath)
    {
        using var connection = GetConnection();
        connection.Open();

        using var transaction = connection.BeginTransaction();

        try
        {
            var lines = File.ReadAllLines(filePath);

            for (int i = 1; i < lines.Length; i++)
            {
                var name = lines[i].Trim();

                if (string.IsNullOrWhiteSpace(name))
                {
                    continue;
                }
                
                var cmd = new SqlCommand("INSERT INTO Category (name) VALUES (@name)", connection, transaction);

                cmd.Parameters.AddWithValue("@name", name);
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