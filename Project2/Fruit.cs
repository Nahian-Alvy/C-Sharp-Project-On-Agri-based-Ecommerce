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
    public partial class Fruit : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        public Fruit()
        {
            InitializeComponent();
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
            cmd.Parameters.AddWithValue("@Item", "Jackfruit ");
            cmd.Parameters.AddWithValue("@Qty", "40 kg");
            cmd.Parameters.AddWithValue("@Amount", 150);
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
            cmd.Parameters.AddWithValue("@Item", "Guava ");
            cmd.Parameters.AddWithValue("@Qty", "40 kg");
            cmd.Parameters.AddWithValue("@Amount", 60);
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
            cmd.Parameters.AddWithValue("@Item", "Promegranate ");
            cmd.Parameters.AddWithValue("@Qty", "40 kg");
            cmd.Parameters.AddWithValue("@Amount", 120);
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
            cmd.Parameters.AddWithValue("@Item", "Pineapple");
            cmd.Parameters.AddWithValue("@Qty", "40 kg");
            cmd.Parameters.AddWithValue("@Amount", 50);
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
            cmd.Parameters.AddWithValue("@Item", "Mango");
            cmd.Parameters.AddWithValue("@Qty", "40 kg");
            cmd.Parameters.AddWithValue("@Amount", 60);
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
            cmd.Parameters.AddWithValue("@Item", "Licchi");
            cmd.Parameters.AddWithValue("@Qty", "40 kg");
            cmd.Parameters.AddWithValue("@Amount", 350);
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
            cmd.Parameters.AddWithValue("@Item", "Banana");
            cmd.Parameters.AddWithValue("@Qty", "40 Dozons");
            cmd.Parameters.AddWithValue("@Amount", 50);
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
            cmd.Parameters.AddWithValue("@Item", "Dragon");
            cmd.Parameters.AddWithValue("@Qty", "40 kg");
            cmd.Parameters.AddWithValue("@Amount", 250);
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
