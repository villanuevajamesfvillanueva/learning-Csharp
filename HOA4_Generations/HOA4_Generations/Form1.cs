using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOA4_Generations
{
    public partial class Generations : Form
    {
        public Generations()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int age = int.Parse(textBox1.Text);
            string gen;
            if (age > 55) { gen = "Boomer"; }
            else if (age > 39 && age <= 55) { gen = "Gen X"; }
            else if (age > 23 && age <= 39) { gen = "Millenial"; }
            else { gen = "Gen Z"; }
            MessageBox.Show($"You are a {gen}!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
