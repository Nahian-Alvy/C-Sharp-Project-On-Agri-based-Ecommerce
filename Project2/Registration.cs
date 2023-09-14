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

namespace Project2
{
    public partial class Registration : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        public Registration()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private byte[] SavePhoto()
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            return ms.GetBuffer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login f = new login();
            f.Show();
            this.Hide();
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into version1_database (username,password,retypepassword,email,dob,address,picture) values (@username,@password,@retypepassword,@email,@dob,@address,@picture)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", textBox1.Text);
            cmd.Parameters.AddWithValue("@password", textBox3.Text);
            cmd.Parameters.AddWithValue("@retypepassword", textBox4.Text);
            cmd.Parameters.AddWithValue("@email", textBox5.Text);
            cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@address", textBox7.Text);
            cmd.Parameters.AddWithValue("@picture", SavePhoto());

            con.Open();
            int a = cmd.ExecuteNonQuery();
            con.Close();
           
            if (a > 0)
            {
                MessageBox.Show("Registered Successfully");
                
               
            }
            else
            {
                MessageBox.Show("Registration Failed");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Image";
            //ofd.Filter = "PNG FILE (*.PNG) | *.PNG";
            ofd.Filter = "ALL IMAGE FILE (*.*) | *.*";
            //ofd.ShowDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(ofd.FileName);
            }
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox3.UseSystemPasswordChar = true;
                textBox4.UseSystemPasswordChar = true;
            }
            else if (checkBox1.Checked == false)
            {
                textBox3.UseSystemPasswordChar = false;
                textBox4.UseSystemPasswordChar = false;
            }
        }
    }
}
