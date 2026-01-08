using System.ComponentModel;

namespace LibraryDatabase.Category;

partial class CategoryUpdate
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
        textBoxID = new System.Windows.Forms.TextBox();
        textBoxCategory = new System.Windows.Forms.TextBox();
        button1 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // textBoxID
        // 
        textBoxID.Location = new System.Drawing.Point(96, 54);
        textBoxID.Name = "textBoxID";
        textBoxID.PlaceholderText = "ID to update";
        textBoxID.Size = new System.Drawing.Size(100, 23);
        textBoxID.TabIndex = 0;
        // 
        // textBoxCategory
        // 
        textBoxCategory.Location = new System.Drawing.Point(96, 102);
        textBoxCategory.Name = "textBoxCategory";
        textBoxCategory.PlaceholderText = "Category name";
        textBoxCategory.Size = new System.Drawing.Size(100, 23);
        textBoxCategory.TabIndex = 1;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(47, 152);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(84, 50);
        button1.TabIndex = 2;
        button1.Text = "OK";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Location = new System.Drawing.Point(161, 152);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(84, 50);
        button2.TabIndex = 3;
        button2.Text = "Cancel";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // CategoryUpdate
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(295, 247);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(textBoxCategory);
        Controls.Add(textBoxID);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        Text = "CategoryUpdate";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox textBoxID;
    private System.Windows.Forms.TextBox textBoxCategory;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;

    #endregion
}