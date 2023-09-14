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
    public partial class FarmerPage : Form
    {
        public FarmerPage()
        {
            InitializeComponent();
        }
        private void ShowChild3Form()
        {
            FarmerVegetable f = new FarmerVegetable();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None; // Optional, removes border
            f.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(f);

            f.Show();
        }
        private void ShowChild2Form()
        {
            Rent f = new Rent();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None; // Optional, removes border
            f.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(f);

            f.Show();
        }
        private void ShowChild1Form()
        {
            Rice f = new Rice();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None; // Optional, removes border
            f.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(f);

            f.Show();
        }

        private void ShowChildForm()
        {
            Fruit f = new Fruit();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None; // Optional, removes border
            f.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(f);
            f.Show();
        }
        private void ShowChild4Form()
        {
            Farmercart f = new Farmercart();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None; // Optional, removes border
            f.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(f);
            f.Show();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home f = new Home();
            f.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           ShowChild2Form();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           ShowChild1Form();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowChildForm();
        }

        private void button2_Click(object sender, EventArgs e)
        {

           ShowChild3Form();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ShowChild4Form();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Home f = new Home();
            f.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
