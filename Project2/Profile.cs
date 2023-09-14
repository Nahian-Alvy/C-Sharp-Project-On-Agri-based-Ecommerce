using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Project2
{
    public partial class Profile : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        public Profile()
        {
            InitializeComponent();
        }
        public void Insert(string fileName, byte[] image)
        {
            using(SqlConnection con = new SqlConnection(cs))
            {
                if(con.State ==ConnectionState.Closed)
                {
                    con.Open();
                }
                using (SqlCommand cmd = new SqlCommand("insert into version1_database (username,password,retypepassword,email,dob,address) values(@username,@password,@email,@dob,@address,@picture)", con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@username", textBox1.Text);
                    cmd.Parameters.AddWithValue("@password", textBox2.Text);
                    cmd.Parameters.AddWithValue("@email", textBox3.Text);
                    cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@address", textBox5.Text);
                    cmd.Parameters.AddWithValue("@picture", image);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void LoadData()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                using (DataTable dt = new DataTable("version1_database"))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter("Select *from version1_database", con);
                    adapter.Fill(dt);
                    //dataGridView1.DataSource= dt;
                }
            }
        }
       public byte[] ConvertImageToByte(System.Drawing.Image img)
        {
            using(MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        public System.Drawing.Image ConvertByteArrayToImage(byte[] data)
        {
            using(MemoryStream ms = new MemoryStream())
            {
                return System.Drawing.Image.FromStream(ms);
            }
        }
        private void Profile_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectdataDataSet.project_data' table. You can move, or remove it, as needed.
           // this.project_dataTableAdapter.Fill(this.projectdataDataSet.version1_database);
            LoadData();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "image Files( *.jpg;*.jpeg)|*.jpg;*.jpeg",Multiselect=false })
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = System.Drawing.Image.FromFile(ofd.FileName);
                    LoadData();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private byte[] SavePhoto()
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            return ms.GetBuffer();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "update version1_database set username=@username,password=@password,retypepassword=@retypepassword,email=@email,dob=@dob,address=@address,picture=@picture";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", textBox1.Text);
            cmd.Parameters.AddWithValue("@password", textBox2.Text);
            cmd.Parameters.AddWithValue("@retypepassword", textBox6.Text);
            cmd.Parameters.AddWithValue("@email", textBox3.Text);
            cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@address", textBox5.Text);
            cmd.Parameters.AddWithValue("@picture", SavePhoto());

            con.Open();
            int a = cmd.ExecuteNonQuery();
            con.Close();

            if (a > 0)
            {
                MessageBox.Show("Data Updated Successfully");


            }
            else
            {
                MessageBox.Show("Data Not Updated");
            }
            
        }
       /* private void loadimage()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select picture from project_data ";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@picture")
            }
        }*/

        private void button3_Click(object sender, EventArgs e)
        {
            Customerhome c = new Customerhome();
            c.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Cart2 cart = new Cart2();
            cart.Show();
            this.Hide();
        }
    }
}
