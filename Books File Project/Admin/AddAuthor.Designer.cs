namespace Books_File_Project.Admin
{
    partial class AddAuthor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.AddAuthroButton = new System.Windows.Forms.Button();
            this.AuthorName = new System.Windows.Forms.Label();
            this.AuthorID = new System.Windows.Forms.Label();
            this.AuthorEmail = new System.Windows.Forms.Label();
            this.AuthorNameText = new System.Windows.Forms.TextBox();
            this.AuthorIDText = new System.Windows.Forms.TextBox();
            this.AuthorEmailText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddAuthroButton
            // 
            this.AddAuthroButton.Location = new System.Drawing.Point(85, 241);
            this.AddAuthroButton.Name = "AddAuthroButton";
            this.AddAuthroButton.Size = new System.Drawing.Size(100, 26);
            this.AddAuthroButton.TabIndex = 0;
            this.AddAuthroButton.Text = "Add Author";
            this.AddAuthroButton.UseVisualStyleBackColor = true;
            this.AddAuthroButton.Click += new System.EventHandler(this.AddAuthroButton_Click);
            // 
            // AuthorName
            // 
            this.AuthorName.AutoSize = true;
            this.AuthorName.Location = new System.Drawing.Point(22, 22);
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.Size = new System.Drawing.Size(35, 13);
            this.AuthorName.TabIndex = 1;
            this.AuthorName.Text = "Name";
            // 
            // AuthorID
            // 
            this.AuthorID.AutoSize = true;
            this.AuthorID.Location = new System.Drawing.Point(22, 87);
            this.AuthorID.Name = "AuthorID";
            this.AuthorID.Size = new System.Drawing.Size(18, 13);
            this.AuthorID.TabIndex = 2;
            this.AuthorID.Text = "ID";
            // 
            // AuthorEmail
            // 
            this.AuthorEmail.AutoSize = true;
            this.AuthorEmail.Location = new System.Drawing.Point(22, 157);
            this.AuthorEmail.Name = "AuthorEmail";
            this.AuthorEmail.Size = new System.Drawing.Size(32, 13);
            this.AuthorEmail.TabIndex = 3;
            this.AuthorEmail.Text = "Email";
            this.AuthorEmail.Click += new System.EventHandler(this.label3_Click);
            // 
            // AuthorNameText
            // 
            this.AuthorNameText.Location = new System.Drawing.Point(25, 47);
            this.AuthorNameText.MaxLength = 20;
            this.AuthorNameText.Name = "AuthorNameText";
            this.AuthorNameText.Size = new System.Drawing.Size(100, 20);
            this.AuthorNameText.TabIndex = 4;
            // 
            // AuthorIDText
            // 
            this.AuthorIDText.Location = new System.Drawing.Point(25, 119);
            this.AuthorIDText.MaxLength = 5;
            this.AuthorIDText.Name = "AuthorIDText";
            this.AuthorIDText.Size = new System.Drawing.Size(100, 20);
            this.AuthorIDText.TabIndex = 5;
            // 
            // AuthorEmailText
            // 
            this.AuthorEmailText.Location = new System.Drawing.Point(25, 185);
            this.AuthorEmailText.MaxLength = 25;
            this.AuthorEmailText.Name = "AuthorEmailText";
            this.AuthorEmailText.Size = new System.Drawing.Size(100, 20);
            this.AuthorEmailText.TabIndex = 6;
            // 
            // AddAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 299);
            this.Controls.Add(this.AuthorEmailText);
            this.Controls.Add(this.AuthorIDText);
            this.Controls.Add(this.AuthorNameText);
            this.Controls.Add(this.AuthorEmail);
            this.Controls.Add(this.AuthorID);
            this.Controls.Add(this.AuthorName);
            this.Controls.Add(this.AddAuthroButton);
            this.Name = "AddAuthor";
            this.Text = "AddAuthor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddAuthroButton;
        private System.Windows.Forms.Label AuthorName;
        private System.Windows.Forms.Label AuthorID;
        private System.Windows.Forms.Label AuthorEmail;
        private System.Windows.Forms.TextBox AuthorNameText;
        private System.Windows.Forms.TextBox AuthorIDText;
        private System.Windows.Forms.TextBox AuthorEmailText;
    }
}