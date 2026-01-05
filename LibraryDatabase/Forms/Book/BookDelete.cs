using LibraryDatabase.Data;

namespace LibraryDatabase.Forms.Book;

public partial class BookDelete : Form
{
    public BookDelete()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (!int.TryParse(textBoxID.Text, out int bookId))
        {
            MessageBox.Show("Insert correct ID");
            return;
        }

        var repo = new BookRepository();
        repo.Delete(bookId);
        
        DialogResult = DialogResult.OK;
        Close();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        Close();
    }
}