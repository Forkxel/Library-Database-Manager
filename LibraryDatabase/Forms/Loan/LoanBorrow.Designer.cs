using System.ComponentModel;

namespace LibraryDatabase.Forms.Loan;

partial class LoanBorrow
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
        panel1 = new System.Windows.Forms.Panel();
        button1 = new System.Windows.Forms.Button();
        button = new System.Windows.Forms.Button();
        textBoxMember = new System.Windows.Forms.TextBox();
        textBoxBook = new System.Windows.Forms.TextBox();
        splitContainer1 = new System.Windows.Forms.SplitContainer();
        dataGridView1 = new System.Windows.Forms.DataGridView();
        dataGridView2 = new System.Windows.Forms.DataGridView();
        ColumnIDBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
        ColumnTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
        ColumnAuthorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
        ColumnCategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
        ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
        ColumnIsAvailable = new System.Windows.Forms.DataGridViewTextBoxColumn();
        ColumnState = new System.Windows.Forms.DataGridViewTextBoxColumn();
        ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
        ColumnFirst = new System.Windows.Forms.DataGridViewTextBoxColumn();
        ColumnLast = new System.Windows.Forms.DataGridViewTextBoxColumn();
        ColumnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
        splitContainer1.Panel1.SuspendLayout();
        splitContainer1.Panel2.SuspendLayout();
        splitContainer1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Controls.Add(button1);
        panel1.Controls.Add(button);
        panel1.Controls.Add(textBoxMember);
        panel1.Controls.Add(textBoxBook);
        panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
        panel1.Location = new System.Drawing.Point(0, 483);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(1328, 127);
        panel1.TabIndex = 0;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(194, 80);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(75, 23);
        button1.TabIndex = 3;
        button1.Text = "Cancel";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button
        // 
        button.Location = new System.Drawing.Point(67, 80);
        button.Name = "button";
        button.Size = new System.Drawing.Size(75, 23);
        button.TabIndex = 2;
        button.Text = "OK";
        button.UseVisualStyleBackColor = true;
        button.Click += button_Click;
        // 
        // textBoxMember
        // 
        textBoxMember.Location = new System.Drawing.Point(42, 27);
        textBoxMember.Name = "textBoxMember";
        textBoxMember.PlaceholderText = "Member ID";
        textBoxMember.Size = new System.Drawing.Size(100, 23);
        textBoxMember.TabIndex = 1;
        // 
        // textBoxBook
        // 
        textBoxBook.Location = new System.Drawing.Point(194, 27);
        textBoxBook.Name = "textBoxBook";
        textBoxBook.PlaceholderText = "Book ID";
        textBoxBook.Size = new System.Drawing.Size(100, 23);
        textBoxBook.TabIndex = 0;
        // 
        // splitContainer1
        // 
        splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
        splitContainer1.Location = new System.Drawing.Point(0, 0);
        splitContainer1.Name = "splitContainer1";
        // 
        // splitContainer1.Panel1
        // 
        splitContainer1.Panel1.Controls.Add(dataGridView1);
        // 
        // splitContainer1.Panel2
        // 
        splitContainer1.Panel2.Controls.Add(dataGridView2);
        splitContainer1.Size = new System.Drawing.Size(1328, 483);
        splitContainer1.SplitterDistance = 568;
        splitContainer1.TabIndex = 1;
        splitContainer1.Text = "splitContainer1";
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ColumnID, ColumnFirst, ColumnLast, ColumnEmail });
        dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
        dataGridView1.Location = new System.Drawing.Point(0, 0);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.Size = new System.Drawing.Size(568, 483);
        dataGridView1.TabIndex = 0;
        dataGridView1.Text = "dataGridView1";
        // 
        // dataGridView2
        // 
        dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ColumnIDBook, ColumnTitle, ColumnAuthorID, ColumnCategoryID, ColumnPrice, ColumnIsAvailable, ColumnState });
        dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
        dataGridView2.Location = new System.Drawing.Point(0, 0);
        dataGridView2.Name = "dataGridView2";
        dataGridView2.Size = new System.Drawing.Size(756, 483);
        dataGridView2.TabIndex = 0;
        dataGridView2.Text = "dataGridView2";
        // 
        // ColumnIDBook
        // 
        ColumnIDBook.DataPropertyName = "BookId";
        ColumnIDBook.HeaderText = "ID";
        ColumnIDBook.Name = "ColumnIDBook";
        // 
        // ColumnTitle
        // 
        ColumnTitle.DataPropertyName = "BookTitle";
        ColumnTitle.HeaderText = "Title";
        ColumnTitle.Name = "ColumnTitle";
        // 
        // ColumnAuthorID
        // 
        ColumnAuthorID.DataPropertyName = "AuthorId";
        ColumnAuthorID.HeaderText = "Author ID";
        ColumnAuthorID.Name = "ColumnAuthorID";
        // 
        // ColumnCategoryID
        // 
        ColumnCategoryID.DataPropertyName = "CategoryId";
        ColumnCategoryID.HeaderText = "Category ID";
        ColumnCategoryID.Name = "ColumnCategoryID";
        // 
        // ColumnPrice
        // 
        ColumnPrice.DataPropertyName = "Price";
        ColumnPrice.HeaderText = "Price";
        ColumnPrice.Name = "ColumnPrice";
        // 
        // ColumnIsAvailable
        // 
        ColumnIsAvailable.DataPropertyName = "isAvailable";
        ColumnIsAvailable.HeaderText = "Is available";
        ColumnIsAvailable.Name = "ColumnIsAvailable";
        // 
        // ColumnState
        // 
        ColumnState.DataPropertyName = "State";
        ColumnState.HeaderText = "State";
        ColumnState.Name = "ColumnState";
        // 
        // ColumnID
        // 
        ColumnID.DataPropertyName = "MemberId";
        ColumnID.HeaderText = "ID";
        ColumnID.Name = "ColumnID";
        // 
        // ColumnFirst
        // 
        ColumnFirst.DataPropertyName = "FirstName";
        ColumnFirst.HeaderText = "First name";
        ColumnFirst.Name = "ColumnFirst";
        // 
        // ColumnLast
        // 
        ColumnLast.DataPropertyName = "LastName";
        ColumnLast.HeaderText = "Last name";
        ColumnLast.Name = "ColumnLast";
        // 
        // ColumnEmail
        // 
        ColumnEmail.DataPropertyName = "Email";
        ColumnEmail.HeaderText = "Email";
        ColumnEmail.Name = "ColumnEmail";
        // 
        // LoanBorrow
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1328, 610);
        Controls.Add(splitContainer1);
        Controls.Add(panel1);
        Text = "LoanBorrow";
        Load += LoanBorrow_Load;
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        splitContainer1.Panel1.ResumeLayout(false);
        splitContainer1.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
        splitContainer1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button button;
    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.TextBox textBoxBook;

    private System.Windows.Forms.TextBox textBoxMember;

    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;

    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIsAvailable;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnState;

    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAuthorID;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCategoryID;

    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTitle;

    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIDBook;

    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmail;

    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLast;

    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFirst;

    private System.Windows.Forms.DataGridView dataGridView2;

    private System.Windows.Forms.DataGridView dataGridView1;

    private System.Windows.Forms.SplitContainer splitContainer1;

    private System.Windows.Forms.Panel panel1;

    #endregion
}