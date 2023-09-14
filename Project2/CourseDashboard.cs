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
    public partial class CourseDashboard : Form
    {
        private Boolean showpanel2 = false;
        public CourseDashboard()
        {
            InitializeComponent();
            tooglePanels();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            showpanel2 = !showpanel2;
            tooglePanels();
        }
        private void tooglePanels()
        {
            if(showpanel2)
            {
                panel2.Height = 350;
            }
            else
            {
                panel2.Height = 0;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Home f = new Home();
            f.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Course1 f = new Course1();
            f.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Course2 f = new Course2();
            f.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Course6 f = new Course6();
            f.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Course3 f = new Course3();
            f.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Course4 f = new Course4();
            f.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Course5 f = new Course5();
            f.Show();
            this.Hide();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Course f = new Course();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
