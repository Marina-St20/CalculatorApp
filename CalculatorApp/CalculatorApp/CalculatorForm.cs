using System.Drawing.Imaging;

namespace CalculatorApp
{
    public partial class calculatorForm : Form
    {
        private int openP;
        private int closeP;

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
            if (isLastToken("("))
            {
                openP--;
            }
            if (isLastToken(")"))
            {
                closeP--;
            }
            if (textDisplay.Text.Length == 1)
            {
                openP = 0;
                closeP = 0;
            }
            if (!isTextboxEmpty())
            {
                textDisplay.Text = textDisplay.Text.Remove(textDisplay.Text.Length - 1);
            }
            
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            if (!isLastToken(")"))
                textDisplay.Text = textDisplay.Text + zeroButton.Text;
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            
            if (!isTextboxEmpty() && !isLastTokenOperator() && !isLastToken("("))
                textDisplay.Text = textDisplay.Text + decimalButton.Text;
        }

        private void percentButton_Click(object sender, EventArgs e)
        {
            if (!isTextboxEmpty() && !isLastTokenOperator() && !isLastToken("("))
                textDisplay.Text = textDisplay.Text + eButton.Text;
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            if (!isLastToken(")"))
                textDisplay.Text = textDisplay.Text + oneButton.Text;
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            if (!isLastToken(")"))
                textDisplay.Text = textDisplay.Text + twoButton.Text;
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            if (!isLastToken(")"))
                textDisplay.Text = textDisplay.Text + threeButton.Text;
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            if (!isLastToken(")"))
                textDisplay.Text = textDisplay.Text + fourButton.Text;
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            if (!isLastToken(")"))
                textDisplay.Text = textDisplay.Text + fiveButton.Text;
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            if (!isLastToken(")"))
                textDisplay.Text = textDisplay.Text + sixButton.Text;
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            if (!isLastToken(")"))
                textDisplay.Text = textDisplay.Text + sevenButton.Text;
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            if (!isLastToken(")"))
                textDisplay.Text = textDisplay.Text + eightButton.Text;
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            if (!isLastToken(")"))
                textDisplay.Text = textDisplay.Text + nineButton.Text;
        }

        private void openPButton_Click(object sender, EventArgs e)
        {
            if (!isLastToken(")") && !isLastTokenNumber())
            {
                textDisplay.Text = textDisplay.Text + openPButton.Text;
                openP++;
            }
        }

        private void closePButton_Click(object sender, EventArgs e)
        {
            if (!isTextboxEmpty() && !isLastTokenOperator() && closeP < openP && !isLastToken("("))
            {
                textDisplay.Text = textDisplay.Text + closePButton.Text;
                closeP++;
            }
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            if (!isTextboxEmpty() && !isLastTokenOperator() && !isLastToken("("))
                textDisplay.Text = textDisplay.Text + divideButton.Text;
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            if (!isTextboxEmpty() && !isLastTokenOperator() && !isLastToken("("))
                textDisplay.Text = textDisplay.Text + multiplyButton.Text;
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            if (!isTextboxEmpty() && !isLastTokenOperator() && !isLastToken("("))
                textDisplay.Text = textDisplay.Text + subtractButton.Text;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (!isTextboxEmpty() && !isLastTokenOperator() && !isLastToken("("))
                textDisplay.Text = textDisplay.Text + addButton.Text;
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            if (!isTextboxEmpty() && hasValidSyntax())
            {
                String text = textDisplay.Text;
                MessageBox.Show("You entered: " + text);
                
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
            List<string> operatorTokens = new List<string> {"+", "-", "x", "/", ".", "%"};
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
            List<string> numberTokens = new List<string> { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            if (!isTextboxEmpty())
            {
                if (numberTokens.Contains(textDisplay.Text[^1].ToString()))
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

        //ensures syntax of the formula is correct before making a formula object
        private bool hasValidSyntax()
        {
            //Make sure the formula has balanced parentheses
            if (openP != closeP)
            {
                return false;
            }

            //Make sure the last token is a number or )
            if (!isLastTokenNumber() && !isLastToken(")")) //if !true or !false
            {
                return false;
            }

            return true;
        }
    }
}
