using System;
using System.Globalization;
using System.Windows.Forms;
using Calculator.OneArgument;
using Calculator.TwoArguments;

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
            ResultTextBox.Text = Convert.ToString(result, CultureInfo.InvariantCulture);
        }

        private void TwoArgumentButtonClick(object sender, EventArgs e)
        {
            double firstArgument = Convert.ToDouble(FirstOperandTextBox.Text);
            double secondArgument = Convert.ToDouble(SecondOperandTextBox.Text);
            ITwoArgumentsCalculator calculator =
                TwoArgumentsFactory.CreateCalculatorByButtonName(((Button)sender).Name);
            ResultOutput(calculator.Calculate(firstArgument, secondArgument));
        }

        private void OneArgumentButtonClick(object sender, EventArgs e)
        {
            double argument = Convert.ToDouble(FirstOperandTextBox.Text);
            IOneArgumentCalculator calculator =
                OneArgumentFactory.CreateCalculatorByButtonName(((Button)sender).Name);
            ResultOutput(calculator.Calculate(argument));
        }
    }
}
