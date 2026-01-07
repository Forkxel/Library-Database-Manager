using LibraryDatabase.Data;

namespace LibraryDatabase.Category;

public partial class CategoryForm : Form
{
    private CategoryRepository categoryRepo;
    
    public CategoryForm()
    {
        InitializeComponent();
        categoryRepo = new CategoryRepository();
    }

    private void buttonAdd_Click(object sender, EventArgs e)
    {
        var addForm = new CategoryAdd();
        if (addForm.ShowDialog() == DialogResult.OK)
        {
            RefreshTable();
        }
    }

    private void buttonUpdate_Click(object sender, EventArgs e)
    {
        var  updateForm = new CategoryUpdate();
        if (updateForm.ShowDialog() == DialogResult.OK)
        {
            RefreshTable();
        }
    }

    private void buttonDelete_Click(object sender, EventArgs e)
    {
        var deleteForm = new CategoryDelete();
        if (deleteForm.ShowDialog() == DialogResult.OK)
        {
            RefreshTable();
        }
    }
    
    private void RefreshTable()
    {
        var repo = new CategoryRepository();
        dataGridView1.DataSource = repo.GetAll();
    }
    
    private void LoadData()
    {
        try
        {
            dataGridView1.DataSource = categoryRepo.GetAll();
        }
        catch (Exception e)
        {
            MessageBox.Show("Error loading books " +  e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void CategoryForm_Load(object sender, EventArgs e)
    {
        LoadData();
    }
}