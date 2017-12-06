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
            this.admin.Image = global::Books_File_Project.Properties.Resources.admin_with_cogwheels;
            this.admin.Location = new System.Drawing.Point(745, 24);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(50, 50);
            this.admin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.admin.TabIndex = 9;
            this.admin.TabStop = false;
            this.admin.Click += new System.EventHandler(this.admin_Click);
            // 
            // name
            // 
            this.name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.name.Image = ((System.Drawing.Image)(resources.GetObject("name.Image")));
            this.name.Location = new System.Drawing.Point(404, 326);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(183, 194);
            this.name.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.name.TabIndex = 8;
            this.name.TabStop = false;
            this.name.Click += new System.EventHandler(this.name_Click);
            // 
            // calender
            // 
            this.calender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.calender.Image = global::Books_File_Project.Properties.Resources.calendar__2_;
            this.calender.Location = new System.Drawing.Point(135, 326);
            this.calender.Name = "calender";
            this.calender.Size = new System.Drawing.Size(183, 194);
            this.calender.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.calender.TabIndex = 6;
            this.calender.TabStop = false;
            this.calender.Click += new System.EventHandler(this.calendar_Click);
            // 
            // shakes
            // 
            this.shakes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.shakes.Image = ((System.Drawing.Image)(resources.GetObject("shakes.Image")));
            this.shakes.Location = new System.Drawing.Point(404, 83);
            this.shakes.Name = "shakes";
            this.shakes.Size = new System.Drawing.Size(183, 195);
            this.shakes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.shakes.TabIndex = 5;
            this.shakes.TabStop = false;
            this.shakes.Click += new System.EventHandler(this.shakes_Click);
            // 
            // books
            // 
            this.books.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.books.Image = global::Books_File_Project.Properties.Resources.books;
            this.books.Location = new System.Drawing.Point(135, 83);
            this.books.Name = "books";
            this.books.Size = new System.Drawing.Size(183, 195);
            this.books.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.books.TabIndex = 4;
            this.books.TabStop = false;
            this.books.Click += new System.EventHandler(this.books_Click);
            // 
            // UserWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(859, 577);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.name);
            this.Controls.Add(this.calender);
            this.Controls.Add(this.shakes);
            this.Controls.Add(this.books);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UserWelcome";
            this.Text = "UserWelcome";
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
    }
}