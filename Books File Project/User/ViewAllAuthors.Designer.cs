namespace Books_File_Project.User
{
    partial class ViewAllAuthors
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Author_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SortById = new System.Windows.Forms.Button();
            this.SortByName = new System.Windows.Forms.Button();
            this.SortByEmail = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Author_ID,
            this.Author_Name,
            this.Author_Email});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1228, 327);
            this.dataGridView1.TabIndex = 1;
            // 
            // Author_ID
            // 
            this.Author_ID.HeaderText = "Author ID";
            this.Author_ID.Name = "Author_ID";
            this.Author_ID.ReadOnly = true;
            this.Author_ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Author_ID.Width = 225;
            // 
            // Author_Name
            // 
            this.Author_Name.HeaderText = "Author Name";
            this.Author_Name.Name = "Author_Name";
            this.Author_Name.ReadOnly = true;
            this.Author_Name.Width = 300;
            // 
            // Author_Email
            // 
            this.Author_Email.HeaderText = "Author Email";
            this.Author_Email.Name = "Author_Email";
            this.Author_Email.ReadOnly = true;
            this.Author_Email.Width = 350;
            // 
            // SortById
            // 
            this.SortById.Location = new System.Drawing.Point(122, 401);
            this.SortById.Name = "SortById";
            this.SortById.Size = new System.Drawing.Size(260, 60);
            this.SortById.TabIndex = 2;
            this.SortById.Text = "Show Authors Sorted by ID";
            this.SortById.UseVisualStyleBackColor = true;
            this.SortById.Click += new System.EventHandler(this.SortById_Click);
            // 
            // SortByName
            // 
            this.SortByName.Location = new System.Drawing.Point(539, 401);
            this.SortByName.Name = "SortByName";
            this.SortByName.Size = new System.Drawing.Size(260, 60);
            this.SortByName.TabIndex = 3;
            this.SortByName.Text = "Show Authors Sorted by Name";
            this.SortByName.UseVisualStyleBackColor = true;
            this.SortByName.Click += new System.EventHandler(this.SortByName_Click);
            // 
            // SortByEmail
            // 
            this.SortByEmail.Location = new System.Drawing.Point(956, 401);
            this.SortByEmail.Name = "SortByEmail";
            this.SortByEmail.Size = new System.Drawing.Size(260, 60);
            this.SortByEmail.TabIndex = 4;
            this.SortByEmail.Text = "Show Authors Sorted by Email";
            this.SortByEmail.UseVisualStyleBackColor = true;
            this.SortByEmail.Click += new System.EventHandler(this.SortByEmail_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(12, 359);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(65, 31);
            this.Back.TabIndex = 5;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // ViewAllAuthors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 491);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.SortByEmail);
            this.Controls.Add(this.SortByName);
            this.Controls.Add(this.SortById);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewAllAuthors";
            this.Text = "ViewAllAuthors";
            this.Load += new System.EventHandler(this.ViewAllAuthors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author_Email;
        private System.Windows.Forms.Button SortById;
        private System.Windows.Forms.Button SortByName;
        private System.Windows.Forms.Button SortByEmail;
        private System.Windows.Forms.Button Back;
    }
}