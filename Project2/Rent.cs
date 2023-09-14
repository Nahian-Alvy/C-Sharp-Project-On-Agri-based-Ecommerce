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
    public partial class Rent : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        public Rent()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home f = new Home();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FarmerPage f = new FarmerPage();
            f.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var random = new Random();
            int s = random.Next();

            SqlConnection con = new SqlConnection(cs);
            string query = "insert into Cart2 (Serialno,Item,Qty,Amount) values (@Serialno,@Item,@Qty,@Amount)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Item", "Tractor ");
            cmd.Parameters.AddWithValue("@Qty", "1");
            cmd.Parameters.AddWithValue("@Amount", 4000);
            cmd.Parameters.AddWithValue("@Serialno", s);
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Sold Successfully");

            }
            else
            {
                MessageBox.Show(" Not Sold");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var random = new Random();
            int s = random.Next();

            SqlConnection con = new SqlConnection(cs);
            string query = "insert into Cart2 (Serialno,Item,Qty,Amount) values (@Serialno,@Item,@Qty,@Amount)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Item", "Hooland");
            cmd.Parameters.AddWithValue("@Qty", "1");
            cmd.Parameters.AddWithValue("@Amount", 6000);
            cmd.Parameters.AddWithValue("@Serialno", s);
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Sold Successfully");

            }
            else
            {
                MessageBox.Show(" Not Sold");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var random = new Random();
            int s = random.Next();

            SqlConnection con = new SqlConnection(cs);
            string query = "insert into Cart2 (Serialno,Item,Qty,Amount) values (@Serialno,@Item,@Qty,@Amount)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Item", "Offset disk");
            cmd.Parameters.AddWithValue("@Qty", "1");
            cmd.Parameters.AddWithValue("@Amount", 2000);
            cmd.Parameters.AddWithValue("@Serialno", s);
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Sold Successfully");

            }
            else
            {
                MessageBox.Show(" Not Sold");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var random = new Random();
            int s = random.Next();

            SqlConnection con = new SqlConnection(cs);
            string query = "insert into Cart2 (Serialno,Item,Qty,Amount) values (@Serialno,@Item,@Qty,@Amount)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Item", "Potato Planter ");
            cmd.Parameters.AddWithValue("@Qty", "1");
            cmd.Parameters.AddWithValue("@Amount", 4000);
            cmd.Parameters.AddWithValue("@Serialno", s);
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Sold Successfully");

            }
            else
            {
                MessageBox.Show(" Not Sold");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var random = new Random();
            int s = random.Next();

            SqlConnection con = new SqlConnection(cs);
            string query = "insert into Cart2 (Serialno,Item,Qty,Amount) values (@Serialno,@Item,@Qty,@Amount)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Item", "Rotary Tiller ");
            cmd.Parameters.AddWithValue("@Qty", "1");
            cmd.Parameters.AddWithValue("@Amount", 1500);
            cmd.Parameters.AddWithValue("@Serialno", s);
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Sold Successfully");

            }
            else
            {
                MessageBox.Show(" Not Sold");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var random = new Random();
            int s = random.Next();

            SqlConnection con = new SqlConnection(cs);
            string query = "insert into Cart2 (Serialno,Item,Qty,Amount) values (@Serialno,@Item,@Qty,@Amount)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Item", "The weeder");
            cmd.Parameters.AddWithValue("@Qty", "40 kg");
            cmd.Parameters.AddWithValue("@Amount", 2000);
            cmd.Parameters.AddWithValue("@Serialno", s);
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Sold Successfully");

            }
            else
            {
                MessageBox.Show(" Not Sold");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var random = new Random();
            int s = random.Next();

            SqlConnection con = new SqlConnection(cs);
            string query = "insert into Cart2 (Serialno,Item,Qty,Amount) values (@Serialno,@Item,@Qty,@Amount)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Item", "Loaded Tiller");
            cmd.Parameters.AddWithValue("@Qty", "1");
            cmd.Parameters.AddWithValue("@Amount", 1000);
            cmd.Parameters.AddWithValue("@Serialno", s);
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Sold Successfully");

            }
            else
            {
                MessageBox.Show(" Not Sold");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var random = new Random();
            int s = random.Next();

            SqlConnection con = new SqlConnection(cs);
            string query = "insert into Cart2 (Serialno,Item,Qty,Amount) values (@Serialno,@Item,@Qty,@Amount)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Item", "Tructor");
            cmd.Parameters.AddWithValue("@Qty", "1");
            cmd.Parameters.AddWithValue("@Amount", 5000);
            cmd.Parameters.AddWithValue("@Serialno", s);
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Sold Successfully");

            }
            else
            {
                MessageBox.Show(" Not Sold");
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Home f = new Home();
            f.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
