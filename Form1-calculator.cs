using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULATOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c;
            if (radioButton1.Checked)
            {
                c = a + b;
                label4.Text = "Sum: " + c.ToString();
            }
            if (radioButton2.Checked)
            {
                c = a - b;
                label4.Text = "Difference: " + c.ToString();
            }
            if (radioButton3.Checked)
            {
                c = a * b;
                label4.Text = "Product: " + c.ToString();
            }
            if (radioButton4.Checked)
            {
                c = a / b;
                label4.Text = "Quotient: " + c.ToString();
            }
            if (radioButton5.Checked)
            {
                c = a % b;
                label4.Text = "Modulus: " + c.ToString();
            }
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label4.Text = "";
        }

    }
}
