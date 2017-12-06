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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAllAuthors));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Author_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SortById = new System.Windows.Forms.Button();
            this.SortByName = new System.Windows.Forms.Button();
            this.SortByEmail = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(14, 14);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1382, 388);
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
            this.SortById.Location = new System.Drawing.Point(137, 476);
            this.SortById.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SortById.Name = "SortById";
            this.SortById.Size = new System.Drawing.Size(292, 71);
            this.SortById.TabIndex = 2;
            this.SortById.Text = "Show Authors Sorted by ID";
            this.SortById.UseVisualStyleBackColor = true;
            this.SortById.Click += new System.EventHandler(this.SortById_Click);
            // 
            // SortByName
            // 
            this.SortByName.Location = new System.Drawing.Point(606, 476);
            this.SortByName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SortByName.Name = "SortByName";
            this.SortByName.Size = new System.Drawing.Size(292, 71);
            this.SortByName.TabIndex = 3;
            this.SortByName.Text = "Show Authors Sorted by Name";
            this.SortByName.UseVisualStyleBackColor = true;
            this.SortByName.Click += new System.EventHandler(this.SortByName_Click);
            // 
            // SortByEmail
            // 
            this.SortByEmail.Location = new System.Drawing.Point(1076, 476);
            this.SortByEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SortByEmail.Name = "SortByEmail";
            this.SortByEmail.Size = new System.Drawing.Size(292, 71);
            this.SortByEmail.TabIndex = 4;
            this.SortByEmail.Text = "Show Authors Sorted by Email";
            this.SortByEmail.UseVisualStyleBackColor = true;
            this.SortByEmail.Click += new System.EventHandler(this.SortByEmail_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(14, 426);
            this.Back.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(73, 37);
            this.Back.TabIndex = 5;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 495);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ViewAllAuthors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 583);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.SortByEmail);
            this.Controls.Add(this.SortByName);
            this.Controls.Add(this.SortById);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ViewAllAuthors";
            this.Text = "ViewAllAuthors";
            this.Load += new System.EventHandler(this.ViewAllAuthors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}