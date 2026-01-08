using System.ComponentModel;

namespace LibraryDatabase.Forms.Book;

partial class BookAdd
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
        textBoxTitle = new System.Windows.Forms.TextBox();
        textBoxAuthorId = new System.Windows.Forms.TextBox();
        textBoxCategory = new System.Windows.Forms.TextBox();
        textBoxPrice = new System.Windows.Forms.TextBox();
        comboBoxState = new System.Windows.Forms.ComboBox();
        checkBoxAvailable = new System.Windows.Forms.CheckBox();
        button1 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // textBoxTitle
        // 
        textBoxTitle.Location = new System.Drawing.Point(133, 29);
        textBoxTitle.Name = "textBoxTitle";
        textBoxTitle.PlaceholderText = "Title";
        textBoxTitle.Size = new System.Drawing.Size(100, 23);
        textBoxTitle.TabIndex = 0;
        // 
        // textBoxAuthorId
        // 
        textBoxAuthorId.Location = new System.Drawing.Point(133, 72);
        textBoxAuthorId.Name = "textBoxAuthorId";
        textBoxAuthorId.PlaceholderText = "Author ID";
        textBoxAuthorId.Size = new System.Drawing.Size(100, 23);
        textBoxAuthorId.TabIndex = 1;
        // 
        // textBoxCategory
        // 
        textBoxCategory.Location = new System.Drawing.Point(133, 118);
        textBoxCategory.Name = "textBoxCategory";
        textBoxCategory.PlaceholderText = "Category ID";
        textBoxCategory.Size = new System.Drawing.Size(100, 23);
        textBoxCategory.TabIndex = 2;
        // 
        // textBoxPrice
        // 
        textBoxPrice.Location = new System.Drawing.Point(133, 203);
        textBoxPrice.Name = "textBoxPrice";
        textBoxPrice.PlaceholderText = "Price";
        textBoxPrice.Size = new System.Drawing.Size(100, 23);
        textBoxPrice.TabIndex = 4;
        // 
        // comboBoxState
        // 
        comboBoxState.FormattingEnabled = true;
        comboBoxState.Location = new System.Drawing.Point(124, 285);
        comboBoxState.Name = "comboBoxState";
        comboBoxState.Size = new System.Drawing.Size(121, 23);
        comboBoxState.TabIndex = 5;
        // 
        // checkBoxAvailable
        // 
        checkBoxAvailable.Location = new System.Drawing.Point(133, 162);
        checkBoxAvailable.Name = "checkBoxAvailable";
        checkBoxAvailable.Size = new System.Drawing.Size(104, 24);
        checkBoxAvailable.TabIndex = 6;
        checkBoxAvailable.Text = "Is available";
        checkBoxAvailable.UseVisualStyleBackColor = true;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(63, 332);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(100, 41);
        button1.TabIndex = 7;
        button1.Text = "OK";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Location = new System.Drawing.Point(205, 332);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(100, 41);
        button2.TabIndex = 9;
        button2.Text = "Cancel";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        label1.Location = new System.Drawing.Point(133, 259);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(100, 23);
        label1.TabIndex = 10;
        label1.Text = "State";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // BookAdd
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(348, 407);
        Controls.Add(label1);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(checkBoxAvailable);
        Controls.Add(comboBoxState);
        Controls.Add(textBoxPrice);
        Controls.Add(textBoxCategory);
        Controls.Add(textBoxAuthorId);
        Controls.Add(textBoxTitle);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        Text = "Add book";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.CheckBox checkBoxAvailable;

    private System.Windows.Forms.TextBox textBoxPrice;
    private System.Windows.Forms.ComboBox comboBoxState;

    private System.Windows.Forms.TextBox textBoxAuthorId;
    private System.Windows.Forms.TextBox textBoxCategory;

    private System.Windows.Forms.TextBox textBoxTitle;

    #endregion
}