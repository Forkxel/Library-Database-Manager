using System.ComponentModel;

namespace LibraryDatabase.Forms.Book;

partial class BookForm
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
        ColumnTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
        ColumnAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
        ColumnCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
        ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
        ColumnIsAvailable = new System.Windows.Forms.DataGridViewTextBoxColumn();
        State = new System.Windows.Forms.DataGridViewTextBoxColumn();
        UpdateButton = new System.Windows.Forms.Button();
        DeleteButton = new System.Windows.Forms.Button();
        AddButton = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // dataGridView1
        // 
        dataGridView1.AllowUserToAddRows = false;
        dataGridView1.AllowUserToDeleteRows = false;
        dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ColumnID, ColumnTitle, ColumnAuthor, ColumnCategory, ColumnPrice, ColumnIsAvailable, State });
        dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
        dataGridView1.Location = new System.Drawing.Point(0, 0);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.ReadOnly = true;
        dataGridView1.Size = new System.Drawing.Size(800, 350);
        dataGridView1.TabIndex = 0;
        dataGridView1.Text = "dataGridView1";
        // 
        // ColumnID
        // 
        ColumnID.DataPropertyName = "BookId";
        ColumnID.HeaderText = "ID";
        ColumnID.Name = "ColumnID";
        ColumnID.ReadOnly = true;
        // 
        // ColumnTitle
        // 
        ColumnTitle.DataPropertyName = "BookTitle";
        ColumnTitle.HeaderText = "Title";
        ColumnTitle.Name = "ColumnTitle";
        ColumnTitle.ReadOnly = true;
        // 
        // ColumnAuthor
        // 
        ColumnAuthor.DataPropertyName = "AuthorId";
        ColumnAuthor.HeaderText = "Author";
        ColumnAuthor.Name = "ColumnAuthor";
        ColumnAuthor.ReadOnly = true;
        // 
        // ColumnCategory
        // 
        ColumnCategory.DataPropertyName = "CategoryId";
        ColumnCategory.HeaderText = "Category";
        ColumnCategory.Name = "ColumnCategory";
        ColumnCategory.ReadOnly = true;
        // 
        // ColumnPrice
        // 
        ColumnPrice.DataPropertyName = "Price";
        ColumnPrice.HeaderText = "Price";
        ColumnPrice.Name = "ColumnPrice";
        ColumnPrice.ReadOnly = true;
        // 
        // ColumnIsAvailable
        // 
        ColumnIsAvailable.DataPropertyName = "isAvailable";
        ColumnIsAvailable.HeaderText = "Available";
        ColumnIsAvailable.Name = "ColumnIsAvailable";
        ColumnIsAvailable.ReadOnly = true;
        // 
        // State
        // 
        State.DataPropertyName = "State";
        State.HeaderText = "State";
        State.Name = "State";
        State.ReadOnly = true;
        // 
        // UpdateButton
        // 
        UpdateButton.Location = new System.Drawing.Point(32, 389);
        UpdateButton.Name = "UpdateButton";
        UpdateButton.Size = new System.Drawing.Size(75, 23);
        UpdateButton.TabIndex = 1;
        UpdateButton.Text = "Update";
        UpdateButton.UseVisualStyleBackColor = true;
        UpdateButton.Click += UpdateButton_Click;
        // 
        // DeleteButton
        // 
        DeleteButton.Location = new System.Drawing.Point(146, 389);
        DeleteButton.Name = "DeleteButton";
        DeleteButton.Size = new System.Drawing.Size(75, 23);
        DeleteButton.TabIndex = 2;
        DeleteButton.Text = "Delete";
        DeleteButton.UseVisualStyleBackColor = true;
        DeleteButton.Click += DeleteButton_Click;
        // 
        // AddButton
        // 
        AddButton.Location = new System.Drawing.Point(273, 389);
        AddButton.Name = "AddButton";
        AddButton.Size = new System.Drawing.Size(75, 23);
        AddButton.TabIndex = 3;
        AddButton.Text = "Add";
        AddButton.UseVisualStyleBackColor = true;
        AddButton.Click += AddButton_Click;
        // 
        // BookForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(AddButton);
        Controls.Add(DeleteButton);
        Controls.Add(UpdateButton);
        Controls.Add(dataGridView1);
        Text = "BookForm";
        Load += BookForm_Load;
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button UpdateButton;
    private System.Windows.Forms.Button DeleteButton;
    private System.Windows.Forms.Button AddButton;

    private System.Windows.Forms.DataGridViewTextBoxColumn State;

    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIsAvailable;

    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;

    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCategory;

    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAuthor;

    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTitle;

    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;

    private System.Windows.Forms.DataGridView dataGridView1;

    #endregion
}