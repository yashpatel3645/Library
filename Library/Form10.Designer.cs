namespace Library
{
    partial class Form10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bookid = new System.Windows.Forms.TextBox();
            this.student1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentdetailDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.studentdetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.Penalty = new System.Windows.Forms.TextBox();
            this.today = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.returnby = new System.Windows.Forms.ComboBox();
            this.subdate = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.student1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentdetailDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentdetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Return Book";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book ID :";
            // 
            // bookid
            // 
            this.bookid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookid.Location = new System.Drawing.Point(151, 157);
            this.bookid.Name = "bookid";
            this.bookid.Size = new System.Drawing.Size(255, 24);
            this.bookid.TabIndex = 2;
            // 
            // student1BindingSource
            // 
            this.student1BindingSource.DataMember = "student1";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1025, 649);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // studentdetailBindingSource
            // 
            this.studentdetailBindingSource.DataMember = "Studentdetail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(646, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Penalty   :";
            // 
            // Penalty
            // 
            this.Penalty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Penalty.Location = new System.Drawing.Point(731, 154);
            this.Penalty.Name = "Penalty";
            this.Penalty.Size = new System.Drawing.Size(255, 24);
            this.Penalty.TabIndex = 7;
            // 
            // today
            // 
            this.today.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.today.Location = new System.Drawing.Point(414, 485);
            this.today.Name = "today";
            this.today.Size = new System.Drawing.Size(200, 20);
            this.today.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(751, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Return By :";
            // 
            // returnby
            // 
            this.returnby.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnby.FormattingEnabled = true;
            this.returnby.Items.AddRange(new object[] {
            "Student",
            "Faculty"});
            this.returnby.Location = new System.Drawing.Point(846, 76);
            this.returnby.Name = "returnby";
            this.returnby.Size = new System.Drawing.Size(168, 26);
            this.returnby.TabIndex = 11;
            this.returnby.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // subdate
            // 
            this.subdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.subdate.Location = new System.Drawing.Point(506, 450);
            this.subdate.Name = "subdate";
            this.subdate.Size = new System.Drawing.Size(200, 20);
            this.subdate.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(51, 247);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1006, 270);
            this.dataGridView1.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Library.Properties.Resources.white;
            this.button1.Location = new System.Drawing.Point(427, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Library.Properties.Resources.images3NIB6KME;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 768);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.subdate);
            this.Controls.Add(this.returnby);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.today);
            this.Controls.Add(this.Penalty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bookid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form10";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Return Book";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.student1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentdetailDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentdetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bookid;
        private System.Windows.Forms.BindingSource studentdetailDataSetBindingSource;
        private System.Windows.Forms.BindingSource student1BindingSource;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource studentdetailBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Penalty;
        private System.Windows.Forms.DateTimePicker today;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox returnby;
        private System.Windows.Forms.DateTimePicker subdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}