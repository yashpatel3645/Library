namespace Library
{
    partial class Form2
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
            this.bd = new System.Windows.Forms.Button();
            this.pending = new System.Windows.Forms.Button();
            this.BookD = new System.Windows.Forms.Button();
            this.issue = new System.Windows.Forms.Button();
            this.bookr = new System.Windows.Forms.Button();
            this.addbook = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bd
            // 
            this.bd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bd.Location = new System.Drawing.Point(66, 71);
            this.bd.Name = "bd";
            this.bd.Size = new System.Drawing.Size(150, 48);
            this.bd.TabIndex = 1;
            this.bd.Text = "Books Details";
            this.bd.UseVisualStyleBackColor = true;
            this.bd.Click += new System.EventHandler(this.button1_Click);
            // 
            // pending
            // 
            this.pending.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pending.Location = new System.Drawing.Point(66, 307);
            this.pending.Name = "pending";
            this.pending.Size = new System.Drawing.Size(150, 48);
            this.pending.TabIndex = 5;
            this.pending.Text = "Pending Books";
            this.pending.UseVisualStyleBackColor = true;
            // 
            // BookD
            // 
            this.BookD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookD.Location = new System.Drawing.Point(66, 185);
            this.BookD.Name = "BookD";
            this.BookD.Size = new System.Drawing.Size(150, 48);
            this.BookD.TabIndex = 3;
            this.BookD.Text = "Book Delete";
            this.BookD.UseVisualStyleBackColor = true;
            this.BookD.Click += new System.EventHandler(this.BookD_Click);
            // 
            // issue
            // 
            this.issue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issue.Location = new System.Drawing.Point(339, 185);
            this.issue.Name = "issue";
            this.issue.Size = new System.Drawing.Size(150, 48);
            this.issue.TabIndex = 4;
            this.issue.Text = "Issue New Book";
            this.issue.UseVisualStyleBackColor = true;
            this.issue.Click += new System.EventHandler(this.issue_Click);
            // 
            // bookr
            // 
            this.bookr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookr.Location = new System.Drawing.Point(339, 307);
            this.bookr.Name = "bookr";
            this.bookr.Size = new System.Drawing.Size(150, 48);
            this.bookr.TabIndex = 6;
            this.bookr.Text = "Return Book";
            this.bookr.UseVisualStyleBackColor = true;
            this.bookr.Click += new System.EventHandler(this.bookr_Click);
            // 
            // addbook
            // 
            this.addbook.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbook.Location = new System.Drawing.Point(339, 71);
            this.addbook.Name = "addbook";
            this.addbook.Size = new System.Drawing.Size(150, 48);
            this.addbook.TabIndex = 2;
            this.addbook.Text = "Add New Book";
            this.addbook.UseVisualStyleBackColor = true;
            this.addbook.Click += new System.EventHandler(this.addbook_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(494, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(78, 31);
            this.button7.TabIndex = 7;
            this.button7.Text = "Log Out";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 431);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.issue);
            this.Controls.Add(this.bookr);
            this.Controls.Add(this.addbook);
            this.Controls.Add(this.BookD);
            this.Controls.Add(this.pending);
            this.Controls.Add(this.bd);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bd;
        private System.Windows.Forms.Button pending;
        private System.Windows.Forms.Button BookD;
        private System.Windows.Forms.Button issue;
        private System.Windows.Forms.Button bookr;
        private System.Windows.Forms.Button addbook;
        private System.Windows.Forms.Button button7;
    }
}