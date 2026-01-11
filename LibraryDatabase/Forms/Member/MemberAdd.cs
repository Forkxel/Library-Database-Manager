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
        if (string.IsNullOrWhiteSpace(textBoxFirst.Text) ||
            string.IsNullOrWhiteSpace(textBoxLast.Text) ||
            string.IsNullOrWhiteSpace(textBoxEmail.Text))
        {
            MessageBox.Show("All fields must be filled.",
                "Validation error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }

        if (!textBoxEmail.Text.Contains("@"))
        {
            MessageBox.Show("Invalid email address.",
                "Validation error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }

        try
        {
            var member = new Modules.Member
            {
                FirstName = textBoxFirst.Text.Trim(),
                LastName = textBoxLast.Text.Trim(),
                Email = textBoxEmail.Text.Trim()
            };

            var repo = new MemberRepository();
            repo.Add(member);

            DialogResult = DialogResult.OK;
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error adding member: " + ex.Message);
        }
    }


    private void button2_Click(object sender, EventArgs e)
    {
        Close();
    }
}