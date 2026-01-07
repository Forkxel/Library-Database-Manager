using LibraryDatabase.Data;

namespace LibraryDatabase.Forms.Loan;

public partial class LoanForm : Form
{
    private LoanRepository repository;
    
    public LoanForm()
    {
        InitializeComponent();
        repository = new LoanRepository();
    }

    private void buttonBorrow_Click(object sender, EventArgs e)
    {
        var form = new LoanBorrow();
        if (form.ShowDialog() == DialogResult.OK)
        {
            RefreshTable();
        }
    }

    private void buttonReturn_Click(object sender, EventArgs e)
    {
        var form = new LoanReturn();
        if (form.ShowDialog() == DialogResult.OK)
        {
            RefreshTable();
        }
    }
    
    private void RefreshTable()
    {
        var repo = new LoanRepository();
        dataGridView1.DataSource = repo.GetAll();
    }

    private void LoanForm_Load(object sender, EventArgs e)
    {
        LoadData();
    }
    
    private void LoadData()
    {
        try
        {
            dataGridView1.DataSource = repository.GetAll();
        }
        catch (Exception e)
        {
            MessageBox.Show("Error loading books " +  e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}