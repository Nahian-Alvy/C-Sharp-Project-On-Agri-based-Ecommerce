using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class Farmercart : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        public Farmercart()
        {
            InitializeComponent();
        }
        void BindGridView()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from Cart2";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;

            DataGridViewImageColumn dgv = new DataGridViewImageColumn();



            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.RowTemplate.Height = 60;
        }
        private void UpdateTotal()
        {
            using (SqlConnection connection = new SqlConnection(cs))
            {
                connection.Open();

                string query = "SELECT SUM(Amount) FROM Cart2;";

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
        private void Farmercart_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(cs))
            {
                connection.Open();


                string query = "SELECT * FROM Cart2;";

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

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want to Delete It?", "Delete Item", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(cs))
                {

                    con.Open();

                    string deleteQuery = "DELETE FROM Cart2 WHERE Serialno = @Serialno";

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

        private void btn_reset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want to Reset It?", "Reset Item", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(cs))
                {

                    con.Open();

                    string deleteQuery = "DELETE FROM Cart2";

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

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Home f = new Home();
            f.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
