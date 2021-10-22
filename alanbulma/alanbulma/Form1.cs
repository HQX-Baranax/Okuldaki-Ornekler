using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alanbulma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double alan, cevre;
        double pi = 3.14;

        private void button2_Click(object sender, EventArgs e)
        {
            double yaricap = Convert.ToDouble(yaricaptxt.Text);
            cevre = 2 * pi * yaricap;
            label5.Text = Convert.ToString(cevre);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.ResetText();
            label5.ResetText();
            yaricaptxt.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double yaricap = Convert.ToDouble(yaricaptxt.Text);
            alan = pi * yaricap * yaricap;
            label4.Text = Convert.ToString(alan);
        }
    }
}
