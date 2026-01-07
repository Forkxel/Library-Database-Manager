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