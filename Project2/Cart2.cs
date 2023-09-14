using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class Cart2 : Form
    {
        public static Cart2 Current;
        
        string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        public Cart2()
        {
            InitializeComponent();
            Current = this;
            
        }
        void BindGridView()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from Cart";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;

            DataGridViewImageColumn dgv = new DataGridViewImageColumn();



            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.RowTemplate.Height = 60;
        }
        
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Home_Click(object sender, EventArgs e)
        {

        }

        private void UpdateTotal()
        {
            using (SqlConnection connection = new SqlConnection(cs))
            {
                connection.Open();

                string query = "SELECT SUM(Amount) FROM Cart;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        lblTotal.Text = "BDT " + result.ToString();
                    }
                    else
                    {
                        lblTotal.Text = "No data available.";
                    }
                }
            }
        }

        private void Cart2_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(cs))
            {
                connection.Open();

                
                string query = "SELECT * FROM Cart;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        
                        DataTable dataTable = new DataTable();

                        
                        dataAdapter.Fill(dataTable);

                        
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            UpdateTotal();
        }
       
        private void btn_remove_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want to Delete It?", "Delete Item", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(cs))
                {

                    con.Open();

                    string deleteQuery = "DELETE FROM Cart WHERE Serialno = @Serialno";

                    using (SqlCommand cmd = new SqlCommand(deleteQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@Serialno", lblSubTotal.Text);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show(" Deleted Successfully");
                            BindGridView();
                            UpdateTotal();
                            
                        }
                        else
                        {
                            MessageBox.Show("No data found for deletion.");
                        }
                    }
                }
            }

            lblSubTotal.Text = "";
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblSubTotal.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void Home_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btn_reset_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want to Reset It?", "Reset Item", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(cs))
                {

                    con.Open();

                    string deleteQuery = "DELETE FROM Cart";

                    using (SqlCommand cmd = new SqlCommand(deleteQuery, con))
                    {
                       
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show(" reseted Successfully");
                            BindGridView();
                            UpdateTotal();

                        }
                        else
                        {
                            MessageBox.Show("No data found for deletion.");
                        }
                    }
                }
            }
            lblSubTotal.Text = "";
        }
        
        private void button9_Click(object sender, EventArgs e)
        {

            Payment payment = new Payment();
            Payment.Current.lbl.Text = lblTotal.Text;
            payment.Show();
            
            //Payment.Current.lbl.Text = lblTotal.Text;
           
            //Bkash.Current.txt.Text = lblTotal.Text;
            this.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Customerhome f = new Customerhome();
            f.Show();
            this.Hide();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
