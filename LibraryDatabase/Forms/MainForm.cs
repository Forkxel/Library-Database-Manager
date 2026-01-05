namespace LibraryDatabase;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void btnBooks_Click(object sender, EventArgs e)
    {
        BookForm booksForm = new BookForm();
        booksForm.ShowDialog();
    }
}