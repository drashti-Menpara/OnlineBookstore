namespace BookStore.View
{
    partial class CustomerHome
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
            this.Cart = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Buy = new System.Windows.Forms.Button();
            this.Rmbook = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ShowBook = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Purchase = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.Logout = new System.Windows.Forms.TabPage();
            this.Cart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.ShowBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Purchase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // Cart
            // 
            this.Cart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.Cart.Controls.Add(this.label3);
            this.Cart.Controls.Add(this.label2);
            this.Cart.Controls.Add(this.Buy);
            this.Cart.Controls.Add(this.Rmbook);
            this.Cart.Controls.Add(this.dataGridView2);
            this.Cart.Location = new System.Drawing.Point(4, 32);
            this.Cart.Name = "Cart";
            this.Cart.Size = new System.Drawing.Size(885, 466);
            this.Cart.TabIndex = 2;
            this.Cart.Text = "Cart";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(51)))));
            this.label3.Location = new System.Drawing.Point(478, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 23);
            this.label3.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(51)))));
            this.label2.Location = new System.Drawing.Point(289, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total ammount :";
            // 
            // Buy
            // 
            this.Buy.Location = new System.Drawing.Point(535, 406);
            this.Buy.Name = "Buy";
            this.Buy.Size = new System.Drawing.Size(108, 35);
            this.Buy.TabIndex = 2;
            this.Buy.Text = "Buy";
            this.Buy.UseVisualStyleBackColor = true;
            this.Buy.Click += new System.EventHandler(this.Buy_Click);
            // 
            // Rmbook
            // 
            this.Rmbook.Location = new System.Drawing.Point(149, 406);
            this.Rmbook.Name = "Rmbook";
            this.Rmbook.Size = new System.Drawing.Size(177, 35);
            this.Rmbook.TabIndex = 1;
            this.Rmbook.Text = "Remove Book";
            this.Rmbook.UseVisualStyleBackColor = true;
            this.Rmbook.Click += new System.EventHandler(this.Rmbook_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeight = 40;
            this.dataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridView2.Location = new System.Drawing.Point(0, 55);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(885, 267);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // ShowBook
            // 
            this.ShowBook.AutoScroll = true;
            this.ShowBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.ShowBook.Controls.Add(this.button1);
            this.ShowBook.Controls.Add(this.dataGridView1);
            this.ShowBook.Controls.Add(this.txtName);
            this.ShowBook.Controls.Add(this.label1);
            this.ShowBook.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ShowBook.Location = new System.Drawing.Point(4, 32);
            this.ShowBook.Name = "ShowBook";
            this.ShowBook.Padding = new System.Windows.Forms.Padding(3);
            this.ShowBook.Size = new System.Drawing.Size(885, 466);
            this.ShowBook.TabIndex = 1;
            this.ShowBook.Text = "View Books";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(375, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add to Cart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeight = 25;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.dataGridView1.Location = new System.Drawing.Point(-1, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(883, 341);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(288, 18);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(378, 27);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyUp_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(214, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ShowBook);
            this.tabControl1.Controls.Add(this.Cart);
            this.tabControl1.Controls.Add(this.Purchase);
            this.tabControl1.Controls.Add(this.Logout);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.tabControl1.Location = new System.Drawing.Point(-1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(893, 502);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // Purchase
            // 
            this.Purchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.Purchase.Controls.Add(this.dataGridView3);
            this.Purchase.Controls.Add(this.label4);
            this.Purchase.Location = new System.Drawing.Point(4, 32);
            this.Purchase.Name = "Purchase";
            this.Purchase.Size = new System.Drawing.Size(885, 466);
            this.Purchase.TabIndex = 3;
            this.Purchase.Text = "History";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView3.ColumnHeadersHeight = 40;
            this.dataGridView3.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridView3.Location = new System.Drawing.Point(0, 99);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(885, 367);
            this.dataGridView3.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(51)))));
            this.label4.Location = new System.Drawing.Point(9, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(290, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Books You Have Purchased :";
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(4, 32);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(885, 466);
            this.Logout.TabIndex = 4;
            this.Logout.Text = "LogOut";
            this.Logout.UseVisualStyleBackColor = true;
            // 
            // CustomerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(890, 549);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "CustomerHome";
            this.Text = "CustomerHome";
            this.Load += new System.EventHandler(this.CustomerHome_Load);
            this.Cart.ResumeLayout(false);
            this.Cart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ShowBook.ResumeLayout(false);
            this.ShowBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Purchase.ResumeLayout(false);
            this.Purchase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage Cart;
        private System.Windows.Forms.TabPage ShowBook;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Purchase;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Buy;
        private System.Windows.Forms.Button Rmbook;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage Logout;
    }
}