using System;
using System.Windows.Forms;
using Strygevalecalculator2000.OneArgument;
using Strygevalecalculator2000.TwoArguments;

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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClickOne(object sender, EventArgs e)
        {
            try
            {
                double firstArgument = Convert.ToDouble(textBox1.Text);
                IOneArgumentCalculator calculator = OneFactory.CreateCalculator((((Button) sender).Name));
                double result = calculator.Calculate(firstArgument);
                textBox3.Text = result.ToString();
            }
            catch (Exception single)
            {
                textBox3.Text = single.Message;
            }
        }

        private void ClickTwo(object sender, EventArgs e)
        {
            try
            {
                double firstArgument = Convert.ToDouble(textBox1.Text);
                double secondArgument = Convert.ToDouble(textBox2.Text);
                ITwoArgumentsCalculator calculator = Factory.CreateCalculator((((Button) sender).Name));
                double result = calculator.Calculate(firstArgument, secondArgument);
                textBox3.Text = result.ToString();
            }
            catch (Exception two)
            {
                textBox3.Text = two.Message;
            }
        }
    }
}

