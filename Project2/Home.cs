using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customerhome customerhome = new Customerhome();
            customerhome.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customerhome f = new Customerhome();
            f.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FarmerRules f = new FarmerRules();
            f.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Course f = new Course();
            f.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
          login f = new login();
            f.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
