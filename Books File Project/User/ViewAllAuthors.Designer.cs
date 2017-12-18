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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Author_ID,
            this.Author_Name,
            this.Author_Email});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1217, 326);
            this.dataGridView1.TabIndex = 1;
            // 
            // Author_ID
            // 
            this.Author_ID.HeaderText = "Author ID";
            this.Author_ID.Name = "Author_ID";
            this.Author_ID.ReadOnly = true;
            this.Author_ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Author_Name
            // 
            this.Author_Name.HeaderText = "Author Name";
            this.Author_Name.Name = "Author_Name";
            this.Author_Name.ReadOnly = true;
            // 
            // Author_Email
            // 
            this.Author_Email.HeaderText = "Author Email";
            this.Author_Email.Name = "Author_Email";
            this.Author_Email.ReadOnly = true;
            // 
            // SortById
            // 
            this.SortById.Location = new System.Drawing.Point(121, 401);
            this.SortById.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.SortByName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.SortByEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SortByEmail.Name = "SortByEmail";
            this.SortByEmail.Size = new System.Drawing.Size(260, 60);
            this.SortByEmail.TabIndex = 4;
            this.SortByEmail.Text = "Show Authors Sorted by Email";
            this.SortByEmail.UseVisualStyleBackColor = true;
            this.SortByEmail.Click += new System.EventHandler(this.SortByEmail_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(23, 426);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // ViewAllAuthors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1217, 491);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.SortByEmail);
            this.Controls.Add(this.SortByName);
            this.Controls.Add(this.SortById);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ViewAllAuthors";
            this.Text = "ViewAllAuthors";
            this.Load += new System.EventHandler(this.ViewAllAuthors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}