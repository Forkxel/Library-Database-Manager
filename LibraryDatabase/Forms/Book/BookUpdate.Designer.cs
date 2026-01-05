using System.ComponentModel;

namespace LibraryDatabase.Forms.Book;

partial class BookUpdate
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
        textBoxCategory = new System.Windows.Forms.TextBox();
        textBoxAuthor = new System.Windows.Forms.TextBox();
        textBoxPrice = new System.Windows.Forms.TextBox();
        checkBoxAvailable = new System.Windows.Forms.CheckBox();
        comboBoxState = new System.Windows.Forms.ComboBox();
        textBox1 = new System.Windows.Forms.TextBox();
        button1 = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // textBoxTitle
        // 
        textBoxTitle.Location = new System.Drawing.Point(340, 75);
        textBoxTitle.Name = "textBoxTitle";
        textBoxTitle.PlaceholderText = "Title";
        textBoxTitle.Size = new System.Drawing.Size(100, 23);
        textBoxTitle.TabIndex = 0;
        // 
        // textBoxCategory
        // 
        textBoxCategory.Location = new System.Drawing.Point(340, 123);
        textBoxCategory.Name = "textBoxCategory";
        textBoxCategory.PlaceholderText = "Category ID";
        textBoxCategory.Size = new System.Drawing.Size(100, 23);
        textBoxCategory.TabIndex = 1;
        // 
        // textBoxAuthor
        // 
        textBoxAuthor.Location = new System.Drawing.Point(340, 171);
        textBoxAuthor.Name = "textBoxAuthor";
        textBoxAuthor.PlaceholderText = "Author ID";
        textBoxAuthor.Size = new System.Drawing.Size(100, 23);
        textBoxAuthor.TabIndex = 2;
        // 
        // textBoxPrice
        // 
        textBoxPrice.Location = new System.Drawing.Point(340, 262);
        textBoxPrice.Name = "textBoxPrice";
        textBoxPrice.PlaceholderText = "Price";
        textBoxPrice.Size = new System.Drawing.Size(100, 23);
        textBoxPrice.TabIndex = 3;
        // 
        // checkBoxAvailable
        // 
        checkBoxAvailable.Location = new System.Drawing.Point(340, 215);
        checkBoxAvailable.Name = "checkBoxAvailable";
        checkBoxAvailable.Size = new System.Drawing.Size(104, 24);
        checkBoxAvailable.TabIndex = 4;
        checkBoxAvailable.Text = "Is available";
        checkBoxAvailable.UseVisualStyleBackColor = true;
        // 
        // comboBoxState
        // 
        comboBoxState.AutoCompleteCustomSource.AddRange(new string[] { "New", "Used", "Damaged" });
        comboBoxState.FormattingEnabled = true;
        comboBoxState.Location = new System.Drawing.Point(327, 332);
        comboBoxState.Name = "comboBoxState";
        comboBoxState.Size = new System.Drawing.Size(121, 23);
        comboBoxState.TabIndex = 5;
        // 
        // textBox1
        // 
        textBox1.Location = new System.Drawing.Point(340, 303);
        textBox1.Name = "textBox1";
        textBox1.ReadOnly = true;
        textBox1.Size = new System.Drawing.Size(100, 23);
        textBox1.TabIndex = 6;
        textBox1.Text = "State";
        textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(340, 380);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(100, 44);
        button1.TabIndex = 7;
        button1.Text = "OK";
        button1.UseVisualStyleBackColor = true;
        // 
        // BookUpdate
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(button1);
        Controls.Add(textBox1);
        Controls.Add(comboBoxState);
        Controls.Add(checkBoxAvailable);
        Controls.Add(textBoxPrice);
        Controls.Add(textBoxAuthor);
        Controls.Add(textBoxCategory);
        Controls.Add(textBoxTitle);
        Text = "Update book";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.TextBox textBox1;

    private System.Windows.Forms.ComboBox comboBoxState;

    private System.Windows.Forms.CheckBox checkBoxAvailable;

    private System.Windows.Forms.TextBox textBoxTitle;
    private System.Windows.Forms.TextBox textBoxCategory;
    private System.Windows.Forms.TextBox textBoxAuthor;
    private System.Windows.Forms.TextBox textBoxPrice;

    #endregion
}