namespace LibraryDatabase.Forms;

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
        groupBox1 = new System.Windows.Forms.GroupBox();
        button2 = new System.Windows.Forms.Button();
        button3 = new System.Windows.Forms.Button();
        button4 = new System.Windows.Forms.Button();
        button5 = new System.Windows.Forms.Button();
        button6 = new System.Windows.Forms.Button();
        Reports = new System.Windows.Forms.GroupBox();
        button7 = new System.Windows.Forms.Button();
        button8 = new System.Windows.Forms.Button();
        buttonReset = new System.Windows.Forms.Button();
        groupBox1.SuspendLayout();
        Reports.SuspendLayout();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(buttonReset);
        groupBox1.Controls.Add(button2);
        groupBox1.Controls.Add(button3);
        groupBox1.Controls.Add(button4);
        groupBox1.Controls.Add(button5);
        groupBox1.Controls.Add(button6);
        groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
        groupBox1.Location = new System.Drawing.Point(0, 0);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(462, 289);
        groupBox1.TabIndex = 1;
        groupBox1.TabStop = false;
        groupBox1.Text = "Tables";
        // 
        // button2
        // 
        button2.Location = new System.Drawing.Point(166, 190);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(112, 31);
        button2.TabIndex = 4;
        button2.Text = "Loans";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // button3
        // 
        button3.Location = new System.Drawing.Point(166, 153);
        button3.Name = "button3";
        button3.Size = new System.Drawing.Size(112, 31);
        button3.TabIndex = 3;
        button3.Text = "Members";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // button4
        // 
        button4.Location = new System.Drawing.Point(166, 116);
        button4.Name = "button4";
        button4.Size = new System.Drawing.Size(112, 31);
        button4.TabIndex = 2;
        button4.Text = "Categories";
        button4.UseVisualStyleBackColor = true;
        button4.Click += button4_Click;
        // 
        // button5
        // 
        button5.Location = new System.Drawing.Point(166, 79);
        button5.Name = "button5";
        button5.Size = new System.Drawing.Size(112, 31);
        button5.TabIndex = 1;
        button5.Text = "Authors";
        button5.UseVisualStyleBackColor = true;
        button5.Click += button5_Click;
        // 
        // button6
        // 
        button6.Location = new System.Drawing.Point(166, 42);
        button6.Name = "button6";
        button6.Size = new System.Drawing.Size(112, 31);
        button6.TabIndex = 0;
        button6.Text = "Books";
        button6.UseVisualStyleBackColor = true;
        button6.Click += button6_Click;
        // 
        // Reports
        // 
        Reports.Controls.Add(button7);
        Reports.Controls.Add(button8);
        Reports.Dock = System.Windows.Forms.DockStyle.Fill;
        Reports.Location = new System.Drawing.Point(0, 289);
        Reports.Name = "Reports";
        Reports.Size = new System.Drawing.Size(462, 191);
        Reports.TabIndex = 2;
        Reports.TabStop = false;
        Reports.Text = "Reports";
        // 
        // button7
        // 
        button7.Location = new System.Drawing.Point(166, 108);
        button7.Name = "button7";
        button7.Size = new System.Drawing.Size(112, 58);
        button7.TabIndex = 2;
        button7.Text = "Book Report";
        button7.UseVisualStyleBackColor = true;
        button7.Click += button7_Click;
        // 
        // button8
        // 
        button8.Location = new System.Drawing.Point(166, 28);
        button8.Name = "button8";
        button8.Size = new System.Drawing.Size(112, 58);
        button8.TabIndex = 1;
        button8.Text = "Author Report";
        button8.UseVisualStyleBackColor = true;
        button8.Click += button8_Click;
        // 
        // buttonReset
        // 
        buttonReset.Location = new System.Drawing.Point(166, 239);
        buttonReset.Name = "buttonReset";
        buttonReset.Size = new System.Drawing.Size(112, 31);
        buttonReset.TabIndex = 5;
        buttonReset.Text = "Reset database";
        buttonReset.UseVisualStyleBackColor = true;
        buttonReset.Click += buttonReset_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(462, 480);
        Controls.Add(Reports);
        Controls.Add(groupBox1);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Library";
        groupBox1.ResumeLayout(false);
        Reports.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button buttonReset;

    private System.Windows.Forms.GroupBox Reports;
    private System.Windows.Forms.Button button7;
    private System.Windows.Forms.Button button8;

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button5;
    private System.Windows.Forms.Button button6;

    private System.Windows.Forms.Button btnExit;

    private System.Windows.Forms.GroupBox gbApp;

    #endregion
}