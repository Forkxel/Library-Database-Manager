using System.ComponentModel;

namespace LibraryDatabase.Forms.Member;

partial class MemberForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        dataGridView1 = new System.Windows.Forms.DataGridView();
        buttonAdd = new System.Windows.Forms.Button();
        buttonUpdate = new System.Windows.Forms.Button();
        buttonDelete = new System.Windows.Forms.Button();
        ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
        ColumnFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
        ColumnLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
        ColumnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ColumnID, ColumnFirstName, ColumnLastName, ColumnEmail });
        dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
        dataGridView1.Location = new System.Drawing.Point(0, 0);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.Size = new System.Drawing.Size(800, 340);
        dataGridView1.TabIndex = 0;
        dataGridView1.Text = "dataGridView1";
        // 
        // buttonAdd
        // 
        buttonAdd.Location = new System.Drawing.Point(38, 387);
        buttonAdd.Name = "buttonAdd";
        buttonAdd.Size = new System.Drawing.Size(75, 23);
        buttonAdd.TabIndex = 1;
        buttonAdd.Text = "Add";
        buttonAdd.UseVisualStyleBackColor = true;
        buttonAdd.Click += buttonAdd_Click;
        // 
        // buttonUpdate
        // 
        buttonUpdate.Location = new System.Drawing.Point(147, 387);
        buttonUpdate.Name = "buttonUpdate";
        buttonUpdate.Size = new System.Drawing.Size(75, 23);
        buttonUpdate.TabIndex = 2;
        buttonUpdate.Text = "Update";
        buttonUpdate.UseVisualStyleBackColor = true;
        buttonUpdate.Click += buttonUpdate_Click;
        // 
        // buttonDelete
        // 
        buttonDelete.Location = new System.Drawing.Point(259, 387);
        buttonDelete.Name = "buttonDelete";
        buttonDelete.Size = new System.Drawing.Size(75, 23);
        buttonDelete.TabIndex = 3;
        buttonDelete.Text = "Delete";
        buttonDelete.UseVisualStyleBackColor = true;
        buttonDelete.Click += buttonDelete_Click;
        // 
        // ColumnID
        // 
        ColumnID.DataPropertyName = "MemberID";
        ColumnID.HeaderText = "ID";
        ColumnID.Name = "ColumnID";
        // 
        // ColumnFirstName
        // 
        ColumnFirstName.DataPropertyName = "FirstName";
        ColumnFirstName.HeaderText = "First name";
        ColumnFirstName.Name = "ColumnFirstName";
        // 
        // ColumnLastName
        // 
        ColumnLastName.DataPropertyName = "LastName";
        ColumnLastName.HeaderText = "Last name";
        ColumnLastName.Name = "ColumnLastName";
        // 
        // ColumnEmail
        // 
        ColumnEmail.DataPropertyName = "Email";
        ColumnEmail.HeaderText = "Email";
        ColumnEmail.Name = "ColumnEmail";
        // 
        // MemberForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(buttonDelete);
        Controls.Add(buttonUpdate);
        Controls.Add(buttonAdd);
        Controls.Add(dataGridView1);
        Text = "MemberForm";
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmail;

    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFirstName;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLastName;
    private System.Windows.Forms.Button buttonAdd;
    private System.Windows.Forms.Button buttonUpdate;
    private System.Windows.Forms.Button buttonDelete;

    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;

    private System.Windows.Forms.DataGridView dataGridView1;

    #endregion
}