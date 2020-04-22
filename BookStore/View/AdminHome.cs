using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.View
{
    public partial class AdminHome : Form
    {

        MemoryStream ms;
        byte[] photo_aray;
        SqlCommand cmd;
        public int bookid;
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BookStoreDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public AdminHome()
        {
            InitializeComponent();

        }
        private void AdminHome_Load(object sender, EventArgs e)
        {
            GetRecord();
        }
        public void GetRecord()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BookStoreDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand("select * from Book", con);
            DataTable dt = new DataTable();
            using (con)
            {
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
            }
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        void image_upload()
        {

            if (imagebox.Image != null)
            {

                ms = new MemoryStream();
                imagebox.Image.Save(ms, ImageFormat.Jpeg);
                photo_aray = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(photo_aray, 0, photo_aray.Length);

            }
        }

        public bool Isvalid()

        {
            if (txtname.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Book name");
                return false;
            }
            if (txtprice.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Book price");
                return false;
            }
            if (txtdesc.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Book Genre");
                return false;
            }
            if (txtauthor.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Book author");
                return false;
            }
            return true;
        }


        private void btnbrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "jpeg|*.jpg|bmp|*.bmp|all files|*.*";
            DialogResult res = openFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                imagebox.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedTab == Logout)
            {

                Index obj = new Index();
                obj.Show();
                this.Hide();
            }
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            string filename = System.IO.Path.GetFileName(openFileDialog1.FileName);
            if (Isvalid())
            {
                SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BookStoreDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

                string cmdText = "Insert into [Book] (Name, Price,Author,Genre,CoverPage) values('" + txtname.Text + "', '" + txtprice.Text + "', '" + txtauthor.Text + "','" + txtdesc.Text + "',@photo)";
                cmd = new SqlCommand(cmdText, con);
                image_upload();
                cmd.Parameters.AddWithValue("@photo", photo_aray);
                con.Open();
                int n = cmd.ExecuteNonQuery();
                con.Close();
                if (n > 0)
                {
                    MessageBox.Show("record inserted");
                    GetRecord();
                }
                else
                    MessageBox.Show("insertion failed");
            }
                Resetcontrol();
            
        }
        private void Resetcontrol()
        {

            txtauthor.Clear();
            txtdesc.Clear();
            txtname.Clear();
            txtprice.Clear();
            txtname.Focus();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bookid = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            txtname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtprice.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtauthor.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtdesc.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

            byte[] img = (byte[])dataGridView1.CurrentRow.Cells[5].Value;
            MemoryStream ms = new MemoryStream(img);
            imagebox.Image = Image.FromStream(ms);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BookStoreDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            if (bookid > 0)
            {
                string filename = System.IO.Path.GetFileName(openFileDialog1.FileName);
                if (Isvalid())
                {
                    string imageurl = "//image//" + filename;
                    string cmdText = "Update Book set Name='" + txtname.Text + "',Price='" + txtprice.Text + "',Author='" + txtauthor.Text + "',Genre='" + txtdesc.Text + "',CoverPage=@photo where Id=@id";

                    SqlCommand cmd = new SqlCommand(cmdText, con);
                    cmd.CommandType = CommandType.Text;

                    image_upload();
                    cmd.Parameters.AddWithValue("@photo", photo_aray);
                    cmd.Parameters.AddWithValue("@id", this.bookid);
                    con.Open();
                    int n = cmd.ExecuteNonQuery();
                    con.Close();
                    if (n > 0)
                    {
                        MessageBox.Show("Record Updated");
                        GetRecord(); Resetcontrol();
                    }
                    else
                        MessageBox.Show("Updation Failed");

                }
            }
            else
            {
                MessageBox.Show("Please select a recod");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bookid > 0)
            {
                string cmdText = "Delete from Book  where Id=@id";
                SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BookStoreDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

                SqlCommand cmd = new SqlCommand(cmdText, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", this.bookid);
                using (con)
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Deleted successfully.");
                }
                GetRecord(); Resetcontrol();
            }
            else
            {
                MessageBox.Show("select a record");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
