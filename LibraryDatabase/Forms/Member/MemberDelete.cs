using LibraryDatabase.Data;

namespace LibraryDatabase.Forms.Member;

public partial class MemberDelete : Form
{
    public MemberDelete()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (!int.TryParse(textBoxID.Text, out int memberId))
        {
            MessageBox.Show("Invalid ID");
            return;
        }

        var repo = new MemberRepository();
        repo.Delete(memberId);
        
        DialogResult = DialogResult.OK;
        Close();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        Close();
    }
}