using LibraryDatabase.Category;
using LibraryDatabase.Forms.Author;
using LibraryDatabase.Forms.Book;
using LibraryDatabase.Forms.Member;

namespace LibraryDatabase.Forms;

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

    private void btnCategories_Click(object sender, EventArgs e)
    {
        CategoryForm categoryForm = new CategoryForm();
        categoryForm.ShowDialog();
    }

    private void btnMembers_Click(object sender, EventArgs e)
    {
        MemberForm memberForm = new MemberForm();
        memberForm.ShowDialog();
    }
}