using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace okuldeneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c;
            double ort;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            c = Convert.ToInt32(textBox3.Text);
            if (a<0 || a>100 || b < 0 || b > 100 || c < 0 || c > 100)
            {
                MessageBox.Show("100-0 arası giriş yapmadınız, program kapatılacak", "Hata");
                Application.Exit();
            }
            ort = (a + b + c) / 3;
            label6.Text = ort.ToString();

            if (ort>=0 && ort<=24)
            {
                label7.Text = "Kaldı";
                label8.Text = "0";
            }
            else if (ort >= 25 && ort <= 49)
            {
                label7.Text = "Kaldı";
                label8.Text = "1";
            }
            else if (ort >= 50 && ort <= 54)
            {
                label7.Text = "Geçti";
                label8.Text = "2";
            }
            else if (ort >= 55 && ort <= 69)
            {
                label7.Text = "Geçti";
                label8.Text = "3";
            }
            else if (ort >= 70 && ort <= 84)
            {
                label7.Text = "Geçti";
                label8.Text = "4";
            }
            else if (ort >= 85 && ort <= 100)
            {
                label7.Text = "Geçti";
                label8.Text = "5";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
            label6.ResetText();
            label7.ResetText();
            label8.ResetText();
        }
    }
}
