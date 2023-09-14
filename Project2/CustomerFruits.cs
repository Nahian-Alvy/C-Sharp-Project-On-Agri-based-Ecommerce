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
    public partial class CustomerFruits : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        public CustomerFruits()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var random = new Random();
            int s = random.Next();

            SqlConnection con = new SqlConnection(cs);
            string query = "insert into Cart (Serialno,Item,Qty,Amount) values (@Serialno,@Item,@Qty,@Amount)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Item", "Jackfruit");
            cmd.Parameters.AddWithValue("@Qty", 1);
            cmd.Parameters.AddWithValue("@Amount", 150);
            cmd.Parameters.AddWithValue("@Serialno", s);
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Data Inserted Successfully");

            }
            else
            {
                MessageBox.Show("Data Not Inserted");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var random = new Random();
            int s = random.Next();

            SqlConnection con = new SqlConnection(cs);
            string query = "insert into Cart (Serialno,Item,Qty,Amount) values (@Serialno,@Item,@Qty,@Amount)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Item", "Guava");
            cmd.Parameters.AddWithValue("@Qty", 1);
            cmd.Parameters.AddWithValue("@Amount", 60);
            cmd.Parameters.AddWithValue("@Serialno", s);
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Data Inserted Successfully");

            }
            else
            {
                MessageBox.Show("Data Not Inserted");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var random = new Random();
            int s = random.Next();

            SqlConnection con = new SqlConnection(cs);
            string query = "insert into Cart (Serialno,Item,Qty,Amount) values (@Serialno,@Item,@Qty,@Amount)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Item", "Promgranate");
            cmd.Parameters.AddWithValue("@Qty", 1);
            cmd.Parameters.AddWithValue("@Amount",120);
            cmd.Parameters.AddWithValue("@Serialno", s);
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Data Inserted Successfully");

            }
            else
            {
                MessageBox.Show("Data Not Inserted");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var random = new Random();
            int s = random.Next();

            SqlConnection con = new SqlConnection(cs);
            string query = "insert into Cart (Serialno,Item,Qty,Amount) values (@Serialno,@Item,@Qty,@Amount)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Item", "Pineappple");
            cmd.Parameters.AddWithValue("@Qty", 1);
            cmd.Parameters.AddWithValue("@Amount", 50);
            cmd.Parameters.AddWithValue("@Serialno", s);
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Data Inserted Successfully");

            }
            else
            {
                MessageBox.Show("Data Not Inserted");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var random = new Random();
            int s = random.Next();

            SqlConnection con = new SqlConnection(cs);
            string query = "insert into Cart (Serialno,Item,Qty,Amount) values (@Serialno,@Item,@Qty,@Amount)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Item", "Mango");
            cmd.Parameters.AddWithValue("@Qty", 1);
            cmd.Parameters.AddWithValue("@Amount", 60);
            cmd.Parameters.AddWithValue("@Serialno", s);
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Data Inserted Successfully");

            }
            else
            {
                MessageBox.Show("Data Not Inserted");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var random = new Random();
            int s = random.Next();

            SqlConnection con = new SqlConnection(cs);
            string query = "insert into Cart (Serialno,Item,Qty,Amount) values (@Serialno,@Item,@Qty,@Amount)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Item", "Lichi");
            cmd.Parameters.AddWithValue("@Qty", 100);
            cmd.Parameters.AddWithValue("@Amount", 350);
            cmd.Parameters.AddWithValue("@Serialno", s);
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Data Inserted Successfully");

            }
            else
            {
                MessageBox.Show("Data Not Inserted");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var random = new Random();
            int s = random.Next();

            SqlConnection con = new SqlConnection(cs);
            string query = "insert into Cart (Serialno,Item,Qty,Amount) values (@Serialno,@Item,@Qty,@Amount)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Item", "Banana");
            cmd.Parameters.AddWithValue("@Qty", 1);
            cmd.Parameters.AddWithValue("@Amount", 50);
            cmd.Parameters.AddWithValue("@Serialno", s);
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Data Inserted Successfully");

            }
            else
            {
                MessageBox.Show("Data Not Inserted");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var random = new Random();
            int s = random.Next();

            SqlConnection con = new SqlConnection(cs);
            string query = "insert into Cart (Serialno,Item,Qty,Amount) values (@Serialno,@Item,@Qty,@Amount)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Item", "Dragon fruit");
            cmd.Parameters.AddWithValue("@Qty", 1);
            cmd.Parameters.AddWithValue("@Amount", 250);
            cmd.Parameters.AddWithValue("@Serialno", s);
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Data Inserted Successfully");

            }
            else
            {
                MessageBox.Show("Data Not Inserted");
            }
        }

        private void CustomerFruits_Load(object sender, EventArgs e)
        {

        }
    }
    }

