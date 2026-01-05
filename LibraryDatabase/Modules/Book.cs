using LibraryDatabase.Data;

namespace LibraryDatabase.Modules;

public class Book
{
    private float? price;
    
    public int BookId { get; set; }
    public string? BookTitle { get; set; }
    public int? CategoryId { get; set; }
    public int? AuthorId { get; set; }
    public bool? isAvailable { get; set; }
    public State? State { get; set; }

    public decimal? Price
    {
        get { return (decimal?)price; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Price cannot be less than 0");
            }
            price = (float?)value;
        }
    }
}