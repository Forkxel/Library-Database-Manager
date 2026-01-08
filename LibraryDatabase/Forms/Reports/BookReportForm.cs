using LibraryDatabase.Data;

namespace LibraryDatabase.Forms.Reports;

public partial class BookReportForm : Form
{
    private BookLoanRepository repository = new BookLoanRepository();
    
    public BookReportForm()
    {
        InitializeComponent();
        LoadData();
    }
    
    private void LoadData()
    {
        dataGridView1.DataSource = repository.GetBookLoanStats();
    }
}