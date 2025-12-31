namespace LibraryDatabase.Modules;

public class AuthorLoanReport
{
    public string AuthorName { get; set; }
    public int LoanCount { get; set; }
    public DateTime FirstLoan { get; set; }
    public DateTime LastLoan { get; set; }
}