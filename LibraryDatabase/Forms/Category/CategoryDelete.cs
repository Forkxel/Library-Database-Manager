using LibraryDatabase.Data;

namespace LibraryDatabase.Category;

public partial class CategoryDelete : Form
{
    public CategoryDelete()
    {
        InitializeComponent();
    }

    private void buttonOK_Click(object sender, EventArgs e)
    {
        if (!int.TryParse(textBoxID.Text, out int categoryId))
        {
            MessageBox.Show("Invalid ID");
            return;
        }

        var repo = new CategoryRepository();
        repo.Delete(categoryId);
        
        DialogResult = DialogResult.OK;
        Close();
    }

    private void buttonCancel_Click(object sender, EventArgs e)
    {
        Close();
    }
}