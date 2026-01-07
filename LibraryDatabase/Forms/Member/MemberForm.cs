using LibraryDatabase.Data;

namespace LibraryDatabase.Forms.Member;

public partial class MemberForm : Form
{
    private MemberRepository repository;
    public MemberForm()
    {
        InitializeComponent();
        repository = new MemberRepository();
        dataGridView1.DataSource = repository.GetAll();
    }

    private void buttonAdd_Click(object sender, EventArgs e)
    {
        var memberAddForm = new MemberAdd();
        if (memberAddForm.ShowDialog() == DialogResult.OK)
        {
            RefreshTable();
        }
    }

    private void buttonUpdate_Click(object sender, EventArgs e)
    {
        var memberUpdateForm = new MemberUpdate();
        if (memberUpdateForm.ShowDialog() == DialogResult.OK)
        {
            RefreshTable();
        }
    }

    private void buttonDelete_Click(object sender, EventArgs e)
    {
        var  memberDeleteForm = new MemberDelete();
        if (memberDeleteForm.ShowDialog() == DialogResult.OK)
        {
            RefreshTable();
        }
    }
    
    private void RefreshTable()
    {
        var repo = new MemberRepository();
        dataGridView1.DataSource = repo.GetAll();
    }
}