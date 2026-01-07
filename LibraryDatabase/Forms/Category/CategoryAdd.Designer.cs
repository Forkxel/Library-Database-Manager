using System.ComponentModel;

namespace LibraryDatabase.Category;

partial class CategoryAdd
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
        textBoxName = new System.Windows.Forms.TextBox();
        button1 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        buttonImport = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // textBoxName
        // 
        textBoxName.Location = new System.Drawing.Point(353, 198);
        textBoxName.Name = "textBoxName";
        textBoxName.PlaceholderText = "Name";
        textBoxName.Size = new System.Drawing.Size(100, 23);
        textBoxName.TabIndex = 0;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(279, 301);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(101, 56);
        button1.TabIndex = 1;
        button1.Text = "OK";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Location = new System.Drawing.Point(430, 301);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(101, 56);
        button2.TabIndex = 2;
        button2.Text = "Cancel";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // buttonImport
        // 
        buttonImport.Location = new System.Drawing.Point(680, 375);
        buttonImport.Name = "buttonImport";
        buttonImport.Size = new System.Drawing.Size(101, 56);
        buttonImport.TabIndex = 3;
        buttonImport.Text = "Import";
        buttonImport.UseVisualStyleBackColor = true;
        buttonImport.Click += buttonImport_Click;
        // 
        // CategoryAdd
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(buttonImport);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(textBoxName);
        Text = "CategoryADD";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button buttonImport;

    private System.Windows.Forms.TextBox textBoxName;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;

    #endregion
}