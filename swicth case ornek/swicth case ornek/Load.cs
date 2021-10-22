using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace swicth_case_ornek
{
    public partial class Load : Form
    {
        public Load()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 5;

            if (panel2.Width >= 180)
            {
                timer1.Stop();
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
                
            }
        }

        private void Load_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
