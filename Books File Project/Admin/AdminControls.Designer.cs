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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminControls));
            this.bookadd = new System.Windows.Forms.PictureBox();
            this.authoradd = new System.Windows.Forms.PictureBox();
            this.adminadd = new System.Windows.Forms.PictureBox();
            this.adminremove = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bookadd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authoradd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminadd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminremove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bookadd
            // 
            this.bookadd.Image = ((System.Drawing.Image)(resources.GetObject("bookadd.Image")));
            this.bookadd.Location = new System.Drawing.Point(341, 53);
            this.bookadd.Name = "bookadd";
            this.bookadd.Size = new System.Drawing.Size(100, 100);
            this.bookadd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bookadd.TabIndex = 5;
            this.bookadd.TabStop = false;
            this.bookadd.Click += new System.EventHandler(this.bookadd_Click);
            // 
            // authoradd
            // 
            this.authoradd.Image = ((System.Drawing.Image)(resources.GetObject("authoradd.Image")));
            this.authoradd.Location = new System.Drawing.Point(341, 196);
            this.authoradd.Name = "authoradd";
            this.authoradd.Size = new System.Drawing.Size(100, 100);
            this.authoradd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.authoradd.TabIndex = 6;
            this.authoradd.TabStop = false;
            this.authoradd.Click += new System.EventHandler(this.authoradd_Click);
            // 
            // adminadd
            // 
            this.adminadd.Image = ((System.Drawing.Image)(resources.GetObject("adminadd.Image")));
            this.adminadd.Location = new System.Drawing.Point(341, 344);
            this.adminadd.Name = "adminadd";
            this.adminadd.Size = new System.Drawing.Size(100, 100);
            this.adminadd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.adminadd.TabIndex = 7;
            this.adminadd.TabStop = false;
            this.adminadd.Click += new System.EventHandler(this.adminadd_Click);
            // 
            // adminremove
            // 
            this.adminremove.Image = ((System.Drawing.Image)(resources.GetObject("adminremove.Image")));
            this.adminremove.Location = new System.Drawing.Point(341, 493);
            this.adminremove.Name = "adminremove";
            this.adminremove.Size = new System.Drawing.Size(100, 100);
            this.adminremove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.adminremove.TabIndex = 8;
            this.adminremove.TabStop = false;
            this.adminremove.Click += new System.EventHandler(this.adminremove_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AdminControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(796, 638);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.adminremove);
            this.Controls.Add(this.adminadd);
            this.Controls.Add(this.authoradd);
            this.Controls.Add(this.bookadd);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdminControls";
            this.Text = "AdminControls";
            ((System.ComponentModel.ISupportInitialize)(this.bookadd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authoradd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminadd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminremove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox bookadd;
        private System.Windows.Forms.PictureBox authoradd;
        private System.Windows.Forms.PictureBox adminadd;
        private System.Windows.Forms.PictureBox adminremove;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}