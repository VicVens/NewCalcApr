using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewCalcApr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addition_Click(object sender, EventArgs e)
        {
            int first = Convert.ToInt32(FirsInput.Text);
            int second = Convert.ToInt32(SecondInput.Text);
            Output.Text = (first + second).ToString();
        }

        private void Subtraction_Click(object sender, EventArgs e)
        {
            int first = Convert.ToInt32(FirsInput.Text);
            int second = Convert.ToInt32(SecondInput.Text);
            Output.Text = (first - second).ToString();
        }

        private void Multiplication_Click(object sender, EventArgs e)
        {
            int first = Convert.ToInt32(FirsInput.Text);
            int second = Convert.ToInt32(SecondInput.Text);
            Output.Text = (first * second).ToString();
        }

        private void Division_Click(object sender, EventArgs e)
        {
            int first = Convert.ToInt32(FirsInput.Text);
            int second = Convert.ToInt32(SecondInput.Text);
            Output.Text = (first / second).ToString();
        }
    }
}
