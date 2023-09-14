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
    public partial class AdminDashBoard : Form
    {
        public AdminDashBoard()
        {
            InitializeComponent();
        }
        private void ShowChildForm()
        {
            AdminRevenue f = new AdminRevenue();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None; // Optional, removes border
            f.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(f);
            f.Show();
        }
        private void ShowChild2Form()
        {
            Adminfarmer f = new Adminfarmer();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None; // Optional, removes border
            f.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(f);
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminPanel panel = new AdminPanel();
            panel.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowChildForm();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowChild2Form();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
