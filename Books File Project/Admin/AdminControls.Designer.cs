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
            this.SuspendLayout();
            // 
            // AddBook
            // 
            this.AddBook.Location = new System.Drawing.Point(290, 70);
            this.AddBook.Name = "AddBook";
            this.AddBook.Size = new System.Drawing.Size(140, 61);
            this.AddBook.TabIndex = 0;
            this.AddBook.Text = "Add A Book";
            this.AddBook.UseVisualStyleBackColor = true;
            // 
            // AddAuther
            // 
            this.AddAuther.Location = new System.Drawing.Point(290, 169);
            this.AddAuther.Name = "AddAuther";
            this.AddAuther.Size = new System.Drawing.Size(140, 61);
            this.AddAuther.TabIndex = 1;
            this.AddAuther.Text = "Add An Auther";
            this.AddAuther.UseVisualStyleBackColor = true;
            this.AddAuther.Click += new System.EventHandler(this.button2_Click);
            // 
            // AdminControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 422);
            this.Controls.Add(this.AddAuther);
            this.Controls.Add(this.AddBook);
            this.Name = "AdminControls";
            this.Text = "AdminControls";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddBook;
        private System.Windows.Forms.Button AddAuther;
    }
}