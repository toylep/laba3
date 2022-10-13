using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Complex n1 = new Complex(int.Parse(textBox1.Text), int.Parse(textBox4.Text));
            Complex n2 = new Complex(int.Parse(textBox3.Text), int.Parse(textBox2.Text));
            Complex n3 = n1 + n2;

            MessageBox.Show(n3.Message(n3));

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Complex n1 = new Complex(int.Parse(textBox1.Text), int.Parse(textBox4.Text));
            Complex n2 = new Complex(int.Parse(textBox3.Text), int.Parse(textBox2.Text));
            Complex n3 = n1 - n2;
           
            MessageBox.Show(n3.Message(n3));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Complex n1 = new Complex(int.Parse(textBox1.Text), int.Parse(textBox4.Text));
            Complex n2 = new Complex(int.Parse(textBox3.Text), int.Parse(textBox2.Text));
            Complex n3 = n1 * n2;
            
            MessageBox.Show(n3.Message(n3));

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Complex n1 = new Complex(int.Parse(textBox1.Text), int.Parse(textBox4.Text));
            Complex n2 = new Complex(int.Parse(textBox3.Text), int.Parse(textBox2.Text));
            Complex n3 = n1 / n2;
            
            MessageBox.Show(n3.Message(n3));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Complex n1 = new Complex(int.Parse(textBox1.Text), int.Parse(textBox4.Text));
            Complex n2 = new Complex(int.Parse(textBox3.Text), int.Parse(textBox2.Text));
           MessageBox.Show( Complex.Comparison(n1, n2));
        }
    }
}


