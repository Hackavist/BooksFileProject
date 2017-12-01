namespace Books_File_Project.Admin
{
    partial class AddBook
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
            this.Book_Name = new System.Windows.Forms.Label();
            this.Serial_Number = new System.Windows.Forms.Label();
            this.Publish_Year = new System.Windows.Forms.Label();
            this.Author_Id = new System.Windows.Forms.Label();
            this.BookName = new System.Windows.Forms.TextBox();
            this.SerialNumber = new System.Windows.Forms.TextBox();
            this.PublishYear = new System.Windows.Forms.TextBox();
            this.AuthorId = new System.Windows.Forms.TextBox();
            this.AddBookBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Book_Name
            // 
            this.Book_Name.AutoSize = true;
            this.Book_Name.Font = new System.Drawing.Font("Goudy Old Style", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book_Name.Location = new System.Drawing.Point(29, 122);
            this.Book_Name.Name = "Book_Name";
            this.Book_Name.Size = new System.Drawing.Size(183, 39);
            this.Book_Name.TabIndex = 0;
            this.Book_Name.Text = "Book Name";
           
            // 
            // Serial_Number
            // 
            this.Serial_Number.AutoSize = true;
            this.Serial_Number.Font = new System.Drawing.Font("Goudy Old Style", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Serial_Number.Location = new System.Drawing.Point(29, 200);
            this.Serial_Number.Name = "Serial_Number";
            this.Serial_Number.Size = new System.Drawing.Size(220, 39);
            this.Serial_Number.TabIndex = 1;
            this.Serial_Number.Text = "Serial Number";
            
            // 
            // Publish_Year
            // 
            this.Publish_Year.AutoSize = true;
            this.Publish_Year.Font = new System.Drawing.Font("Goudy Old Style", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Publish_Year.Location = new System.Drawing.Point(29, 278);
            this.Publish_Year.Name = "Publish_Year";
            this.Publish_Year.Size = new System.Drawing.Size(194, 39);
            this.Publish_Year.TabIndex = 2;
            this.Publish_Year.Text = "Publish Year";
           
            // 
            // Author_Id
            // 
            this.Author_Id.AutoSize = true;
            this.Author_Id.Font = new System.Drawing.Font("Goudy Old Style", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Author_Id.Location = new System.Drawing.Point(29, 356);
            this.Author_Id.Name = "Author_Id";
            this.Author_Id.Size = new System.Drawing.Size(158, 39);
            this.Author_Id.TabIndex = 3;
            this.Author_Id.Text = "Author Id";
            
            // 
            // BookName
            // 
            this.BookName.Font = new System.Drawing.Font("Goudy Old Style", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookName.Location = new System.Drawing.Point(346, 116);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(323, 48);
            this.BookName.TabIndex = 4;

            // 
            // SerialNumber
            // 
            this.SerialNumber.Font = new System.Drawing.Font("Goudy Old Style", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerialNumber.Location = new System.Drawing.Point(346, 194);
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.Size = new System.Drawing.Size(323, 48);
            this.SerialNumber.TabIndex = 5;

            // 
            // PublishYear
            // 
            this.PublishYear.Font = new System.Drawing.Font("Goudy Old Style", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PublishYear.Location = new System.Drawing.Point(346, 272);
            this.PublishYear.Name = "PublishYear";
            this.PublishYear.Size = new System.Drawing.Size(323, 48);
            this.PublishYear.TabIndex = 6;

            // 
            // AuthorId
            // 
            this.AuthorId.Font = new System.Drawing.Font("Goudy Old Style", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorId.Location = new System.Drawing.Point(346, 350);
            this.AuthorId.Name = "AuthorId";
            this.AuthorId.Size = new System.Drawing.Size(323, 48);
            this.AuthorId.TabIndex = 7;

            // 
            // AddBookBtn
            // 
            this.AddBookBtn.Location = new System.Drawing.Point(237, 445);
            this.AddBookBtn.Name = "AddBookBtn";
            this.AddBookBtn.Size = new System.Drawing.Size(157, 55);
            this.AddBookBtn.TabIndex = 8;
            this.AddBookBtn.Text = "Add Book";
            this.AddBookBtn.UseVisualStyleBackColor = true;
            this.AddBookBtn.Click += new System.EventHandler(this.AddBookBtn_Click);
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 628);
            this.Controls.Add(this.AddBookBtn);
            this.Controls.Add(this.AuthorId);
            this.Controls.Add(this.PublishYear);
            this.Controls.Add(this.SerialNumber);
            this.Controls.Add(this.BookName);
            this.Controls.Add(this.Author_Id);
            this.Controls.Add(this.Publish_Year);
            this.Controls.Add(this.Serial_Number);
            this.Controls.Add(this.Book_Name);
            this.Name = "AddBook";
            this.Text = "AddBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Book_Name;
        private System.Windows.Forms.Label Serial_Number;
        private System.Windows.Forms.Label Publish_Year;
        private System.Windows.Forms.Label Author_Id;
        private System.Windows.Forms.TextBox BookName;
        private System.Windows.Forms.TextBox SerialNumber;
        private System.Windows.Forms.TextBox PublishYear;
        private System.Windows.Forms.TextBox AuthorId;
        private System.Windows.Forms.Button AddBookBtn;
    }
}