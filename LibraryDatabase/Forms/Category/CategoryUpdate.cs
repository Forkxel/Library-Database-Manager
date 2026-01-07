using LibraryDatabase.Data;

namespace LibraryDatabase.Category;

public partial class CategoryUpdate : Form
{
    public CategoryUpdate()
    {
        InitializeComponent();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (!int.TryParse(textBoxID.Text, out int categoryId))
        {
            MessageBox.Show("Invalid ID.");
            return;
        }
        
        var category = new Modules.Category { CategoryId = categoryId };

        if (!string.IsNullOrWhiteSpace(textBoxCategory.Text))
        {
            category.CategoryName = textBoxCategory.Text;
        }
        
        var repo = new CategoryRepository();
        repo.Update(category);

        DialogResult = DialogResult.OK;
        Close();
    }
}