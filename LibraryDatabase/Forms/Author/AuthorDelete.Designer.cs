using System.ComponentModel;

namespace LibraryDatabase.Forms.Author;

partial class AuthorDelete
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
        buttonOK = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // textBoxID
        // 
        textBoxID.Location = new System.Drawing.Point(115, 48);
        textBoxID.Name = "textBoxID";
        textBoxID.PlaceholderText = "ID to delete";
        textBoxID.Size = new System.Drawing.Size(100, 23);
        textBoxID.TabIndex = 0;
        textBoxID.TabStop = false;
        // 
        // buttonOK
        // 
        buttonOK.Location = new System.Drawing.Point(49, 107);
        buttonOK.Name = "buttonOK";
        buttonOK.Size = new System.Drawing.Size(98, 46);
        buttonOK.TabIndex = 1;
        buttonOK.Text = "OK";
        buttonOK.UseVisualStyleBackColor = true;
        buttonOK.Click += buttonOK_Click;
        // 
        // button2
        // 
        button2.Location = new System.Drawing.Point(183, 107);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(98, 46);
        button2.TabIndex = 2;
        button2.Text = "Cancel";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // AuthorDelete
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(324, 201);
        Controls.Add(button2);
        Controls.Add(buttonOK);
        Controls.Add(textBoxID);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        Text = "AuthorDelete";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox textBoxID;
    private System.Windows.Forms.Button buttonOK;
    private System.Windows.Forms.Button button2;

    #endregion
}