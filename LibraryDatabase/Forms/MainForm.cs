using LibraryDatabase.Category;
using LibraryDatabase.Data;
using LibraryDatabase.Forms.Author;
using LibraryDatabase.Forms.Book;
using LibraryDatabase.Forms.Category;
using LibraryDatabase.Forms.Loan;
using LibraryDatabase.Forms.Member;
using LibraryDatabase.Forms.Reports;

namespace LibraryDatabase.Forms;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void button6_Click(object sender, EventArgs e)
    {
        BookForm booksForm = new BookForm();
        booksForm.ShowDialog();
    }

    private void button5_Click(object sender, EventArgs e)
    {
        AuthorForm authorForm = new AuthorForm();
        authorForm.ShowDialog();
    }

    private void button4_Click(object sender, EventArgs e)
    {
        CategoryForm categoryForm = new CategoryForm();
        categoryForm.ShowDialog();
    }

    private void button3_Click(object sender, EventArgs e)
    {
        MemberForm memberForm = new MemberForm();
        memberForm.ShowDialog();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        LoanForm  loanForm = new LoanForm();
        loanForm.ShowDialog();
    }

    private void button8_Click(object sender, EventArgs e)
    {
        AuthorReportForm reportForm = new AuthorReportForm();
        reportForm.ShowDialog();
    }

    private void button7_Click(object sender, EventArgs e)
    {
        BookReportForm reportForm = new BookReportForm();
        reportForm.ShowDialog();
    }

    private void buttonReset_Click(object sender, EventArgs e)
    {
        var result = MessageBox.Show(
            "This will DELETE ALL DATA and recreate tables.\nAre you sure?",
            "Database reset",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

        if (result != DialogResult.Yes)
            return;

        try
        {
            var repo = new DatabaseRepository();
            repo.DropTables();
            repo.CreateTables();
            
            MessageBox.Show("Database successfully reset.");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Reset failed: " + ex.Message);
        }
    }
}