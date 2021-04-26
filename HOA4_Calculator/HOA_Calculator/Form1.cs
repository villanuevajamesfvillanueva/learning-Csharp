using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOA_Calculator
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

        private void multiply_btn_Click(object sender, EventArgs e)
        {
            string textbox1Value = textBox1.Text;
            string textbox2Value = textBox2.Text;

            // Retrieve as decimal
            decimal valueDec1 = decimal.Parse(textbox1Value);
            decimal valueDec2 = decimal.Parse(textbox2Value);

            decimal product = valueDec1 * valueDec2;
            MessageBox.Show($"The product is {product.ToString()}");
        }

        private void divide_btn_Click(object sender, EventArgs e)
        {
            string textbox1Value = textBox1.Text;
            string textbox2Value = textBox2.Text;

            // Retrieve as decimal
            decimal valueDec1 = decimal.Parse(textbox1Value);
            decimal valueDec2 = decimal.Parse(textbox2Value);

            decimal quotient = valueDec1 / valueDec2;
            MessageBox.Show($"The quotient is {quotient.ToString()}");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
       
        }
    }
}
