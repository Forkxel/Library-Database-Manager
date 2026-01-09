namespace LibraryDatabase.Data;

/// <summary>
/// Base interface with all the methods for repositories
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IRepository<T>
{
    List<T> GetAll();
    void Add(T entity);
    void Update(T entity);
    void Delete(int id);
}