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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
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
            this.admin.Image = global::Books_File_Project.Properties.Resources.admin_with_cogwheels_before;
            this.admin.Location = new System.Drawing.Point(786, 38);
            this.admin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(47, 52);
            this.admin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.admin.TabIndex = 9;
            this.admin.TabStop = false;
            this.toolTip1.SetToolTip(this.admin, "Sign In As Admin");
            this.admin.Click += new System.EventHandler(this.admin_Click);
            this.admin.MouseLeave += new System.EventHandler(this.admin_MouseLeave);
            this.admin.MouseHover += new System.EventHandler(this.admin_MouseHover);
            // 
            // name
            // 
            this.name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.name.Image = ((System.Drawing.Image)(resources.GetObject("name.Image")));
            this.name.Location = new System.Drawing.Point(475, 554);
            this.name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(201, 209);
            this.name.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.name.TabIndex = 8;
            this.name.TabStop = false;
            this.name.Click += new System.EventHandler(this.name_Click);
            this.name.MouseLeave += new System.EventHandler(this.name_MouseLeave);
            this.name.MouseHover += new System.EventHandler(this.name_MouseHover);
            // 
            // calender
            // 
            this.calender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.calender.Image = global::Books_File_Project.Properties.Resources.calendar__2_;
            this.calender.Location = new System.Drawing.Point(205, 554);
            this.calender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calender.Name = "calender";
            this.calender.Size = new System.Drawing.Size(201, 209);
            this.calender.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.calender.TabIndex = 6;
            this.calender.TabStop = false;
            this.calender.Click += new System.EventHandler(this.calender_Click);
            this.calender.MouseLeave += new System.EventHandler(this.calender_MouseLeave);
            this.calender.MouseHover += new System.EventHandler(this.calender_MouseHover);
            // 
            // shakes
            // 
            this.shakes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.shakes.Image = ((System.Drawing.Image)(resources.GetObject("shakes.Image")));
            this.shakes.Location = new System.Drawing.Point(475, 301);
            this.shakes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.shakes.Name = "shakes";
            this.shakes.Size = new System.Drawing.Size(201, 209);
            this.shakes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.shakes.TabIndex = 5;
            this.shakes.TabStop = false;
            this.shakes.Click += new System.EventHandler(this.shakes_Click);
            this.shakes.MouseLeave += new System.EventHandler(this.shakes_MouseLeave);
            this.shakes.MouseHover += new System.EventHandler(this.shakes_MouseHover);
            // 
            // books
            // 
            this.books.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.books.Image = global::Books_File_Project.Properties.Resources.books;
            this.books.Location = new System.Drawing.Point(205, 301);
            this.books.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.books.Name = "books";
            this.books.Size = new System.Drawing.Size(201, 209);
            this.books.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.books.TabIndex = 4;
            this.books.TabStop = false;
            this.books.Click += new System.EventHandler(this.books_Click);
            this.books.MouseLeave += new System.EventHandler(this.books_MouseLeave_1);
            this.books.MouseHover += new System.EventHandler(this.books_MouseHover);
            // 
            // UserWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(878, 1034);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.name);
            this.Controls.Add(this.calender);
            this.Controls.Add(this.shakes);
            this.Controls.Add(this.books);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserWelcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserWelcome";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UserWelcome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.admin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shakes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.books)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.PictureBox books;
        private System.Windows.Forms.PictureBox shakes;
        private System.Windows.Forms.PictureBox calender;
        private System.Windows.Forms.PictureBox name;
        private System.Windows.Forms.PictureBox admin;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}