using Shared.Lib.Services;

namespace Shared.Win
{
    public partial class Form1 : Form
    {
        SharedCalculator calc = new SharedCalculator();
        public Form1()
        {
            InitializeComponent();
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var num1 = Double.Parse(firstNumber.Text);
                var num2 = Double.Parse(secondNumber.Text);
                var result = calc.Add(num1, num2).ToString();
                lblResult.Text = $"O resultado da soma é {result}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            try
            {
                var num1 = Double.Parse(firstNumber.Text);
                var num2 = Double.Parse(secondNumber.Text);
                var result = calc.Subtract(num1, num2).ToString();

                lblResult.Text = $"O resultado da substração é {result}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            try
            {
                var num1 = Double.Parse(firstNumber.Text);
                var num2 = Double.Parse(secondNumber.Text);
                var result = calc.Multiply(num1, num2).ToString();

                lblResult.Text = $"O resultado da multiplicação é {result}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                var num1 = Double.Parse(firstNumber.Text);
                var num2 = Double.Parse(secondNumber.Text);
                var result = calc.Divide(num1, num2).ToString();

                lblResult.Text = $"O resultado da divisão é {result}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
