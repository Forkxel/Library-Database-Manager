using LibraryDatabase.Data;

namespace LibraryDatabase.Category;

public partial class CategoryAdd : Form
{
    public CategoryAdd()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        try
        {
            var category = new Modules.Category
            {
                CategoryName = textBoxName.Text
            };
            
            var repo = new CategoryRepository();
            repo.Add(category);
            
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