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
        if (string.IsNullOrWhiteSpace(textBoxTitle.Text) ||
            string.IsNullOrWhiteSpace(textBoxAuthorId.Text) ||
            string.IsNullOrWhiteSpace(textBoxCategory.Text) ||
            string.IsNullOrWhiteSpace(textBoxPrice.Text) ||
            comboBoxState.SelectedItem == null)
        {
            MessageBox.Show("All fields must be filled.",
                "Validation error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }
        
        if (!int.TryParse(textBoxAuthorId.Text, out int authorId))
        {
            MessageBox.Show("Author ID must be a number.");
            return;
        }

        if (!int.TryParse(textBoxCategory.Text, out int categoryId))
        {
            MessageBox.Show("Category ID must be a number.");
            return;
        }

        if (!decimal.TryParse(textBoxPrice.Text, out decimal price))
        {
            MessageBox.Show("Price must be a valid decimal number.");
            return;
        }

        try
        {
            var book = new Modules.Book
            {
                BookTitle = textBoxTitle.Text.Trim(),
                AuthorId = authorId,
                CategoryId = categoryId,
                Price = price,
                isAvailable = checkBoxAvailable.Checked,
                State = (State)comboBoxState.SelectedItem
            };

            var repo = new BookRepository();
            repo.Add(book);

            DialogResult = DialogResult.OK;
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error adding book: " + ex.Message);
        }
    }


    private void button2_Click(object sender, EventArgs e)
    {
        Close();
    }
}