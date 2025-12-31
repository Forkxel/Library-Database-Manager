namespace LibraryDatabase.Modules;

public class Category
{
    public int CategoryId { get; set; }
    public string? CategoryName { get; set; }

    public override string ToString()
    {
        return CategoryName;
    }
}