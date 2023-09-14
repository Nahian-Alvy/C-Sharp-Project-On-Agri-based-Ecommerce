using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design.WebControls;
using System.Windows.Forms;

namespace Project2
{
    public partial class Customerhome : Form
    {
        
        
        public Customerhome()
        {
            InitializeComponent();
            
        }

        private void ShowChild3Form()
        {
            CustomerRice f = new CustomerRice();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None; // Optional, removes border
            f.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(f);

            f.Show();
        }
        private void ShowChild2Form()
        {
            CustomerVegetable f = new CustomerVegetable();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None; // Optional, removes border
            f.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(f);

            f.Show();
        }
        private void ShowChild1Form()
        {
            CustomerFruits f = new CustomerFruits();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None; // Optional, removes border
            f.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(f);
           
            f.Show();
        }

        private void ShowChildForm()
        {
            Farmingmaterial f = new Farmingmaterial();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None; // Optional, removes border
            f.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(f);
            f.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            ShowChild3Form();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           ShowChildForm();
        }


        private void button3_Click_1(object sender, EventArgs e)
        {
            ShowChild2Form();

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
           
        }
        bool menuExpand = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (menuExpand==false)
            {
                flowLayoutPanel1.Height += 10;
                if (flowLayoutPanel1.Height >= 250)
                {
                    timer1.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                flowLayoutPanel1.Height -= 10;
                if(flowLayoutPanel1.Height <=42)
                {
                    timer1.Stop();
                    menuExpand = false;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ShowChild1Form();


        }

        




        private void button4_Click_2(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }
       
        
        private void button6_Click_1(object sender, EventArgs e)
        {
            Cart2 cart2 = new Cart2();
            cart2.Show();
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

            Home f = new Home();
            f.Show();
            this.Hide();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
