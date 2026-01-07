using LibraryDatabase.Forms.Author;
using LibraryDatabase.Forms.Book;

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

    private void btnAuthors_Click(object sender, EventArgs e)
    {
        AuthorForm authorForm = new AuthorForm();
        authorForm.ShowDialog();
    }
}