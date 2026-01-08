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
        try
        {
            dataGridView1.DataSource = repository.GetBookLoanStats();
        }
        catch (Exception e)
        {
            MessageBox.Show("Error loading book report " +  e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
    }
}