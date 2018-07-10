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
            double firstArgument, secondArgument, result;
            firstArgument = Convert.ToDouble(textBox1.Text);
            secondArgument = Convert.ToDouble(textBox2.Text);
            switch (((Button) sender).Name)
            {
                case "addition":
                    result = firstArgument + secondArgument;
                    textBox3.Text = Convert.ToString(result);
                    break;
                case "substraction":
                    result = firstArgument - secondArgument;
                    textBox3.Text = Convert.ToString(result);
                    break;
                case "multiply":
                    result = firstArgument * secondArgument;
                    textBox3.Text = Convert.ToString(result);
                    break;
                case "divide":
                    result = firstArgument / secondArgument;
                    textBox3.Text = Convert.ToString(result);
                    break;
                default:
                    throw new Exception("Error");
            }
        }
    }
}

