using LibraryDatabase.Data;

namespace LibraryDatabase.Forms.Book;

public partial class BookForm : Form
{
    private BookRepository repository;
    
    public BookForm()
    {
        InitializeComponent();
        repository = new BookRepository();
    }

    private void BookForm_Load(object sender, EventArgs e)
    {
        LoadData();
    }
    
    private void LoadData()
    {
        try
        {
            dataGridView1.DataSource = repository.GetAll();
        }
        catch (Exception e)
        {
            MessageBox.Show("Error loading books " +  e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void UpdateButton_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }
}