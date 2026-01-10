using LibraryDatabase.Data;

namespace LibraryDatabase.Forms.Author;

public partial class AuthorForm : Form
{
    private AuthorRepository repository;
    
    public AuthorForm()
    {
        InitializeComponent();
        repository = new AuthorRepository();
    }
    
    private void AuthorForm_Load(object sender, EventArgs e)
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
            MessageBox.Show("Error loading authors: " +  e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonAdd_Click(object sender, EventArgs e)
    {
        var addForm =  new AuthorAdd();
        if (addForm.ShowDialog() == DialogResult.OK)
        {
            RefreshTable();
        }
    }
    
    private void buttonUpdate_Click(object sender, EventArgs e)
    {
        var updateForm = new AuthorUpdate();
        if (updateForm.ShowDialog() == DialogResult.OK)
        {
            RefreshTable();
        }
    }
    
    private void buttonDelete_Click(object sender, EventArgs e)
    {
        var  deleteForm = new AuthorDelete();
        if (deleteForm.ShowDialog() == DialogResult.OK)
        {
            RefreshTable();
        }
    }
    
    private void RefreshTable()
    {
        var repo = new AuthorRepository();
        dataGridView1.DataSource = repo.GetAll();
    }
}