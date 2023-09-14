using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Project2
{
    public partial class login : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        public login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            textBox1.Focus();
         
            if (textBox1.Text == "")
            {
                panel7.Visible = true;
            }
            else
            {
                panel7.Visible = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
            textBox2.Focus();
            if (textBox2.Text == ""|| textBox2.Text == "Enter Password")
            {
                panel9.Visible = true;
            }
            else
            {
                panel9.Visible = false;
                
                textBox2.UseSystemPasswordChar= true;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != ""|| textBox1.Text != "Enter UserName" && textBox2.Text != "" || textBox1.Text != "Enter Password")
            {
                if (textBox1.Text == "admin" && textBox2.Text == "admin")
                {
                    MessageBox.Show("Admin Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AdminDashBoard h = new AdminDashBoard();
                    h.Show();
                    this.Close();

                }
                else
                {
                    SqlConnection con = new SqlConnection(cs);
                    string query = "select * from version1_database where username=@username and password = @password";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@username", textBox1.Text);
                    cmd.Parameters.AddWithValue("@password", textBox2.Text);

                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows == true)
                    {
                        MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Home h = new Home();
                        h.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Login Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Enter Fields", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.SelectAll();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true) 
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else if(checkBox1.Checked == false)
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration r = new Registration();
            r.Show();
            this.Hide();
        }

       /* private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Passwordreset p = new Passwordreset();
            p.Show();
            this.Hide();
        }*/

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text ==""||textBox1.Text =="Enter UserName")
            {
                textBox1.Focus();
                errorProvider1.Icon = Properties.Resources.error;
                errorProvider1.SetError(this.textBox1, "Enter Username");
            }
            else
            {
                errorProvider1.Icon = Properties.Resources.check;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                textBox2.Focus();
                errorProvider2.Icon = Properties.Resources.error;
                errorProvider2.SetError(this.textBox2, "Enter Password");
            }
            else
            {
                errorProvider2.Icon = Properties.Resources.check;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
