using System.ComponentModel;

namespace LibraryDatabase.Forms.Author;

partial class AuthorUpdate
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
        textBoxId = new System.Windows.Forms.TextBox();
        textBoxFirst = new System.Windows.Forms.TextBox();
        textBoxLast = new System.Windows.Forms.TextBox();
        buttonOK = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // textBoxId
        // 
        textBoxId.Location = new System.Drawing.Point(350, 112);
        textBoxId.Name = "textBoxId";
        textBoxId.PlaceholderText = "ID to update";
        textBoxId.Size = new System.Drawing.Size(100, 23);
        textBoxId.TabIndex = 0;
        // 
        // textBoxFirst
        // 
        textBoxFirst.Location = new System.Drawing.Point(350, 166);
        textBoxFirst.Name = "textBoxFirst";
        textBoxFirst.PlaceholderText = "First name";
        textBoxFirst.Size = new System.Drawing.Size(100, 23);
        textBoxFirst.TabIndex = 1;
        // 
        // textBoxLast
        // 
        textBoxLast.Location = new System.Drawing.Point(350, 221);
        textBoxLast.Name = "textBoxLast";
        textBoxLast.PlaceholderText = "Last name";
        textBoxLast.Size = new System.Drawing.Size(100, 23);
        textBoxLast.TabIndex = 2;
        // 
        // buttonOK
        // 
        buttonOK.Location = new System.Drawing.Point(301, 300);
        buttonOK.Name = "buttonOK";
        buttonOK.Size = new System.Drawing.Size(78, 44);
        buttonOK.TabIndex = 3;
        buttonOK.Text = "OK";
        buttonOK.UseVisualStyleBackColor = true;
        buttonOK.Click += buttonOK_Click;
        // 
        // button2
        // 
        button2.Location = new System.Drawing.Point(422, 300);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(78, 44);
        button2.TabIndex = 4;
        button2.Text = "Cancel";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // AuthorUpdate
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(button2);
        Controls.Add(buttonOK);
        Controls.Add(textBoxLast);
        Controls.Add(textBoxFirst);
        Controls.Add(textBoxId);
        Text = "AuthorUpdate";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox textBoxId;
    private System.Windows.Forms.TextBox textBoxFirst;
    private System.Windows.Forms.Button buttonOK;
    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.TextBox textBoxLast;

    #endregion
}