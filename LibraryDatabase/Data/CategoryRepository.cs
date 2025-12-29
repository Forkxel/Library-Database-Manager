using System.Data.SqlClient;
using LibraryDatabase.Modules;

namespace LibraryDatabase.Data;

public class CategoryRepository : BaseRepository, IRepository<Category>
{
    public List<Category> GetAll()
    {
        var categories = new List<Category>();
        
        using var connection = GetConnection();
        using var command = new SqlCommand("SELECT * FROM CATEGORY", connection);
        
        connection.Open();
        using var reader = command.ExecuteReader();

        while (reader.Read())
        {
            categories.Add(new Category
            {
                CategoryId = reader.GetInt32(0),
                CategoryName = reader.GetString(1)
            });
        }
        
        return categories;
    }

    public Category? GetById(int id)
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

        var category = new Category
        {
            CategoryId = reader.GetInt32(0),
            CategoryName = reader.GetString(1)
        };
        
        return category;
    }

    public void Add(Category entity)
    {
        using var connection = GetConnection();
        using var command = new SqlCommand("INSERT INTO Category(Name) VALUES (@Name)", connection);
        
        command.Parameters.AddWithValue("@Name", entity.CategoryName);
        
        connection.Open();
        command.ExecuteNonQuery();
    }

    public void Update(Category entity)
    {
        using var connection = GetConnection();
        using var command = new SqlCommand("UPDATE Category SET Name=@Name WHERE id=@id", connection);
        
        command.Parameters.AddWithValue("@Name", entity.CategoryName);
        command.Parameters.AddWithValue("@id", entity.CategoryId);
        
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
}