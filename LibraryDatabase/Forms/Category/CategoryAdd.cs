using LibraryDatabase.Data;

namespace LibraryDatabase.Forms.Category;

public partial class CategoryAdd : Form
{
    public CategoryAdd()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(textBoxName.Text))
        {
            MessageBox.Show("Category name must not be empty.",
                "Validation error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }

        try
        {
            var category = new Modules.Category
            {
                CategoryName = textBoxName.Text.Trim()
            };

            var repo = new CategoryRepository();
            repo.Add(category);

            DialogResult = DialogResult.OK;
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error adding category: " + ex.Message);
        }
    }


    private void button2_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void buttonImport_Click(object sender, EventArgs e)
    {
        var filePath = OpenCsvDialog();

        if (filePath == null)
            return;

        try
        {
            var repo = new CategoryRepository();
            repo.ImportCategoriesFromCsv(filePath);

            MessageBox.Show("Categories imported successfully");
            DialogResult = DialogResult.OK;
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Import failed: " + ex.Message);
        }
    }
    
    private string? OpenCsvDialog()
    {
        using (OpenFileDialog dialog = new OpenFileDialog())
        {
            dialog.Filter = "CSV files (*.csv)|*.csv";
            dialog.Title = "Select CSV file";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                return dialog.FileName;
            }

            return null;
        }
    }
}