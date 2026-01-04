using System.ComponentModel;

namespace LibraryDatabase;

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
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ColumnID, ColumnTitle, ColumnAuthor, ColumnCategory, ColumnPrice, ColumnIsAvailable });
        dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
        dataGridView1.Location = new System.Drawing.Point(0, 0);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.Size = new System.Drawing.Size(800, 231);
        dataGridView1.TabIndex = 0;
        dataGridView1.Text = "dataGridView1";
        // 
        // ColumnID
        // 
        ColumnID.HeaderText = "ID";
        ColumnID.Name = "ColumnID";
        ColumnID.Visible = false;
        // 
        // ColumnTitle
        // 
        ColumnTitle.HeaderText = "Title";
        ColumnTitle.Name = "ColumnTitle";
        // 
        // ColumnAuthor
        // 
        ColumnAuthor.HeaderText = "Author";
        ColumnAuthor.Name = "ColumnAuthor";
        // 
        // ColumnCategory
        // 
        ColumnCategory.HeaderText = "Category";
        ColumnCategory.Name = "ColumnCategory";
        // 
        // ColumnPrice
        // 
        ColumnPrice.HeaderText = "Price";
        ColumnPrice.Name = "ColumnPrice";
        // 
        // ColumnIsAvailable
        // 
        ColumnIsAvailable.HeaderText = "Available";
        ColumnIsAvailable.Name = "ColumnIsAvailable";
        // 
        // BookForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(dataGridView1);
        Text = "BookForm";
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIsAvailable;

    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;

    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCategory;

    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAuthor;

    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTitle;

    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;

    private System.Windows.Forms.DataGridView dataGridView1;

    #endregion
}