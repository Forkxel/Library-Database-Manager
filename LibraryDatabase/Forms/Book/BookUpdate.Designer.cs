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
        button1 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        textBoxID = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // textBoxTitle
        // 
        textBoxTitle.Location = new System.Drawing.Point(106, 70);
        textBoxTitle.Name = "textBoxTitle";
        textBoxTitle.PlaceholderText = "Title";
        textBoxTitle.Size = new System.Drawing.Size(100, 23);
        textBoxTitle.TabIndex = 0;
        // 
        // textBoxCategory
        // 
        textBoxCategory.Location = new System.Drawing.Point(106, 112);
        textBoxCategory.Name = "textBoxCategory";
        textBoxCategory.PlaceholderText = "Category ID";
        textBoxCategory.Size = new System.Drawing.Size(100, 23);
        textBoxCategory.TabIndex = 1;
        // 
        // textBoxAuthor
        // 
        textBoxAuthor.Location = new System.Drawing.Point(106, 155);
        textBoxAuthor.Name = "textBoxAuthor";
        textBoxAuthor.PlaceholderText = "Author ID";
        textBoxAuthor.Size = new System.Drawing.Size(100, 23);
        textBoxAuthor.TabIndex = 2;
        // 
        // textBoxPrice
        // 
        textBoxPrice.Location = new System.Drawing.Point(106, 233);
        textBoxPrice.Name = "textBoxPrice";
        textBoxPrice.PlaceholderText = "Price";
        textBoxPrice.Size = new System.Drawing.Size(100, 23);
        textBoxPrice.TabIndex = 3;
        // 
        // checkBoxAvailable
        // 
        checkBoxAvailable.Location = new System.Drawing.Point(106, 194);
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
        comboBoxState.Location = new System.Drawing.Point(100, 298);
        comboBoxState.Name = "comboBoxState";
        comboBoxState.Size = new System.Drawing.Size(121, 23);
        comboBoxState.TabIndex = 5;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(43, 336);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(100, 44);
        button1.TabIndex = 7;
        button1.Text = "OK";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Location = new System.Drawing.Point(178, 336);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(100, 44);
        button2.TabIndex = 8;
        button2.Text = "Cancel";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // textBoxID
        // 
        textBoxID.Location = new System.Drawing.Point(106, 29);
        textBoxID.Name = "textBoxID";
        textBoxID.PlaceholderText = "ID to update";
        textBoxID.Size = new System.Drawing.Size(100, 23);
        textBoxID.TabIndex = 9;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        label1.Location = new System.Drawing.Point(106, 272);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(100, 23);
        label1.TabIndex = 10;
        label1.Text = "State";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // BookUpdate
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(324, 410);
        Controls.Add(label1);
        Controls.Add(textBoxID);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(comboBoxState);
        Controls.Add(checkBoxAvailable);
        Controls.Add(textBoxPrice);
        Controls.Add(textBoxAuthor);
        Controls.Add(textBoxCategory);
        Controls.Add(textBoxTitle);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        Text = "Update book";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.TextBox textBoxID;

    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.ComboBox comboBoxState;

    private System.Windows.Forms.CheckBox checkBoxAvailable;

    private System.Windows.Forms.TextBox textBoxTitle;
    private System.Windows.Forms.TextBox textBoxCategory;
    private System.Windows.Forms.TextBox textBoxAuthor;
    private System.Windows.Forms.TextBox textBoxPrice;

    #endregion
}