using LibraryDatabase.Data;

namespace LibraryDatabase.Forms.Author;

public partial class AuthorUpdate : Form
{
    public AuthorUpdate()
    {
        InitializeComponent();
    }

    private void buttonOK_Click(object sender, EventArgs e)
    {
        if (!int.TryParse(textBoxId.Text, out int authorId))
        {
            MessageBox.Show("Invalid ID.");
            return;
        }
        
        var author = new Modules.Author { AuthorID = authorId };

        if (!string.IsNullOrWhiteSpace(textBoxFirst.Text))
        {
            author.FirstName = textBoxFirst.Text;
        }

        if (!string.IsNullOrWhiteSpace(textBoxLast.Text))
        {
            author.LastName = textBoxLast.Text;
        }

        var repo = new AuthorRepository();
        repo.Update(author);

        DialogResult = DialogResult.OK;
        Close();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        Close();
    }
}