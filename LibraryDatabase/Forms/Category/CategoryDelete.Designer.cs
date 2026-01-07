using System.ComponentModel;

namespace LibraryDatabase.Category;

partial class CategoryDelete
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
        buttonCancel = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // textBoxID
        // 
        textBoxID.Location = new System.Drawing.Point(353, 179);
        textBoxID.Name = "textBoxID";
        textBoxID.PlaceholderText = "ID to delete";
        textBoxID.Size = new System.Drawing.Size(100, 23);
        textBoxID.TabIndex = 0;
        // 
        // buttonOK
        // 
        buttonOK.Location = new System.Drawing.Point(297, 274);
        buttonOK.Name = "buttonOK";
        buttonOK.Size = new System.Drawing.Size(84, 46);
        buttonOK.TabIndex = 1;
        buttonOK.Text = "OK";
        buttonOK.UseVisualStyleBackColor = true;
        buttonOK.Click += buttonOK_Click;
        // 
        // buttonCancel
        // 
        buttonCancel.Location = new System.Drawing.Point(419, 274);
        buttonCancel.Name = "buttonCancel";
        buttonCancel.Size = new System.Drawing.Size(84, 46);
        buttonCancel.TabIndex = 2;
        buttonCancel.Text = "Cancel";
        buttonCancel.UseVisualStyleBackColor = true;
        buttonCancel.Click += buttonCancel_Click;
        // 
        // CategoryDelete
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(buttonCancel);
        Controls.Add(buttonOK);
        Controls.Add(textBoxID);
        Text = "CategoryDelete";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox textBoxID;
    private System.Windows.Forms.Button buttonOK;
    private System.Windows.Forms.Button buttonCancel;

    #endregion
}