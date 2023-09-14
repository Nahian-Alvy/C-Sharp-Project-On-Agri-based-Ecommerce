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
    public partial class Course3 : Form
    {
        public Course3()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string f = "E:\\V2\\Project\\Agri for All\\Project2\\Videos\\Starting a Farm_ 7 Tips for Beginners.mp4";
            axWindowsMediaPlayer1.URL = f;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            Course2 f = new Course2();
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Course4 f = new Course4();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            Course4 f = new Course4();
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
