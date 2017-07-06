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
            try
            {
                if (FirstOperandTextBox.Text == null || SecondOperandTextBox.Text == null)
                {
                    throw new Exception("Поля не должны быть пустыми.");
                }

                double firstArgument = Convert.ToDouble(FirstOperandTextBox.Text);
                double secondArgument = Convert.ToDouble(SecondOperandTextBox.Text);
                ITwoArgumentsCalculator calculator =
                    TwoArgumentsFactory.CreateCalculatorByButtonName(((Button)sender).Name);
                ResultOutput(calculator.Calculate(firstArgument, secondArgument));
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void OneArgumentButtonClick(object sender, EventArgs e)
        {
            try
            {
                if (FirstOperandTextBox.Text == null)
                {
                    throw new Exception("Поле не должно быть пустым.");
                }

                double argument = Convert.ToDouble(FirstOperandTextBox.Text);
                IOneArgumentCalculator calculator =
                    OneArgumentFactory.CreateCalculatorByButtonName(((Button)sender).Name);
                ResultOutput(calculator.Calculate(argument));
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void TwoOperandsOn(object sender, EventArgs e)
        {
            SecondOperandTextBox.Enabled = true;
        }

        private void OneOperandOn(object sender, EventArgs e)
        {
            SecondOperandTextBox.Enabled = false;
            SecondOperandTextBox.Clear();
        }

        private void KeyHandler(object sender, KeyPressEventArgs e)
        {
            // точка или запятая
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                // что если разделитель уже есть?
                if (((TextBox)sender).Text.IndexOf('.') != -1)
                {
                    e.Handled = true;
                    //return;
                }
                // жесткая точка
                e.KeyChar = '.';
            }

            // а что если знак отрицания не один?
            if (e.KeyChar == '-')
            {
                if (((TextBox) sender).Text.IndexOf('-') != -1)
                {
                    e.Handled = true;
                }
            }

            // не управляющая клавиша, число или разделитель
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
                e.Handled = true;
        }
    }
}
