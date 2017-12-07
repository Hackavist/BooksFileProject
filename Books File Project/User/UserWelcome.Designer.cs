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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserWelcome));
            this.admin = new System.Windows.Forms.PictureBox();
            this.name = new System.Windows.Forms.PictureBox();
            this.calender = new System.Windows.Forms.PictureBox();
            this.shakes = new System.Windows.Forms.PictureBox();
            this.books = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.viewbooksinaspecificyear = new System.Windows.Forms.Label();
            this.viewbooksbyaspecificauthor = new System.Windows.Forms.Label();
            this.viewallauthors = new System.Windows.Forms.Label();
            this.viewallbooks = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.admin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shakes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.books)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // admin
            // 
            this.admin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.admin.Image = global::Books_File_Project.Properties.Resources.admin_with_cogwheels;
            this.admin.Location = new System.Drawing.Point(555, 24);
            this.admin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(33, 34);
            this.admin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.admin.TabIndex = 9;
            this.admin.TabStop = false;
            this.admin.Click += new System.EventHandler(this.admin_Click);
            // 
            // name
            // 
            this.name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.name.Image = ((System.Drawing.Image)(resources.GetObject("name.Image")));
            this.name.Location = new System.Drawing.Point(332, 236);
            this.name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(134, 136);
            this.name.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.name.TabIndex = 8;
            this.name.TabStop = false;
            this.name.Click += new System.EventHandler(this.name_Click);
            this.name.MouseHover += new System.EventHandler(this.name_MouseHover);
            // 
            // calender
            // 
            this.calender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.calender.Image = global::Books_File_Project.Properties.Resources.calendar__2_;
            this.calender.Location = new System.Drawing.Point(152, 236);
            this.calender.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.calender.Name = "calender";
            this.calender.Size = new System.Drawing.Size(134, 136);
            this.calender.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.calender.TabIndex = 6;
            this.calender.TabStop = false;
            this.calender.Click += new System.EventHandler(this.calendar_Click);
            this.calender.MouseHover += new System.EventHandler(this.calender_MouseHover);
            // 
            // shakes
            // 
            this.shakes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.shakes.Image = ((System.Drawing.Image)(resources.GetObject("shakes.Image")));
            this.shakes.Location = new System.Drawing.Point(332, 71);
            this.shakes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.shakes.Name = "shakes";
            this.shakes.Size = new System.Drawing.Size(134, 136);
            this.shakes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.shakes.TabIndex = 5;
            this.shakes.TabStop = false;
            this.shakes.Click += new System.EventHandler(this.shakes_Click);
            this.shakes.MouseHover += new System.EventHandler(this.shakes_MouseHover);
            // 
            // books
            // 
            this.books.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.books.Image = global::Books_File_Project.Properties.Resources.books;
            this.books.Location = new System.Drawing.Point(152, 71);
            this.books.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.books.Name = "books";
            this.books.Size = new System.Drawing.Size(134, 136);
            this.books.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.books.TabIndex = 4;
            this.books.TabStop = false;
            this.books.Click += new System.EventHandler(this.books_Click);
            this.books.MouseLeave += new System.EventHandler(this.books_MouseLeave_1);
            this.books.MouseHover += new System.EventHandler(this.books_MouseHover);
            // 
            // viewbooksinaspecificyear
            // 
            this.viewbooksinaspecificyear.AutoSize = true;
            this.viewbooksinaspecificyear.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.viewbooksinaspecificyear.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewbooksinaspecificyear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.viewbooksinaspecificyear.Location = new System.Drawing.Point(153, 236);
            this.viewbooksinaspecificyear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.viewbooksinaspecificyear.MaximumSize = new System.Drawing.Size(134, 136);
            this.viewbooksinaspecificyear.MinimumSize = new System.Drawing.Size(134, 136);
            this.viewbooksinaspecificyear.Name = "viewbooksinaspecificyear";
            this.viewbooksinaspecificyear.Size = new System.Drawing.Size(134, 136);
            this.viewbooksinaspecificyear.TabIndex = 15;
            this.viewbooksinaspecificyear.Text = "View Books In A Specific Year";
            this.viewbooksinaspecificyear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.viewbooksinaspecificyear.Visible = false;
            // 
            // viewbooksbyaspecificauthor
            // 
            this.viewbooksbyaspecificauthor.AutoSize = true;
            this.viewbooksbyaspecificauthor.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.viewbooksbyaspecificauthor.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewbooksbyaspecificauthor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.viewbooksbyaspecificauthor.Location = new System.Drawing.Point(331, 236);
            this.viewbooksbyaspecificauthor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.viewbooksbyaspecificauthor.MaximumSize = new System.Drawing.Size(134, 136);
            this.viewbooksbyaspecificauthor.MinimumSize = new System.Drawing.Size(134, 136);
            this.viewbooksbyaspecificauthor.Name = "viewbooksbyaspecificauthor";
            this.viewbooksbyaspecificauthor.Size = new System.Drawing.Size(134, 136);
            this.viewbooksbyaspecificauthor.TabIndex = 16;
            this.viewbooksbyaspecificauthor.Text = "View Books By A Specific Author";
            this.viewbooksbyaspecificauthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.viewbooksbyaspecificauthor.Visible = false;
            // 
            // viewallauthors
            // 
            this.viewallauthors.AutoSize = true;
            this.viewallauthors.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.viewallauthors.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewallauthors.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.viewallauthors.Location = new System.Drawing.Point(332, 71);
            this.viewallauthors.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.viewallauthors.MaximumSize = new System.Drawing.Size(134, 136);
            this.viewallauthors.MinimumSize = new System.Drawing.Size(134, 136);
            this.viewallauthors.Name = "viewallauthors";
            this.viewallauthors.Size = new System.Drawing.Size(134, 136);
            this.viewallauthors.TabIndex = 17;
            this.viewallauthors.Text = "View All Authors";
            this.viewallauthors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.viewallauthors.Visible = false;
            this.viewallauthors.Click += new System.EventHandler(this.viewallauthors_Click);
            // 
            // viewallbooks
            // 
            this.viewallbooks.AutoSize = true;
            this.viewallbooks.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.viewallbooks.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewallbooks.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.viewallbooks.Location = new System.Drawing.Point(153, 71);
            this.viewallbooks.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.viewallbooks.MaximumSize = new System.Drawing.Size(134, 136);
            this.viewallbooks.MinimumSize = new System.Drawing.Size(134, 136);
            this.viewallbooks.Name = "viewallbooks";
            this.viewallbooks.Size = new System.Drawing.Size(134, 136);
            this.viewallbooks.TabIndex = 14;
            this.viewallbooks.Text = "View All Books";
            this.viewallbooks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.viewallbooks.Visible = false;
            this.viewallbooks.MouseLeave += new System.EventHandler(this.books_MouseLeave_1);
            // 
            // UserWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(616, 423);
            this.Controls.Add(this.viewallauthors);
            this.Controls.Add(this.viewbooksbyaspecificauthor);
            this.Controls.Add(this.viewbooksinaspecificyear);
            this.Controls.Add(this.viewallbooks);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.name);
            this.Controls.Add(this.calender);
            this.Controls.Add(this.shakes);
            this.Controls.Add(this.books);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserWelcome";
            this.Text = "UserWelcome";
            ((System.ComponentModel.ISupportInitialize)(this.admin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shakes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.books)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.PictureBox books;
        private System.Windows.Forms.PictureBox shakes;
        private System.Windows.Forms.PictureBox calender;
        private System.Windows.Forms.PictureBox name;
        private System.Windows.Forms.PictureBox admin;
        private System.Windows.Forms.Label viewbooksinaspecificyear;
        private System.Windows.Forms.Label viewbooksbyaspecificauthor;
        private System.Windows.Forms.Label viewallauthors;
        private System.Windows.Forms.Label viewallbooks;
    }
}