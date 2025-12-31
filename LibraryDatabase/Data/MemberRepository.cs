using System.Data.SqlClient;
using LibraryDatabase.Modules;

namespace LibraryDatabase.Data;

public class MemberRepository : BaseRepository, IRepository<Member>
{
    public List<Member> GetAll()
    {
        var members = new List<Member>();

        using var connection = GetConnection();
        using var command = new SqlCommand("SELECT * FROM Member", connection);
        
        connection.Open();
        using var reader = command.ExecuteReader();
        
        while (reader.Read())
        {
            members.Add(new Member
            {
                MemberID = reader.GetInt32(0),
                FirstName = reader.GetString(1),
                LastName = reader.GetString(2),
                Email = reader.GetString(3)
            });    
        }
        
        return members;
    }

    public Member? GetById(int id)
    {
        using var connection = GetConnection();
        using var command = new SqlCommand("SELECT * FROM Member WHERE MemberID = @id", connection);
        
        command.Parameters.AddWithValue("@id", id);
        connection.Open();
        
        using var reader = command.ExecuteReader();

        if (!reader.Read())
        {
            return null;
        }

        var member = new Member
        {
            MemberID = reader.GetInt32(0),
            FirstName = reader.GetString(1),
            LastName = reader.GetString(2),
            Email = reader.GetString(3)
        };
        
        return member;
    }

    public void Add(Member entity)
    {
        using var connection = GetConnection();
        using var command = new SqlCommand("INSERT INTO Member(firstName, lastName, email) VALUES(@firstName, @lastName, @email)", connection);
        
        command.Parameters.AddWithValue("@firstName", entity.FirstName);
        command.Parameters.AddWithValue("@lastName", entity.LastName);
        command.Parameters.AddWithValue("@email", entity.Email);
        
        connection.Open();
        command.ExecuteNonQuery();
    }

    public void Update(Member member)
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

        command.CommandText = $"UPDATE Member SET {string.Join(", ", updates)} WHERE id = @id";

        command.Parameters.AddWithValue("@id", member.MemberID);

        using var connection = GetConnection();
        command.Connection = connection;
        connection.Open();
        command.ExecuteNonQuery();
    }

    public void Delete(int id)
    {
        using var connection = GetConnection();
        using var command = new SqlCommand("DELETE FROM Member WHERE MemberID = @id", connection);
        
        command.Parameters.AddWithValue("@id", id);
        
        connection.Open();
        command.ExecuteNonQuery();
    }
}