using LibraryDatabase.Data;

namespace LibraryDatabase.Forms.Book;

public partial class BookUpdate : Form
{
    public BookUpdate()
    {
        InitializeComponent();
        comboBoxState.DataSource = Enum.GetValues(typeof(State));
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (!int.TryParse(textBoxID.Text, out int bookId))
        {
            MessageBox.Show("Invalid ID.");
            return;
        }

        var book = new Modules.Book { BookId = bookId };

        if (!string.IsNullOrWhiteSpace(textBoxTitle.Text))
        {
            book.BookTitle = textBoxTitle.Text;
        }

        if (int.TryParse(textBoxAuthor.Text, out int authorId))
        {
            book.AuthorId = authorId;
        }

        if (int.TryParse(textBoxCategory.Text, out int categoryId))
        {
            book.CategoryId = categoryId;
        }

        if (decimal.TryParse(textBoxPrice.Text, out decimal price))
        {
            book.Price = price;
        }

        book.isAvailable = checkBoxAvailable.CheckState == CheckState.Checked ? true : (bool?)null;

        if (comboBoxState.SelectedItem != null)
        {
            book.State = (State)comboBoxState.SelectedItem;
        }

        var repo = new BookRepository();
        repo.Update(book);

        DialogResult = DialogResult.OK;
        Close();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        Close();
    }
}