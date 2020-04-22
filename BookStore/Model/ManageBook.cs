using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.Model
{
    class ManageBook
    {
        
        public bool AddToCart(int bookid)
        {
            Cart cart = new Cart();
            cart.BookId = bookid;
            cart.UserId = Global.Id;
            if(bookid <= 0)
            {
                MessageBox.Show("Please select a Book");

            }
            try
            {
                int n;
                SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BookStoreDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                string cmdText = "Insert into [Cart] (BookId, UserId) values(@BookId, @UserId);";
                SqlCommand cmd = new SqlCommand(cmdText, con);
                cmd.Parameters.AddWithValue("@BookId", cart.BookId);
                cmd.Parameters.AddWithValue("@UserId", cart.UserId);
                using (con)
                {
                    con.Open();
                    n = cmd.ExecuteNonQuery();
                }
                if (n > 0)
                {
                    MessageBox.Show("Added To Cart");
                    
                }
                else
                    MessageBox.Show("Updation Failed");


                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }



        }

        public DataTable ShowBooksInCart()
        {
                Cart cart = new Cart();
                cart.UserId = Global.Id;
                SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BookStoreDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                string cmdText = "Select [t0].[Id], [t0].[Name], [t0].[Price], [t0].[Author], [t0].[Genre], [t0].[CoverPage] from [Book] as [t0] INNER JOIN [Cart] as [t1] ON ([t0].[Id] = [t1].[BookId] AND [t1].[UserId] = @UserId);";
                SqlCommand cmd = new SqlCommand(cmdText, con);
                cmd.Parameters.AddWithValue("@UserId", cart.UserId);

                DataTable dt = new DataTable();
                using (con)
                {
                    con.Open();
                    SqlDataReader rd = cmd.ExecuteReader();
                    dt.Load(rd);
                }
                
                return dt;
        }

        public DataTable ShowPurchasedBook()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BookStoreDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            string cmdText = "Select [t0].[Id], [t0].[Name], [t0].[Price], [t0].[Author], [t0].[Genre], [t0].[CoverPage] from [Book] as [t0] INNER JOIN [Purchases] as [t1] ON ([t0].[Id] = [t1].[BookId] AND [t1].[UserId] = @UserId);";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            cmd.Parameters.AddWithValue("@UserId", Global.Id);

            DataTable dt = new DataTable();
            using (con)
            {
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
            }

            return dt;
        }

        public void RemoveBook (int bookid)
        {
            if (bookid > 0)
            {
                SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BookStoreDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                string cmdText = "Delete from [Cart] where BookId=@BookId AND UserId=@UserId;";
                SqlCommand cmd = new SqlCommand(cmdText, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@BookId", bookid);
                cmd.Parameters.AddWithValue("@UserId", Global.Id);
                using (con)
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                
            }
            else
            {
                MessageBox.Show("select a book");
            }
            
        }

        

        public void Buy()
        {

            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BookStoreDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            string cmdText = "Insert into [Purchases] (BookId,UserId) select [BookId], [UserId] FROM [Cart] where UserId = @UserId  ;";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            cmd.Parameters.AddWithValue("@UserId", Global.Id);
            using (con)
            {
                con.Open();
                cmd.ExecuteNonQuery();

            }
        }

        public void RemoveFromCart()
        {

            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BookStoreDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            string cmdText = "Delete from [Cart] where UserId = @UserId;";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            cmd.Parameters.AddWithValue("@UserId", Global.Id);
            using (con)
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }


        public DataTable PopulateDataGridView(String search)
        {
            string constr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BookStoreDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            string query = "SELECT * FROM Book";
            query += " WHERE Name LIKE '%' + @ContactName + '%'";
            query += " OR @ContactName = ''";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ContactName", search.Trim());
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        return dt;
                    }
                }
            }
        }
    }
}
