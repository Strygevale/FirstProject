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

        private void brut(object sender, EventArgs e)
        {
            double firstArgument = Convert.ToDouble(textBox1.Text);
            double secondArgument = Convert.ToDouble(textBox2.Text);
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator((((Button)sender).Name));
            double result = calculator.Calculate(firstArgument, secondArgument);
            textBox3.Text = result.ToString();
        }
    }
}

