using System.ComponentModel;

namespace LibraryDatabase.Forms.Member;

partial class MemberAdd
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
        textBoxEmail = new System.Windows.Forms.TextBox();
        button1 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // textBoxFirst
        // 
        textBoxFirst.Location = new System.Drawing.Point(354, 114);
        textBoxFirst.Name = "textBoxFirst";
        textBoxFirst.PlaceholderText = "First name";
        textBoxFirst.Size = new System.Drawing.Size(100, 23);
        textBoxFirst.TabIndex = 0;
        // 
        // textBoxLast
        // 
        textBoxLast.Location = new System.Drawing.Point(354, 172);
        textBoxLast.Name = "textBoxLast";
        textBoxLast.PlaceholderText = "Last name";
        textBoxLast.Size = new System.Drawing.Size(100, 23);
        textBoxLast.TabIndex = 1;
        // 
        // textBoxEmail
        // 
        textBoxEmail.Location = new System.Drawing.Point(354, 226);
        textBoxEmail.Name = "textBoxEmail";
        textBoxEmail.PlaceholderText = "Email";
        textBoxEmail.Size = new System.Drawing.Size(100, 23);
        textBoxEmail.TabIndex = 2;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(289, 293);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(88, 49);
        button1.TabIndex = 3;
        button1.Text = "OK";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Location = new System.Drawing.Point(424, 293);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(88, 49);
        button2.TabIndex = 4;
        button2.Text = "Cancel";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // MemberAdd
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(textBoxEmail);
        Controls.Add(textBoxLast);
        Controls.Add(textBoxFirst);
        Text = "MemberAdd";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox textBoxLast;
    private System.Windows.Forms.TextBox textBoxEmail;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.TextBox textBoxFirst;

    #endregion
}