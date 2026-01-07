using LibraryDatabase.Data;

namespace LibraryDatabase.Forms.Loan;

public partial class LoanBorrow : Form
{
    private MemberRepository memberRepository;
    private BookRepository bookRepository;
    
    public LoanBorrow()
    {
        InitializeComponent();
        memberRepository = new MemberRepository();
        bookRepository = new BookRepository();
    }
    
    private void LoadData()
    {
        try
        {
            dataGridView1.DataSource = memberRepository.GetAll();
            dataGridView2.DataSource = bookRepository.GetAll();
        }
        catch (Exception e)
        {
            MessageBox.Show("Error loading books " +  e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void button_Click(object sender, EventArgs e)
    {
        if (!int.TryParse(textBoxBook.Text, out int bookId) || !int.TryParse(textBoxMember.Text, out int memberId))
        {
            MessageBox.Show("Invalid ID");
            return;
        }

        try
        {
            var repo = new LoanRepository();
            repo.BorrowBook(bookId, memberId);

            DialogResult = DialogResult.OK;
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error borrowing: " + ex.Message);
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void LoanBorrow_Load(object sender, EventArgs e)
    {
        LoadData();
    }
}