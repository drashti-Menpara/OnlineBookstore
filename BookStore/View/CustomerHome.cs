using BookStore.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.View
{
    public partial class CustomerHome : Form
    {
        ManageBook sbook = new ManageBook();
        string search = "";
        public int bookid;
        int sum = 0;
        int tabChanged = 0;
        public CustomerHome()
        {
            InitializeComponent();
        }

        private void CustomerHome_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = sbook.PopulateDataGridView(search);
            dataGridView1.Columns[0].Visible = false;
            //dataGridView1.Columns.Add("cart", "Add to cart");
            


        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedTab == Cart)
            {
               dataGridView2.DataSource = sbook.ShowBooksInCart();
               dataGridView2.Columns[0].Visible = false;
                for (int i = 0; i < dataGridView2.Rows.Count; ++i)
                    {
                        sum += Convert.ToInt32(dataGridView2.Rows[i].Cells[2].Value);
                    }
                    label3.Text = sum.ToString();
                sum = 0;
                
            }
            if(tabControl1.SelectedTab == Purchase)
            {
                dataGridView3.DataSource = sbook.ShowPurchasedBook();
                dataGridView3.Columns[0].Visible = false;

            }
            if(tabControl1.SelectedTab == Logout)
            {
                Index obj = new Index();
                obj.Show();
                this.Hide();
            }

        }

 

        private void txtName_KeyUp_1(object sender, KeyEventArgs e)
        {
            search = txtName.Text.Trim();
            dataGridView1.DataSource = sbook.PopulateDataGridView(search);
            dataGridView1.Columns[0].Visible = false;
            /*if (dataGridView1.Columns.Count == 5)
            {
                dataGridView1.Columns.Add("cart", "Add to cart");
            }*/

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            sbook.AddToCart(bookid);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bookid = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
        }

        private void Rmbook_Click(object sender, EventArgs e)
        {
            sbook.RemoveBook(bookid);
            dataGridView2.DataSource = sbook.ShowBooksInCart();
            dataGridView2.Columns[0].Visible = false;
            for (int i = 0; i < dataGridView2.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView2.Rows[i].Cells[2].Value);
            }
            label3.Text = sum.ToString();
            sum = 0;

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bookid = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value);
        }

        private void Buy_Click(object sender, EventArgs e)
        {
            sbook.Buy();
            sbook.RemoveFromCart();
            this.tabControl1.SelectedTab = this.Purchase;


        }
    }
}
