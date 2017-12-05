namespace Books_File_Project.User
{
    partial class UserWelcome
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
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.VIewAllBooks = new System.Windows.Forms.Button();
            this.ViewAllAuthors = new System.Windows.Forms.Button();
            this.ViewBooksInYear = new System.Windows.Forms.Button();
            this.AdminSign = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // VIewAllBooks
            // 
            this.VIewAllBooks.Location = new System.Drawing.Point(333, 65);
            this.VIewAllBooks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.VIewAllBooks.Name = "VIewAllBooks";
            this.VIewAllBooks.Size = new System.Drawing.Size(114, 80);
            this.VIewAllBooks.TabIndex = 0;
            this.VIewAllBooks.Text = "View All Books";
            this.VIewAllBooks.UseVisualStyleBackColor = true;
            this.VIewAllBooks.Click += new System.EventHandler(this.VIewAllBooks_Click);
            // 
            // ViewAllAuthors
            // 
            this.ViewAllAuthors.Location = new System.Drawing.Point(333, 184);
            this.ViewAllAuthors.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ViewAllAuthors.Name = "ViewAllAuthors";
            this.ViewAllAuthors.Size = new System.Drawing.Size(114, 80);
            this.ViewAllAuthors.TabIndex = 1;
            this.ViewAllAuthors.Text = "View All Authors";
            this.ViewAllAuthors.UseVisualStyleBackColor = true;
            this.ViewAllAuthors.Click += new System.EventHandler(this.ViewAllAuthors_Click);
            // 
            // ViewBooksInYear
            // 
            this.ViewBooksInYear.Location = new System.Drawing.Point(333, 337);
            this.ViewBooksInYear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ViewBooksInYear.Name = "ViewBooksInYear";
            this.ViewBooksInYear.Size = new System.Drawing.Size(114, 80);
            this.ViewBooksInYear.TabIndex = 2;
            this.ViewBooksInYear.Text = "View Books In  A soecific Year ";
            this.ViewBooksInYear.UseVisualStyleBackColor = true;
            this.ViewBooksInYear.Click += new System.EventHandler(this.ViewBooksInYear_Click);
            // 
            // AdminSign
            // 
            this.AdminSign.AutoSize = true;
            this.AdminSign.Location = new System.Drawing.Point(602, 36);
            this.AdminSign.Name = "AdminSign";
            this.AdminSign.Size = new System.Drawing.Size(167, 19);
            this.AdminSign.TabIndex = 3;
            this.AdminSign.Text = "Sign In as an Admin ?";
            this.AdminSign.Click += new System.EventHandler(this.AdminSign_Click);
            // 
            // UserWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 577);
            this.Controls.Add(this.AdminSign);
            this.Controls.Add(this.ViewBooksInYear);
            this.Controls.Add(this.ViewAllAuthors);
            this.Controls.Add(this.VIewAllBooks);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UserWelcome";
            this.Text = "UserWelcome";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button VIewAllBooks;
        private System.Windows.Forms.Button ViewAllAuthors;
        private System.Windows.Forms.Button ViewBooksInYear;
        private System.Windows.Forms.Label AdminSign;
    }
}