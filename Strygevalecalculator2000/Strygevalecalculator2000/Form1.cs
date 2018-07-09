using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strygevalecalculator2000
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
            double number1, number2, result;
            number1 = Convert.ToDouble(textBox1.Text);
            number2 = Convert.ToDouble(textBox2.Text);
            result = number1 * number2;
            label1.Text = Convert.ToString(result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double number1, number2, result;
            number1 = Convert.ToDouble(textBox1.Text);
            number2 = Convert.ToDouble(textBox2.Text);
            result = number1 / number2;
            label1.Text = Convert.ToString(result);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double number1, number2, result;
            number1 = Convert.ToDouble(textBox1.Text);
            number2 = Convert.ToDouble(textBox2.Text);
            result = number1 + number2;
            label1.Text = Convert.ToString(result);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double number1, number2, result;
            number1 = Convert.ToDouble(textBox1.Text);
            number2 = Convert.ToDouble(textBox2.Text);
            result = number1 - number2;
            label1.Text = Convert.ToString(result);
        }

        private void number1(object sender, EventArgs e)
        {

        }

        private void number2(object sender, EventArgs e)
        {

        }

        private void result(object sender, EventArgs e)
        {

        }
    }
}

