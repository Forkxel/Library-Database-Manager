namespace LibraryDatabase;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        splitContainer1 = new System.Windows.Forms.SplitContainer();
        gbReports = new System.Windows.Forms.GroupBox();
        gbApp = new System.Windows.Forms.GroupBox();
        gbManagment = new System.Windows.Forms.GroupBox();
        btnLoans = new System.Windows.Forms.Button();
        btnMembers = new System.Windows.Forms.Button();
        btnCategories = new System.Windows.Forms.Button();
        btnAuthors = new System.Windows.Forms.Button();
        btnBooks = new System.Windows.Forms.Button();
        btnReports = new System.Windows.Forms.Button();
        btnExit = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
        splitContainer1.Panel1.SuspendLayout();
        splitContainer1.SuspendLayout();
        gbReports.SuspendLayout();
        gbApp.SuspendLayout();
        gbManagment.SuspendLayout();
        SuspendLayout();
        // 
        // splitContainer1
        // 
        splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
        splitContainer1.Location = new System.Drawing.Point(0, 0);
        splitContainer1.Name = "splitContainer1";
        // 
        // splitContainer1.Panel1
        // 
        splitContainer1.Panel1.Controls.Add(gbReports);
        splitContainer1.Panel1.Controls.Add(gbManagment);
        splitContainer1.Size = new System.Drawing.Size(800, 450);
        splitContainer1.SplitterDistance = 220;
        splitContainer1.TabIndex = 0;
        splitContainer1.Text = "splitContainer1";
        // 
        // gbReports
        // 
        gbReports.Controls.Add(btnReports);
        gbReports.Controls.Add(gbApp);
        gbReports.Dock = System.Windows.Forms.DockStyle.Fill;
        gbReports.Location = new System.Drawing.Point(0, 182);
        gbReports.Name = "gbReports";
        gbReports.Size = new System.Drawing.Size(220, 268);
        gbReports.TabIndex = 1;
        gbReports.TabStop = false;
        gbReports.Text = "groupBox1";
        // 
        // gbApp
        // 
        gbApp.Controls.Add(btnExit);
        gbApp.Dock = System.Windows.Forms.DockStyle.Bottom;
        gbApp.Location = new System.Drawing.Point(3, 132);
        gbApp.Name = "gbApp";
        gbApp.Size = new System.Drawing.Size(214, 133);
        gbApp.TabIndex = 0;
        gbApp.TabStop = false;
        gbApp.Text = "groupBox2";
        // 
        // gbManagment
        // 
        gbManagment.Controls.Add(btnLoans);
        gbManagment.Controls.Add(btnMembers);
        gbManagment.Controls.Add(btnCategories);
        gbManagment.Controls.Add(btnAuthors);
        gbManagment.Controls.Add(btnBooks);
        gbManagment.Dock = System.Windows.Forms.DockStyle.Top;
        gbManagment.Location = new System.Drawing.Point(0, 0);
        gbManagment.Name = "gbManagment";
        gbManagment.Size = new System.Drawing.Size(220, 182);
        gbManagment.TabIndex = 0;
        gbManagment.TabStop = false;
        gbManagment.Text = "groupBox1";
        // 
        // btnLoans
        // 
        btnLoans.Location = new System.Drawing.Point(49, 139);
        btnLoans.Name = "btnLoans";
        btnLoans.Size = new System.Drawing.Size(75, 23);
        btnLoans.TabIndex = 4;
        btnLoans.Text = "button5";
        btnLoans.UseVisualStyleBackColor = true;
        // 
        // btnMembers
        // 
        btnMembers.Location = new System.Drawing.Point(49, 110);
        btnMembers.Name = "btnMembers";
        btnMembers.Size = new System.Drawing.Size(75, 23);
        btnMembers.TabIndex = 3;
        btnMembers.Text = "button4";
        btnMembers.UseVisualStyleBackColor = true;
        // 
        // btnCategories
        // 
        btnCategories.Location = new System.Drawing.Point(49, 81);
        btnCategories.Name = "btnCategories";
        btnCategories.Size = new System.Drawing.Size(75, 23);
        btnCategories.TabIndex = 2;
        btnCategories.Text = "button3";
        btnCategories.UseVisualStyleBackColor = true;
        // 
        // btnAuthors
        // 
        btnAuthors.Location = new System.Drawing.Point(49, 52);
        btnAuthors.Name = "btnAuthors";
        btnAuthors.Size = new System.Drawing.Size(75, 23);
        btnAuthors.TabIndex = 1;
        btnAuthors.Text = "button2";
        btnAuthors.UseVisualStyleBackColor = true;
        // 
        // btnBooks
        // 
        btnBooks.Location = new System.Drawing.Point(49, 23);
        btnBooks.Name = "btnBooks";
        btnBooks.Size = new System.Drawing.Size(75, 23);
        btnBooks.TabIndex = 0;
        btnBooks.Text = "button1";
        btnBooks.UseVisualStyleBackColor = true;
        // 
        // btnReports
        // 
        btnReports.Location = new System.Drawing.Point(49, 61);
        btnReports.Name = "btnReports";
        btnReports.Size = new System.Drawing.Size(75, 23);
        btnReports.TabIndex = 1;
        btnReports.Text = "button1";
        btnReports.UseVisualStyleBackColor = true;
        // 
        // btnExit
        // 
        btnExit.Location = new System.Drawing.Point(46, 55);
        btnExit.Name = "btnExit";
        btnExit.Size = new System.Drawing.Size(75, 23);
        btnExit.TabIndex = 0;
        btnExit.Text = "button1";
        btnExit.UseVisualStyleBackColor = true;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(splitContainer1);
        Text = "MainForm";
        splitContainer1.Panel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
        splitContainer1.ResumeLayout(false);
        gbReports.ResumeLayout(false);
        gbApp.ResumeLayout(false);
        gbManagment.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button btnExit;

    private System.Windows.Forms.Button btnReports;

    private System.Windows.Forms.GroupBox gbApp;

    private System.Windows.Forms.GroupBox gbReports;

    private System.Windows.Forms.Button btnCategories;
    private System.Windows.Forms.Button btnMembers;
    private System.Windows.Forms.Button btnLoans;

    private System.Windows.Forms.Button btnBooks;
    private System.Windows.Forms.Button btnAuthors;

    private System.Windows.Forms.GroupBox gbManagment;

    private System.Windows.Forms.SplitContainer splitContainer1;

    #endregion
}