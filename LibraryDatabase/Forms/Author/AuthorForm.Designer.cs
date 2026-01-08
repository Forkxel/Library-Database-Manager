using System.ComponentModel;

namespace LibraryDatabase.Forms.Author;

partial class AuthorForm
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
        ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
        ColumnFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
        ColumnLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
        buttonAdd = new System.Windows.Forms.Button();
        buttonUpdate = new System.Windows.Forms.Button();
        buttonDelete = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ColumnID, ColumnFirstName, ColumnLastName });
        dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
        dataGridView1.Location = new System.Drawing.Point(0, 0);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.Size = new System.Drawing.Size(470, 330);
        dataGridView1.TabIndex = 0;
        dataGridView1.Text = "dataGridView1";
        // 
        // ColumnID
        // 
        ColumnID.DataPropertyName = "AuthorID";
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
        // buttonAdd
        // 
        buttonAdd.Location = new System.Drawing.Point(51, 387);
        buttonAdd.Name = "buttonAdd";
        buttonAdd.Size = new System.Drawing.Size(75, 23);
        buttonAdd.TabIndex = 1;
        buttonAdd.Text = "Add";
        buttonAdd.UseVisualStyleBackColor = true;
        buttonAdd.Click += buttonAdd_Click;
        // 
        // buttonUpdate
        // 
        buttonUpdate.Location = new System.Drawing.Point(174, 387);
        buttonUpdate.Name = "buttonUpdate";
        buttonUpdate.Size = new System.Drawing.Size(75, 23);
        buttonUpdate.TabIndex = 2;
        buttonUpdate.Text = "Update";
        buttonUpdate.UseVisualStyleBackColor = true;
        buttonUpdate.Click += buttonUpdate_Click;
        // 
        // buttonDelete
        // 
        buttonDelete.Location = new System.Drawing.Point(300, 387);
        buttonDelete.Name = "buttonDelete";
        buttonDelete.Size = new System.Drawing.Size(75, 23);
        buttonDelete.TabIndex = 3;
        buttonDelete.Text = "Delete";
        buttonDelete.UseVisualStyleBackColor = true;
        buttonDelete.Click += buttonDelete_Click;
        // 
        // AuthorForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(470, 433);
        Controls.Add(buttonDelete);
        Controls.Add(buttonUpdate);
        Controls.Add(buttonAdd);
        Controls.Add(dataGridView1);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "AuthorForm";
        Load += AuthorForm_Load;
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button buttonAdd;
    private System.Windows.Forms.Button buttonUpdate;
    private System.Windows.Forms.Button buttonDelete;

    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFirstName;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLastName;

    private System.Windows.Forms.DataGridView dataGridView1;

    #endregion
}