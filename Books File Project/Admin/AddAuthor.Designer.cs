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
            this.BackBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddAuthroButton
            // 
            this.AddAuthroButton.Location = new System.Drawing.Point(113, 297);
            this.AddAuthroButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddAuthroButton.Name = "AddAuthroButton";
            this.AddAuthroButton.Size = new System.Drawing.Size(133, 32);
            this.AddAuthroButton.TabIndex = 0;
            this.AddAuthroButton.Text = "Add Author";
            this.AddAuthroButton.UseVisualStyleBackColor = true;
            this.AddAuthroButton.Click += new System.EventHandler(this.AddAuthroButton_Click);
            // 
            // AuthorName
            // 
            this.AuthorName.AutoSize = true;
            this.AuthorName.Location = new System.Drawing.Point(29, 27);
            this.AuthorName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.Size = new System.Drawing.Size(45, 17);
            this.AuthorName.TabIndex = 1;
            this.AuthorName.Text = "Name";
            // 
            // AuthorID
            // 
            this.AuthorID.AutoSize = true;
            this.AuthorID.Location = new System.Drawing.Point(29, 107);
            this.AuthorID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AuthorID.Name = "AuthorID";
            this.AuthorID.Size = new System.Drawing.Size(21, 17);
            this.AuthorID.TabIndex = 2;
            this.AuthorID.Text = "ID";
            // 
            // AuthorEmail
            // 
            this.AuthorEmail.AutoSize = true;
            this.AuthorEmail.Location = new System.Drawing.Point(29, 193);
            this.AuthorEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AuthorEmail.Name = "AuthorEmail";
            this.AuthorEmail.Size = new System.Drawing.Size(42, 17);
            this.AuthorEmail.TabIndex = 3;
            this.AuthorEmail.Text = "Email";
            // 
            // AuthorNameText
            // 
            this.AuthorNameText.Location = new System.Drawing.Point(33, 58);
            this.AuthorNameText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AuthorNameText.MaxLength = 20;
            this.AuthorNameText.Name = "AuthorNameText";
            this.AuthorNameText.Size = new System.Drawing.Size(132, 22);
            this.AuthorNameText.TabIndex = 4;
            // 
            // AuthorIDText
            // 
            this.AuthorIDText.Location = new System.Drawing.Point(33, 146);
            this.AuthorIDText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AuthorIDText.MaxLength = 5;
            this.AuthorIDText.Name = "AuthorIDText";
            this.AuthorIDText.Size = new System.Drawing.Size(132, 22);
            this.AuthorIDText.TabIndex = 5;
            // 
            // AuthorEmailText
            // 
            this.AuthorEmailText.Location = new System.Drawing.Point(33, 228);
            this.AuthorEmailText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AuthorEmailText.MaxLength = 25;
            this.AuthorEmailText.Name = "AuthorEmailText";
            this.AuthorEmailText.Size = new System.Drawing.Size(132, 22);
            this.AuthorEmailText.TabIndex = 6;
            // 
            // BackBTN
            // 
            this.BackBTN.Location = new System.Drawing.Point(247, 17);
            this.BackBTN.Name = "BackBTN";
            this.BackBTN.Size = new System.Drawing.Size(120, 36);
            this.BackBTN.TabIndex = 7;
            this.BackBTN.Text = "Admin Controls ";
            this.BackBTN.UseVisualStyleBackColor = true;
            this.BackBTN.Click += new System.EventHandler(this.BackBTN_Click);
            // 
            // AddAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 368);
            this.Controls.Add(this.BackBTN);
            this.Controls.Add(this.AuthorEmailText);
            this.Controls.Add(this.AuthorIDText);
            this.Controls.Add(this.AuthorNameText);
            this.Controls.Add(this.AuthorEmail);
            this.Controls.Add(this.AuthorID);
            this.Controls.Add(this.AuthorName);
            this.Controls.Add(this.AddAuthroButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button BackBTN;
    }
}