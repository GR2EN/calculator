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

        private void ButtonClickHandler(object sender, EventArgs e)
        {
            double result;

            switch (((Button) sender).Name)
            {
                case "ButtonAddition":
                    result = Convert.ToDouble(FirstOperandTextBox.Text) + Convert.ToDouble(SecondOperandTextBox.Text);
                    break;
                case "ButtonSubstraction":
                    result = Convert.ToDouble(FirstOperandTextBox.Text) - Convert.ToDouble(SecondOperandTextBox.Text);
                    break;
                case "ButtonMultiplication":
                    result = Convert.ToDouble(FirstOperandTextBox.Text) * Convert.ToDouble(SecondOperandTextBox.Text);
                    break;
                case "ButtonDivision":
                    result = Convert.ToDouble(FirstOperandTextBox.Text) / Convert.ToDouble(SecondOperandTextBox.Text);
                    break;
                default:
                    throw new Exception("Unknown operation");
            }

            ResultOutput(result);
        }
    }
}
