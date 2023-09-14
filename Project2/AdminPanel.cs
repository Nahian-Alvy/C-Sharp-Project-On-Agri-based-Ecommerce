using Guna.UI2.WinForms.Suite;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

using System.Configuration;


namespace Project2
{
    public partial class AdminPanel : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

        public AdminPanel()
        {
            InitializeComponent();
            BindGridView();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectDBDataSet.version1_database' table. You can move, or remove it, as needed.
           // this.version1_databaseTableAdapter.Fill(this.projectDBDataSet.version1_database);

        }
        
        void ResetControl()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            
            textBox6.Clear();
            
            pictureBox1.Image = Properties.Resources.no_image_avaiable;
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into version1_database (username,password,retypepassword,email,dob,address,picture) values (@username,@password,@retypepassword,@email,@dob,@address,@picture)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", textBox1.Text);
            cmd.Parameters.AddWithValue("@password", textBox2.Text);
            cmd.Parameters.AddWithValue("@retypepassword", textBox3.Text);
            cmd.Parameters.AddWithValue("@email", textBox4.Text);
            cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@address", textBox6.Text);
            cmd.Parameters.AddWithValue("@picture", SavePhoto());

            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Data Inserted Successfully");
                BindGridView();
                ResetControl();
            }
            else
            {
                MessageBox.Show("Data Not Inserted");
            }
        }
        void BindGridView()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from version1_database";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;

            DataGridViewImageColumn dgv = new DataGridViewImageColumn();
            dgv = (DataGridViewImageColumn)dataGridView1.Columns[6];
            dgv.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.RowTemplate.Height = 60;
        }
        private void button8_Click(object sender, EventArgs e)
        {

        }

        private byte[] SavePhoto()
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            return ms.GetBuffer();
        }
        private Image GetPhoto(byte[] photo)
        {
            MemoryStream ms = new MemoryStream(photo);
            return Image.FromStream(ms);
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into version1_database (username,password,retypepassword,email,dob,address,picture) values (@username,@password,@retypepassword,@email,@dob,@address,@picture)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", textBox1.Text);
            cmd.Parameters.AddWithValue("@password", textBox2.Text);
            cmd.Parameters.AddWithValue("@retypepassword", textBox3.Text);
            cmd.Parameters.AddWithValue("@email", textBox4.Text);
            cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@address", textBox6.Text);
            cmd.Parameters.AddWithValue("@picture", SavePhoto());

            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Data Inserted Successfully");
                BindGridView();
                ResetControl();
            }
            else
            {
                MessageBox.Show("Data Not Inserted");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "update  version1_database set username=@username,password=@password,retypepassword=@retypepassword,email=@email,dob=@dob,address=@address,picture=@picture ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", textBox1.Text);
            cmd.Parameters.AddWithValue("@password", textBox2.Text);
            cmd.Parameters.AddWithValue("@retypepassword", textBox3.Text);
            cmd.Parameters.AddWithValue("@email", textBox4.Text);
            cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@address", textBox6.Text);
            cmd.Parameters.AddWithValue("@picture", SavePhoto());

            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Data Update Successfully");
                BindGridView();
                ResetControl();
            }
            else
            {
                MessageBox.Show("Data Not Inserted");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();

                    string deleteQuery = "DELETE FROM version1_database WHERE username = @username";

                    using (SqlCommand cmd = new SqlCommand(deleteQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@username", textBox1.Text);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data Deleted Successfully");
                            BindGridView(); // Assuming this method binds data to a GridView
                            ResetControl(); // Assuming this method resets input controls
                        }
                        else
                        {
                            MessageBox.Show("No data found for deletion.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            ResetControl();
        }

        

        private void button5_Click(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            dateTimePicker1.Value = (DateTime)dataGridView1.SelectedRows[0].Cells[4].Value;
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();

            pictureBox1.Image = GetPhoto((byte[])dataGridView1.SelectedRows[0].Cells[6].Value);
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
          
            pictureBox1.Image = GetPhoto((byte[])dataGridView1.SelectedRows[0].Cells[6].Value);
            */
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            string searchValue = textBox5.Text;
            string searchQuery = "SELECT * FROM version1_database WHERE username = @username";

            using (SqlConnection connection = new SqlConnection(cs))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(searchQuery, connection))
                {
                    command.Parameters.AddWithValue("@username", searchValue);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AdminDashBoard f = new AdminDashBoard();
            f.Show();
            this.Hide();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
