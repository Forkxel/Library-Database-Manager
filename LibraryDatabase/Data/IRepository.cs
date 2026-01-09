namespace LibraryDatabase.Data;

public interface IRepository<T>
{
    List<T> GetAll();
    void Add(T entity);
    void Update(T entity);
    void Delete(int id);
}