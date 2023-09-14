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
    public partial class Course6 : Form
    {
        public Course6()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string f = "E:\\V2\\Project\\Agri for All\\Project2\\Videos\\How to Start a Small Farm _ A Step-by-Step Guide.mp4";
            axWindowsMediaPlayer1.URL = f;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            Course5 f = new Course5();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            Successful f = new Successful();
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
