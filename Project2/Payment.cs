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
    public partial class Payment : Form
    {
        public static Payment Current;
        public Label lbl;

        public Payment()
        {
            InitializeComponent();
            Current = this;
            lbl = label1;
           
        }
        private void ShowChildForm1()
        {
            Bkash f = new Bkash();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None; // Optional, removes border
            f.Dock = DockStyle.Fill; // Optional, fills the panel
            panel1.Controls.Clear();
            panel1.Controls.Add(f);
            f.Show();
        }
        private void ShowChildForm2()
        {
            Card c = new Card();
            c.TopLevel = false;
            c.FormBorderStyle = FormBorderStyle.None; // Optional, removes border
            c.Dock = DockStyle.Fill; // Optional, fills the panel
            panel1.Controls.Clear();
            panel1.Controls.Add(c);
            c.Show();
            
        }
        private void Payment_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Bkash_CheckedChanged(object sender, EventArgs e)
        {
            ShowChildForm1 ();
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ShowChildForm2 ();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Customerhome f = new Customerhome();
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
