namespace BookStore.View
{
    partial class AdminHome
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Insert = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btninsert = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnbrowse = new System.Windows.Forms.Button();
            this.imagebox = new System.Windows.Forms.PictureBox();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtauthor = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Logout = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.Insert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagebox)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Insert);
            this.tabControl1.Controls.Add(this.Logout);
            this.tabControl1.Location = new System.Drawing.Point(-2, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1490, 827);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // Insert
            // 
            this.Insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.Insert.Controls.Add(this.button2);
            this.Insert.Controls.Add(this.button1);
            this.Insert.Controls.Add(this.btninsert);
            this.Insert.Controls.Add(this.dataGridView1);
            this.Insert.Controls.Add(this.btnbrowse);
            this.Insert.Controls.Add(this.imagebox);
            this.Insert.Controls.Add(this.txtdesc);
            this.Insert.Controls.Add(this.txtprice);
            this.Insert.Controls.Add(this.txtauthor);
            this.Insert.Controls.Add(this.txtname);
            this.Insert.Controls.Add(this.label5);
            this.Insert.Controls.Add(this.label4);
            this.Insert.Controls.Add(this.label3);
            this.Insert.Controls.Add(this.label2);
            this.Insert.Controls.Add(this.label1);
            this.Insert.Location = new System.Drawing.Point(4, 30);
            this.Insert.Margin = new System.Windows.Forms.Padding(5);
            this.Insert.Name = "Insert";
            this.Insert.Padding = new System.Windows.Forms.Padding(5);
            this.Insert.Size = new System.Drawing.Size(1482, 793);
            this.Insert.TabIndex = 0;
            this.Insert.Text = "Books";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(423, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 35);
            this.button2.TabIndex = 15;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(732, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 35);
            this.button1.TabIndex = 14;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(148, 213);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(96, 35);
            this.btninsert.TabIndex = 13;
            this.btninsert.Text = "Insert";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.Location = new System.Drawing.Point(0, 254);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(920, 350);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnbrowse
            // 
            this.btnbrowse.Location = new System.Drawing.Point(563, 132);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(96, 39);
            this.btnbrowse.TabIndex = 11;
            this.btnbrowse.Text = "Browse";
            this.btnbrowse.UseVisualStyleBackColor = true;
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click);
            // 
            // imagebox
            // 
            this.imagebox.Location = new System.Drawing.Point(436, 110);
            this.imagebox.Name = "imagebox";
            this.imagebox.Size = new System.Drawing.Size(100, 85);
            this.imagebox.TabIndex = 10;
            this.imagebox.TabStop = false;
            this.imagebox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtdesc
            // 
            this.txtdesc.Location = new System.Drawing.Point(573, 78);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(222, 27);
            this.txtdesc.TabIndex = 9;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(573, 27);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(222, 27);
            this.txtprice.TabIndex = 7;
            // 
            // txtauthor
            // 
            this.txtauthor.Location = new System.Drawing.Point(191, 78);
            this.txtauthor.Name = "txtauthor";
            this.txtauthor.Size = new System.Drawing.Size(222, 27);
            this.txtauthor.TabIndex = 6;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(191, 30);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(222, 27);
            this.txtname.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(51)))));
            this.label5.Location = new System.Drawing.Point(93, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Author : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(51)))));
            this.label4.Location = new System.Drawing.Point(498, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(51)))));
            this.label3.Location = new System.Drawing.Point(496, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Genre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(51)))));
            this.label2.Location = new System.Drawing.Point(308, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cover Image :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(78, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Name :";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(4, 30);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(1482, 793);
            this.Logout.TabIndex = 1;
            this.Logout.Text = "LogOut";
            this.Logout.UseVisualStyleBackColor = true;
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 631);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AdminHome";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.AdminHome_Load);
            this.tabControl1.ResumeLayout(false);
            this.Insert.ResumeLayout(false);
            this.Insert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Insert;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtauthor;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Button btnbrowse;
        private System.Windows.Forms.PictureBox imagebox;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage Logout;
    }
}