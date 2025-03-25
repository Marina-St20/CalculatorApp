using System.Drawing.Imaging;

namespace CalculatorApp
{
    public partial class calculatorForm : Form
    {

        public calculatorForm()
        {
            InitializeComponent();
        }

        private void calculatorForm_Load(object sender, EventArgs e)
        {

        }

        private void textDisplay_Click(object sender, EventArgs e)
        {

        }

        private void backspaceButton_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text.Length > 0)
            {
                textDisplay.Text = textDisplay.Text.Remove(textDisplay.Text.Length - 1);
            }
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + zeroButton.Text;
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + decimalButton.Text;
        }

        private void percentButton_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + eButton.Text;
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + oneButton.Text;
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + twoButton.Text;
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + threeButton.Text;
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + fourButton.Text;
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + fiveButton.Text;
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + sixButton.Text;
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + sevenButton.Text;
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + eightButton.Text;
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + nineButton.Text;
        }

        private void openPButton_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + openPButton.Text;
        }

        private void closePButton_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + closePButton.Text;
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + divideButton.Text;
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + multiplyButton.Text;
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + subtractButton.Text;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + addButton.Text;
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            String text = textDisplay.Text;
            MessageBox.Show("You entered: " + text);
        }

        
    }
}
