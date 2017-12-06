namespace Books_File_Project.Admin
{
    partial class AdminControls
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
            this.AddBook = new System.Windows.Forms.Button();
            this.AddAuther = new System.Windows.Forms.Button();
            this.AddAdmin = new System.Windows.Forms.Button();
            this.RemoveAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddBook
            // 
            this.AddBook.Location = new System.Drawing.Point(271, 28);
            this.AddBook.Name = "AddBook";
            this.AddBook.Size = new System.Drawing.Size(140, 61);
            this.AddBook.TabIndex = 0;
            this.AddBook.Text = "Add A Book";
            this.AddBook.UseVisualStyleBackColor = true;
            this.AddBook.Click += new System.EventHandler(this.AddBook_Click);
            // 
            // AddAuther
            // 
            this.AddAuther.Location = new System.Drawing.Point(271, 117);
            this.AddAuther.Name = "AddAuther";
            this.AddAuther.Size = new System.Drawing.Size(140, 61);
            this.AddAuther.TabIndex = 1;
            this.AddAuther.Text = "Add An Author";
            this.AddAuther.UseVisualStyleBackColor = true;
            this.AddAuther.Click += new System.EventHandler(this.AddAuther_Click);
            // 
            // AddAdmin
            // 
            this.AddAdmin.Location = new System.Drawing.Point(271, 206);
            this.AddAdmin.Name = "AddAdmin";
            this.AddAdmin.Size = new System.Drawing.Size(140, 61);
            this.AddAdmin.TabIndex = 2;
            this.AddAdmin.Text = "Add An Admin";
            this.AddAdmin.UseVisualStyleBackColor = true;
            this.AddAdmin.Click += new System.EventHandler(this.AddAdmin_Click);
            // 
            // RemoveAdmin
            // 
            this.RemoveAdmin.Location = new System.Drawing.Point(271, 295);
            this.RemoveAdmin.Name = "RemoveAdmin";
            this.RemoveAdmin.Size = new System.Drawing.Size(140, 61);
            this.RemoveAdmin.TabIndex = 3;
            this.RemoveAdmin.Text = "Remove An Admin";
            this.RemoveAdmin.UseVisualStyleBackColor = true;
            this.RemoveAdmin.Click += new System.EventHandler(this.RemoveAdmin_Click);
            // 
            // AdminControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 422);
            this.Controls.Add(this.RemoveAdmin);
            this.Controls.Add(this.AddAdmin);
            this.Controls.Add(this.AddAuther);
            this.Controls.Add(this.AddBook);
            this.Name = "AdminControls";
            this.Text = "AdminControls";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddBook;
        private System.Windows.Forms.Button AddAuther;
        private System.Windows.Forms.Button AddAdmin;
        private System.Windows.Forms.Button RemoveAdmin;
    }
}