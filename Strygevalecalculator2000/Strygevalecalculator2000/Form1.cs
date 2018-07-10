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
            double result;
            switch (((Button)sender).Name)
            {
                case "addition":
                    result = firstArgument + secondArgument;
                    break;
                case "substraction":
                    result = firstArgument - secondArgument;
                    break;
                case "multiply":
                    result = firstArgument * secondArgument;
                    break;
                case "divide":
                    result = firstArgument / secondArgument;
                    break;
                default: throw new Exception("Error");
            }
            textBox3.Text = result.ToString();
        }
    }
}

