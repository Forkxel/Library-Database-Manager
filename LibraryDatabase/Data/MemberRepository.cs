using System.Data.SqlClient;
using LibraryDatabase.Modules;

namespace LibraryDatabase.Data;

public class MemberRepository : BaseRepository, IRepository<Modules.Member>
{
    public List<Modules.Member> GetAll()
    {
        var members = new List<Modules.Member>();

        using var connection = GetConnection();
        using var command = new SqlCommand("SELECT * FROM Members", connection);
        
        connection.Open();
        using var reader = command.ExecuteReader();
        
        while (reader.Read())
        {
            members.Add(new Modules.Member
            {
                MemberID = reader.GetInt32(0),
                FirstName = reader.GetString(1),
                LastName = reader.GetString(2),
                Email = reader.GetString(3)
            });    
        }
        
        return members;
    }

    public Modules.Member? GetById(int id)
    {
        using var connection = GetConnection();
        using var command = new SqlCommand("SELECT * FROM Members WHERE MemberID = @id", connection);
        
        command.Parameters.AddWithValue("@id", id);
        connection.Open();
        
        using var reader = command.ExecuteReader();

        if (!reader.Read())
        {
            return null;
        }

        var member = new Modules.Member
        {
            MemberID = reader.GetInt32(0),
            FirstName = reader.GetString(1),
            LastName = reader.GetString(2),
            Email = reader.GetString(3)
        };
        
        return member;
    }

    public void Add(Modules.Member entity)
    {
        using var connection = GetConnection();
        using var command = new SqlCommand("INSERT INTO Members(firstName, lastName, email) VALUES(@firstName, @lastName, @email)", connection);
        
        command.Parameters.AddWithValue("@firstName", entity.FirstName);
        command.Parameters.AddWithValue("@lastName", entity.LastName);
        command.Parameters.AddWithValue("@email", entity.Email);
        
        connection.Open();
        command.ExecuteNonQuery();
    }

    public void Update(Modules.Member member)
    {
        var updates = new List<string>();
        var command = new SqlCommand();

        if (!string.IsNullOrWhiteSpace(member.FirstName))
        {
            updates.Add("firstName = @firstName");
            command.Parameters.AddWithValue("@firstName", member.FirstName);
        }

        if (!string.IsNullOrWhiteSpace(member.LastName))
        {
            updates.Add("lastName = @lastName");
            command.Parameters.AddWithValue("@lastName", member.LastName);
        }

        if (!string.IsNullOrWhiteSpace(member.Email))
        {
            updates.Add("email = @email");
            command.Parameters.AddWithValue("@email", member.Email);
        }

        if (updates.Count == 0)
        {
            return;
        }

        command.CommandText = $"UPDATE Members SET {string.Join(", ", updates)} WHERE id = @id";

        command.Parameters.AddWithValue("@id", member.MemberID);

        using var connection = GetConnection();
        command.Connection = connection;
        connection.Open();
        command.ExecuteNonQuery();
    }

    public void Delete(int id)
    {
        using var connection = GetConnection();
        using var command = new SqlCommand("DELETE FROM Members WHERE MemberID = @id", connection);
        
        command.Parameters.AddWithValue("@id", id);
        
        connection.Open();
        command.ExecuteNonQuery();
    }
}