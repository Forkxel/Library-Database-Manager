using System.ComponentModel;

namespace LibraryDatabase.Forms.Loan;

partial class LoanForm
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
        Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        buttonBorrow = new System.Windows.Forms.Button();
        buttonReturn = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ColumnID, Column1, Column2, Column3, Column4 });
        dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
        dataGridView1.Location = new System.Drawing.Point(0, 0);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.Size = new System.Drawing.Size(632, 328);
        dataGridView1.TabIndex = 0;
        dataGridView1.Text = "dataGridView1";
        // 
        // ColumnID
        // 
        ColumnID.DataPropertyName = "LoanId";
        ColumnID.HeaderText = "ID";
        ColumnID.Name = "ColumnID";
        // 
        // Column1
        // 
        Column1.DataPropertyName = "MemberId";
        Column1.HeaderText = "Member ID";
        Column1.Name = "Column1";
        // 
        // Column2
        // 
        Column2.DataPropertyName = "BookId";
        Column2.HeaderText = "Book ID";
        Column2.Name = "Column2";
        // 
        // Column3
        // 
        Column3.DataPropertyName = "LoanDate";
        Column3.HeaderText = "Loan date";
        Column3.Name = "Column3";
        // 
        // Column4
        // 
        Column4.DataPropertyName = "ReturnDate";
        Column4.HeaderText = "Return date";
        Column4.Name = "Column4";
        // 
        // buttonBorrow
        // 
        buttonBorrow.Location = new System.Drawing.Point(41, 381);
        buttonBorrow.Name = "buttonBorrow";
        buttonBorrow.Size = new System.Drawing.Size(93, 23);
        buttonBorrow.TabIndex = 1;
        buttonBorrow.Text = "Borrow book";
        buttonBorrow.UseVisualStyleBackColor = true;
        buttonBorrow.Click += buttonBorrow_Click;
        // 
        // buttonReturn
        // 
        buttonReturn.Location = new System.Drawing.Point(190, 381);
        buttonReturn.Name = "buttonReturn";
        buttonReturn.Size = new System.Drawing.Size(93, 23);
        buttonReturn.TabIndex = 2;
        buttonReturn.Text = "Return book";
        buttonReturn.UseVisualStyleBackColor = true;
        buttonReturn.Click += buttonReturn_Click;
        // 
        // LoanForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(632, 447);
        Controls.Add(buttonReturn);
        Controls.Add(buttonBorrow);
        Controls.Add(dataGridView1);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "LoanForm";
        Load += LoanForm_Load;
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    private System.Windows.Forms.Button buttonBorrow;
    private System.Windows.Forms.Button buttonReturn;

    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column3;

    private System.Windows.Forms.DataGridView dataGridView1;

    #endregion
}