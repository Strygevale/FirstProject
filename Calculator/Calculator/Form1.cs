using System;
using System.Windows.Forms;
using Calculator.SingleArgument;
using Calculator.TwoArguments;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        /// <summary>
        /// A method, that responds when an operations with single arguments are clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                string firstArgumentString = textBoxFirstIn.Text;
                double firstArgument = Convert.ToDouble(firstArgumentString);
                string secondArgumentString = textBoxSecondIn.Text;
                double secondArgument = Convert.ToDouble(secondArgumentString);
                ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator(((Button) sender).Name);
                double result = calculator.Calculate(firstArgument, secondArgument);
                textBoxOut.Text = result.ToString();
            }
            catch (Exception two)
            {
                textBoxOut.Text = two.Message;
            }
        }
        /// <summary>
        /// A method, that responds when an operations with single arguments are clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ln_Click(object sender, EventArgs e)
        {
            try
            {
                string argumentString = textBoxFirstIn.Text;
                double argument = Convert.ToDouble(argumentString);
                ISingleArgumentCalculatorcs singlecalculator =
                    SingleArgumentFactory.CreateSingleCalculate(((Button) sender).Name);
                double result = singlecalculator.SingleCalculate(argument);
                textBoxOut.Text = result.ToString();
            }
            catch (Exception single)
            {
                textBoxOut.Text = single.Message;
            }
        }
    }
}
