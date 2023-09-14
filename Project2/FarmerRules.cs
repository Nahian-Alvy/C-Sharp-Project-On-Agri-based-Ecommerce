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
    public partial class FarmerRules : Form
    {
        public FarmerRules()
        {
            InitializeComponent();
        }

        private void FarmerRules_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FarmerPage f = new FarmerPage();
            f.Show();
            this.Hide();
        }
    }
}
