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
    public partial class Course2 : Form
    {
        public Course2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string f = "E:\\V2\\Project\\Agri for All\\Project2\\Videos\\All Types Of Farming Explained.mp4";
            axWindowsMediaPlayer1.URL = f;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            Course1 f = new Course1();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            Course3 f = new Course3();
            f.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CourseDashboard f = new CourseDashboard();
            f.Show();
            this.Hide();
        }
    }
}
