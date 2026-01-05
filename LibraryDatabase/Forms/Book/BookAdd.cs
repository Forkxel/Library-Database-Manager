using LibraryDatabase.Data;

namespace LibraryDatabase.Forms.Book;

public partial class BookAdd : Form
{
    public BookAdd()
    {
        InitializeComponent();
        comboBoxState.DataSource = Enum.GetValues(typeof(State));
    }

    private void button1_Click(object sender, EventArgs e)
    {
        try
        {
            var book = new Modules.Book
            {
                BookTitle = textBoxTitle.Text,
                AuthorId = int.Parse(textBoxAuthorId.Text),
                CategoryId = int.Parse(textBoxCategory.Text),
                Price = decimal.Parse(textBoxPrice.Text),
                isAvailable = checkBoxAvailable.Checked,
                State = (State)comboBoxState.SelectedItem
            };
            
            var repo = new BookRepository();
            repo.Add(book);
            
            DialogResult = DialogResult.OK;
            Close();
        }
        catch (Exception exception)
        {
            MessageBox.Show("Error adding book: " + exception.Message);
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {
        Close();
    }
}