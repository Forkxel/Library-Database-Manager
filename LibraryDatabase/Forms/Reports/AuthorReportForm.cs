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
        dataGridView1.DataSource = repository.GetAuthorLoanStats();
    }
}