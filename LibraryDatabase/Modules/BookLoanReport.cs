namespace LibraryDatabase.Modules;

public class BookLoanReport
{
    public string BookTitle { get; set; }
    public int LoanCount { get; set; }
    public DateTime FirstLoan { get; set; }
    public DateTime LastReturn { get; set; }
}