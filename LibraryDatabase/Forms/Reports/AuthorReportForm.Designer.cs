using System.ComponentModel;

namespace LibraryDatabase.Forms.Reports;

partial class AuthorReportForm
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
        Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        button1 = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
        dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
        dataGridView1.Location = new System.Drawing.Point(0, 0);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.Size = new System.Drawing.Size(800, 363);
        dataGridView1.TabIndex = 0;
        dataGridView1.Text = "dataGridView1";
        // 
        // Column1
        // 
        Column1.DataPropertyName = "AuthorName";
        Column1.HeaderText = "Name";
        Column1.Name = "Column1";
        // 
        // Column2
        // 
        Column2.DataPropertyName = "LoanCount";
        Column2.HeaderText = "Loan count";
        Column2.Name = "Column2";
        // 
        // Column3
        // 
        Column3.DataPropertyName = "FirstLoan";
        Column3.HeaderText = "First loan";
        Column3.Name = "Column3";
        // 
        // Column4
        // 
        Column4.DataPropertyName = "LastLoan";
        Column4.HeaderText = "Last loan";
        Column4.Name = "Column4";
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(44, 396);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(75, 23);
        button1.TabIndex = 1;
        button1.Text = "Refresh";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // AuthorReportForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(button1);
        Controls.Add(dataGridView1);
        Text = "AuthorReportForm";
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.DataGridViewTextBoxColumn Column4;

    private System.Windows.Forms.DataGridViewTextBoxColumn Column3;

    private System.Windows.Forms.DataGridViewTextBoxColumn Column2;

    private System.Windows.Forms.DataGridViewTextBoxColumn Column1;

    private System.Windows.Forms.DataGridView dataGridView1;

    #endregion
}