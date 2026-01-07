using LibraryDatabase.Data;

namespace LibraryDatabase.Forms.Loan;

public partial class LoanReturn : Form
{
    public LoanReturn()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (!int.TryParse(textBoxID.Text, out int loanId))
        {
            MessageBox.Show("Invalid ID");
            return;
        }

        try
        {
            var repo = new LoanRepository();
            repo.ReturnBook(loanId);

            DialogResult = DialogResult.OK;
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error in returning: " + ex.Message);
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {
        Close();
    }
}