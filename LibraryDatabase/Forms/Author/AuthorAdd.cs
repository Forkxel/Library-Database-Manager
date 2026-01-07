using LibraryDatabase.Data;

namespace LibraryDatabase.Forms.Author;

public partial class AuthorAdd : Form
{
    public AuthorAdd()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        try
        {
            var author = new Modules.Author
            {
                FirstName = textBoxFirst.Text,
                LastName = textBoxLast.Text
            };
            
            var repo = new AuthorRepository();
            repo.Add(author);
            
            DialogResult = DialogResult.OK;
            Close();
        }
        catch (Exception exception)
        {
            MessageBox.Show("Error adding author: " + exception.Message);
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {
        Close();
    }
}