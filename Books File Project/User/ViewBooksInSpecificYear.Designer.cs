namespace Books_File_Project.User
{
    partial class ViewBooksInSpecificYear
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
            this.label1 = new System.Windows.Forms.Label();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.DisplayBooks = new System.Windows.Forms.VScrollBar();
            this.EnterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 77);
            this.label1.MaximumSize = new System.Drawing.Size(200, 200);
            this.label1.MinimumSize = new System.Drawing.Size(120, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Publish Year";
            // 
            // YearTextBox
            // 
            this.YearTextBox.Location = new System.Drawing.Point(257, 73);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(258, 27);
            this.YearTextBox.TabIndex = 1;
            // 
            // DisplayBooks
            // 
            this.DisplayBooks.Location = new System.Drawing.Point(85, 183);
            this.DisplayBooks.Name = "DisplayBooks";
            this.DisplayBooks.Size = new System.Drawing.Size(612, 360);
            this.DisplayBooks.TabIndex = 2;
            this.DisplayBooks.Scroll += new System.Windows.Forms.ScrollEventHandler(this.DisplayBooks_Scroll);
            // 
            // EnterButton
            // 
            this.EnterButton.Location = new System.Drawing.Point(406, 117);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(108, 34);
            this.EnterButton.TabIndex = 3;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // ViewBooksInSpecificYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 577);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.DisplayBooks);
            this.Controls.Add(this.YearTextBox);
            this.Controls.Add(this.label1);
            this.Name = "ViewBooksInSpecificYear";
            this.Text = "ViewBooksInSpecificYear";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox YearTextBox;
        private System.Windows.Forms.VScrollBar DisplayBooks;
        private System.Windows.Forms.Button EnterButton;
    }
}