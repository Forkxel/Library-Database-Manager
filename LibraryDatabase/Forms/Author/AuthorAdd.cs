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
        if (string.IsNullOrWhiteSpace(textBoxFirst.Text) ||
            string.IsNullOrWhiteSpace(textBoxLast.Text))
        {
            MessageBox.Show("First name and last name must be filled.",
                "Validation error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }

        try
        {
            var author = new Modules.Author
            {
                FirstName = textBoxFirst.Text.Trim(),
                LastName = textBoxLast.Text.Trim()
            };

            var repo = new AuthorRepository();
            repo.Add(author);

            DialogResult = DialogResult.OK;
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error adding author: " + ex.Message);
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
            var repo = new AuthorRepository();
            repo.ImportAuthorsFromCsv(filePath);

            MessageBox.Show("Authors imported successfully");
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