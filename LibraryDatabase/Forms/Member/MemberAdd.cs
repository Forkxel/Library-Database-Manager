using LibraryDatabase.Data;

namespace LibraryDatabase.Forms.Member;

public partial class MemberAdd : Form
{
    public MemberAdd()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        try
        {
            var member = new Modules.Member
            {
                FirstName = textBoxFirst.Text,
                LastName = textBoxLast.Text,
                Email = textBoxEmail.Text
            };
            
            var repo = new MemberRepository();
            repo.Add(member);
            
            DialogResult = DialogResult.OK;
            Close();
        }
        catch (Exception exception)
        {
            MessageBox.Show("Error adding member: " + exception.Message);
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {
        Close();
    }
}