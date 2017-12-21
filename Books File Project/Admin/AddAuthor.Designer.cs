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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAuthor));
            this.AuthorName = new System.Windows.Forms.Label();
            this.AuthorID = new System.Windows.Forms.Label();
            this.AuthorEmail = new System.Windows.Forms.Label();
            this.AuthorNameText = new System.Windows.Forms.TextBox();
            this.AuthorIDText = new System.Windows.Forms.TextBox();
            this.AuthorEmailText = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // AuthorName
            // 
            this.AuthorName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AuthorName.AutoSize = true;
            this.AuthorName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorName.ForeColor = System.Drawing.Color.White;
            this.AuthorName.Location = new System.Drawing.Point(108, 151);
            this.AuthorName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.Size = new System.Drawing.Size(69, 27);
            this.AuthorName.TabIndex = 1;
            this.AuthorName.Text = "Name";
            // 
            // AuthorID
            // 
            this.AuthorID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AuthorID.AutoSize = true;
            this.AuthorID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorID.ForeColor = System.Drawing.Color.White;
            this.AuthorID.Location = new System.Drawing.Point(108, 262);
            this.AuthorID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AuthorID.Name = "AuthorID";
            this.AuthorID.Size = new System.Drawing.Size(37, 27);
            this.AuthorID.TabIndex = 2;
            this.AuthorID.Text = "ID";
            // 
            // AuthorEmail
            // 
            this.AuthorEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AuthorEmail.AutoSize = true;
            this.AuthorEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorEmail.ForeColor = System.Drawing.Color.White;
            this.AuthorEmail.Location = new System.Drawing.Point(108, 375);
            this.AuthorEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AuthorEmail.Name = "AuthorEmail";
            this.AuthorEmail.Size = new System.Drawing.Size(68, 27);
            this.AuthorEmail.TabIndex = 3;
            this.AuthorEmail.Text = "Email";
            // 
            // AuthorNameText
            // 
            this.AuthorNameText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AuthorNameText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorNameText.ForeColor = System.Drawing.Color.Black;
            this.AuthorNameText.Location = new System.Drawing.Point(202, 151);
            this.AuthorNameText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AuthorNameText.MaxLength = 20;
            this.AuthorNameText.Name = "AuthorNameText";
            this.AuthorNameText.Size = new System.Drawing.Size(265, 35);
            this.AuthorNameText.TabIndex = 4;
            this.AuthorNameText.TextChanged += new System.EventHandler(this.AuthorNameText_TextChanged);
            // 
            // AuthorIDText
            // 
            this.AuthorIDText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AuthorIDText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorIDText.ForeColor = System.Drawing.Color.Black;
            this.AuthorIDText.Location = new System.Drawing.Point(202, 262);
            this.AuthorIDText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AuthorIDText.MaxLength = 5;
            this.AuthorIDText.Name = "AuthorIDText";
            this.AuthorIDText.Size = new System.Drawing.Size(265, 35);
            this.AuthorIDText.TabIndex = 5;
            // 
            // AuthorEmailText
            // 
            this.AuthorEmailText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AuthorEmailText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorEmailText.ForeColor = System.Drawing.Color.Black;
            this.AuthorEmailText.Location = new System.Drawing.Point(202, 375);
            this.AuthorEmailText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AuthorEmailText.MaxLength = 25;
            this.AuthorEmailText.Name = "AuthorEmailText";
            this.AuthorEmailText.Size = new System.Drawing.Size(265, 35);
            this.AuthorEmailText.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(524, 529);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 105);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(225, 488);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "Click here to add book.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AddAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(664, 662);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AuthorEmailText);
            this.Controls.Add(this.AuthorIDText);
            this.Controls.Add(this.AuthorNameText);
            this.Controls.Add(this.AuthorEmail);
            this.Controls.Add(this.AuthorID);
            this.Controls.Add(this.AuthorName);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddAuthor";
            this.Text = "AddAuthor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddAuthor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label AuthorName;
        private System.Windows.Forms.Label AuthorID;
        private System.Windows.Forms.Label AuthorEmail;
        private System.Windows.Forms.TextBox AuthorNameText;
        private System.Windows.Forms.TextBox AuthorIDText;
        private System.Windows.Forms.TextBox AuthorEmailText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}