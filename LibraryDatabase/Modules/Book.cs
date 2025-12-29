namespace LibraryDatabase.Modules;

public class Book
{
    private float price;
    
    public int BookId { get; set; }
    public string BookName { get; set; }
    public int CategoryId { get; set; }
    public int AuthorId { get; set; }
    public bool isAvailable { get; set; }

    public float Price
    {
        get { return price; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Price cannot be less than 0");
            }
            price = value;
        }
    }
}