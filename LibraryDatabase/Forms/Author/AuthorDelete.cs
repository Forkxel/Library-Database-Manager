using LibraryDatabase.Data;

namespace LibraryDatabase.Forms.Author;

public partial class AuthorDelete : Form
{
    public AuthorDelete()
    {
        InitializeComponent();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void buttonOK_Click(object sender, EventArgs e)
    {
        if (!int.TryParse(textBoxID.Text, out int authorId))
        {
            MessageBox.Show("Invalid ID");
            return;
        }

        var repo = new AuthorRepository();
        repo.Delete(authorId);
        
        DialogResult = DialogResult.OK;
        Close();
    }
}