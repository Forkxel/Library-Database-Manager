using LibraryDatabase.Data;

namespace LibraryDatabase.Forms.Reports;

public partial class AuthorReportForm : Form
{
    private ReportRepository repository;
    
    public AuthorReportForm()
    {
        InitializeComponent();
        repository = new ReportRepository();
        LoadData();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        LoadData();
    }

    private void LoadData()
    {
        try
        {
            dataGridView1.DataSource = repository.GetAuthorLoanStats();
        }
        catch (Exception e)
        {
            MessageBox.Show("Error loading book report " +  e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}