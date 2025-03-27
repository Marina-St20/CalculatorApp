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
            if (!isTextboxEmpty())
            {
                textDisplay.Text = textDisplay.Text.Remove(textDisplay.Text.Length - 1);
            }
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            //cant be after ), 
            textDisplay.Text = textDisplay.Text + zeroButton.Text;
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            
            if (!isLastTokenOperator())
                textDisplay.Text = textDisplay.Text + decimalButton.Text;
        }

        private void percentButton_Click(object sender, EventArgs e)
        {
            if (!isLastTokenOperator())
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
            if (!isLastTokenOperator())
                textDisplay.Text = textDisplay.Text + closePButton.Text;
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            if (!isLastTokenOperator())
                textDisplay.Text = textDisplay.Text + divideButton.Text;
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            if (!isLastTokenOperator())
                textDisplay.Text = textDisplay.Text + multiplyButton.Text;
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            if (!isLastTokenOperator())
                textDisplay.Text = textDisplay.Text + subtractButton.Text;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (!isLastTokenOperator())
                textDisplay.Text = textDisplay.Text + addButton.Text;
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            if (!isTextboxEmpty())
            {
                String text = textDisplay.Text;
                MessageBox.Show("You entered: " + text);
                //check to make sure: balanced parentheses (have member variable counting ( and )) 
                //^if invalid based on checks, do nothing. 
                //syntax should already be assured correct!
                //create formula based on text
                //evaluate it
                //clear textdisplay and display evaluate
                //bool for "current text display is a value rn" --once any number is clicked if curr text is value, then textdisplay is cleared
                //maybe save to stack?
            }
        }

        private bool isLastToken(string token)
        {
            if (!isTextboxEmpty())
                return token == textDisplay.Text[^1].ToString();
            return false;
        }

        private bool isLastTokenOperator()
        {
            List<string> operatorTokens = new List<string> {"+", "-", "x", "/"};
            if (!isTextboxEmpty())
            {
                if (operatorTokens.Contains(textDisplay.Text[^1].ToString()))
                {
                    return true;
                }
            }
            return false;
        }

        private bool isLastTokenNumber()
        {
            List<string> operatorTokens = new List<string> { "+", "-", "x", "/", ".", "%" };
            if (textDisplay.Text != string.Empty)
            {
                if (operatorTokens.Contains(textDisplay.Text[^1].ToString()))
                {
                    return true;
                }
            }
            return false;
        }

        private bool isTextboxEmpty()
        {
            if (textDisplay.Text == string.Empty)
            {
                return true;
            }
            return false;
        }
    }
}
