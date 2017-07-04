using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ResultOutput(double result)
        {
            ResultTextBox.Text = Convert.ToString(result);
        }

        private void Addition(object sender, EventArgs e)
        {
            var result = Convert.ToDouble(FirstOperandTextBox.Text) + Convert.ToDouble(SecondOperandTextBox.Text);
            ResultOutput(result);
        }

        private void Substraction(object sender, EventArgs e)
        {
            var result = Convert.ToDouble(FirstOperandTextBox.Text) - Convert.ToDouble(SecondOperandTextBox.Text);
            ResultOutput(result);
        }

        private void Multiplication(object sender, EventArgs e)
        {
            var result = Convert.ToDouble(FirstOperandTextBox.Text) * Convert.ToDouble(SecondOperandTextBox.Text);
            ResultOutput(result);
        }

        private void Division(object sender, EventArgs e)
        {
            var result = Convert.ToDouble(FirstOperandTextBox.Text) / Convert.ToDouble(SecondOperandTextBox.Text);
            ResultOutput(result);
        }
    }
}
