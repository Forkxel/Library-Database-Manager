using System.ComponentModel;

namespace LibraryDatabase.Forms.Author;

partial class AuthorAdd
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
        textBoxFirst = new System.Windows.Forms.TextBox();
        textBoxLast = new System.Windows.Forms.TextBox();
        button1 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        buttonImport = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // textBoxFirst
        // 
        textBoxFirst.Location = new System.Drawing.Point(124, 50);
        textBoxFirst.Name = "textBoxFirst";
        textBoxFirst.PlaceholderText = "First name";
        textBoxFirst.Size = new System.Drawing.Size(100, 23);
        textBoxFirst.TabIndex = 0;
        // 
        // textBoxLast
        // 
        textBoxLast.Location = new System.Drawing.Point(124, 99);
        textBoxLast.Name = "textBoxLast";
        textBoxLast.PlaceholderText = "Last name";
        textBoxLast.Size = new System.Drawing.Size(100, 23);
        textBoxLast.TabIndex = 1;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(69, 147);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(86, 58);
        button1.TabIndex = 2;
        button1.Text = "OK";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Location = new System.Drawing.Point(189, 147);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(86, 58);
        button2.TabIndex = 3;
        button2.Text = "Cancel";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // buttonImport
        // 
        buttonImport.Location = new System.Drawing.Point(309, 212);
        buttonImport.Name = "buttonImport";
        buttonImport.Size = new System.Drawing.Size(86, 58);
        buttonImport.TabIndex = 4;
        buttonImport.Text = "Import";
        buttonImport.UseVisualStyleBackColor = true;
        buttonImport.Click += buttonImport_Click;
        // 
        // AuthorAdd
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(408, 283);
        Controls.Add(buttonImport);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(textBoxLast);
        Controls.Add(textBoxFirst);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        Text = "AuthorAdd";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button buttonImport;

    private System.Windows.Forms.TextBox textBoxFirst;
    private System.Windows.Forms.TextBox textBoxLast;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;

    #endregion
}