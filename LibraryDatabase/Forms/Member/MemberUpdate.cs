using LibraryDatabase.Data;

namespace LibraryDatabase.Forms.Member;

public partial class MemberUpdate : Form
{
    public MemberUpdate()
    {
        InitializeComponent();
    }

    private void button1_Click_1(object sender, EventArgs e)
    {
        if (!int.TryParse(textBoxID.Text, out int memberId))
        {
            MessageBox.Show("Invalid ID.");
            return;
        }
        
        var member = new Modules.Member { MemberID = memberId };

        if (!string.IsNullOrWhiteSpace(textBoxFirst.Text))
        {
            member.FirstName = textBoxFirst.Text;
        }

        if (!string.IsNullOrWhiteSpace(textBoxLast.Text))
        {
            member.LastName = textBoxLast.Text;
        }

        if (!string.IsNullOrWhiteSpace(textBoxEmail.Text))
        {
            member.Email = textBoxEmail.Text;
        }

        var repo = new MemberRepository();
        repo.Update(member);

        DialogResult = DialogResult.OK;
        Close();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        Close();
    }
}