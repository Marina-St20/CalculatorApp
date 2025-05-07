// CalculatorApp - A simple Windows Forms calculator
// Created by Marina S
// GitHub: github.com/Marina-St20
// License: MIT

using System.Drawing.Imaging;

namespace CalculatorApp
{
    /// <summary>
    /// Main form class for the Calculator application
    /// </summary>
    public partial class calculatorForm : Form
    {
        // Trackers for parenthesis balance
        private int openP;
        private int closeP;

        // Flags for calculator state
        private bool justEvaluated = false;
        private bool errorJustDisplayed = false;

        /// <summary>
        /// Initializes the caluclator form
        /// </summary>
        public calculatorForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles keyboard input for calculator operations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calculatorForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Map keyboard keys to calculator buttons
            if (e.KeyCode == Keys.Back)
            {
                backspaceButton_Click(sender, e);
            }
            else if (e.KeyCode == Keys.D9 && e.Shift)
            {
                openPButton_Click(sender, e);
            }
            else if (e.KeyCode == Keys.D0 && e.Shift)
            {
                closePButton_Click(sender, e);
            }
            else if (e.KeyCode == Keys.D5 && e.Shift)
            {
                percentButton_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Divide)
            {
                divideButton_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Multiply)
            {
                multiplyButton_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Subtract)
            {
                subtractButton_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Add)
            {
                addButton_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Decimal || e.KeyCode == Keys.OemPeriod)
            {
                decimalButton_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Enter)
            {
                equalsButton_Click(sender, e);
            }
            else if (e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.D0)
            {
                zeroButton_Click(sender, e);
            }
            else if (e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D1)
            {
                oneButton_Click(sender, e);
            }
            else if (e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.D2)
            {
                twoButton_Click(sender, e);
            }
            else if (e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3)
            {
                threeButton_Click(sender, e);
            }
            else if (e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.D4)
            {
                fourButton_Click(sender, e);
            }
            else if (e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.D5)
            {
                fiveButton_Click(sender, e);
            }
            else if (e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.D6)
            {
                sixButton_Click(sender, e);
            }
            else if (e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.D7)
            {
                sevenButton_Click(sender, e);
            }
            else if (e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.D8)
            {
                eightButton_Click(sender, e);
            }
            else if (e.KeyCode == Keys.NumPad9 || e.KeyCode == Keys.D9)
            {
                nineButton_Click(sender, e);
            }

        }

        /// <summary>
        /// Handles backspace functionality
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backspaceButton_Click(object sender, EventArgs e)
        {
            // Adjust parenthesis counters if needed
            if (isLastToken("("))
            {
                openP--;
            }
            if (isLastToken(")"))
            {
                closeP--;
            }

            // Reset counters if we're deleting the last character
            if (textDisplay.Text.Length == 1)
            {
                openP = 0;
                closeP = 0;
            }

            // Remove last character if display isn't empty
            if (!isTextboxEmpty())
            {
                textDisplay.Text = textDisplay.Text.Remove(textDisplay.Text.Length - 1);
            }

            justEvaluated = false;
        }

        /// <summary>
        /// Handles decimal point input with validation
        /// Only allows decimal if:
        /// - Display isn't empty
        /// - Last token isn't an operator/parenthesis
        /// - Current number doesn't already have a decimal
        /// - No error is currently displayed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void decimalButton_Click(object sender, EventArgs e)
        {
            if (!isTextboxEmpty() && !isLastTokenOperator() && !isLastToken("(") && !isLastToken(")") && !isLastToken(".") && !errorJustDisplayed)
            {
                string[] tokenList = textDisplay.Text.Split(new char[] { '+', '-', '/', 'x', '%' });
                string currentNum = tokenList[tokenList.Length - 1];

                if (!currentNum.Contains("."))
                {
                    textDisplay.Text = textDisplay.Text + decimalButton.Text;
                }

                justEvaluated = false;
                errorJustDisplayed = false;
            }
        }

        /// <summary>
        /// Handles number zero input with validation
        /// Only allows number if:
        /// - Last token isn't a closing parenthesis
        /// If just evaluated or an error is displayed, start new input.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void zeroButton_Click(object sender, EventArgs e)
        {
            if (!isLastToken(")"))
                textDisplay.Text = textDisplay.Text + zeroButton.Text;
            
            if (justEvaluated || errorJustDisplayed)
            {
                textDisplay.Text = zeroButton.Text;
                justEvaluated = false;
                errorJustDisplayed = false;
            }
        }
        /// <summary>
        /// Handles number one input with validation
        /// Only allows number if:
        /// - Last token isn't a closing parenthesis
        /// If just evaluated or an error is displayed, start new input.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void oneButton_Click(object sender, EventArgs e)
        {
            if (!isLastToken(")"))
                textDisplay.Text = textDisplay.Text + oneButton.Text;
            
            if (justEvaluated || errorJustDisplayed)
            {
                textDisplay.Text = oneButton.Text;
                justEvaluated = false;
                errorJustDisplayed = false;
            }
        }

        /// <summary>
        /// Handles number two input with validation
        /// Only allows number if:
        /// - Last token isn't a closing parenthesis
        /// If just evaluated or an error is displayed, start new input.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void twoButton_Click(object sender, EventArgs e)
        {
            if (!isLastToken(")"))
                textDisplay.Text = textDisplay.Text + twoButton.Text;

            if (justEvaluated || errorJustDisplayed)
            {
                textDisplay.Text = twoButton.Text;
                justEvaluated = false;
                errorJustDisplayed = false;
            }
        }

        /// <summary>
        /// Handles number three input with validation
        /// Only allows number if:
        /// - Last token isn't a closing parenthesis
        /// If just evaluated or an error is displayed, start new input.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void threeButton_Click(object sender, EventArgs e)
        {
            if (!isLastToken(")"))
                textDisplay.Text = textDisplay.Text + threeButton.Text;

            if (justEvaluated || errorJustDisplayed)
            {
                textDisplay.Text = threeButton.Text;
                justEvaluated = false;
                errorJustDisplayed = false;
            }
        }

        /// <summary>
        /// Handles number four input with validation
        /// Only allows number if:
        /// - Last token isn't a closing parenthesis
        /// If just evaluated or an error is displayed, start new input.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fourButton_Click(object sender, EventArgs e)
        {
            if (!isLastToken(")"))
                textDisplay.Text = textDisplay.Text + fourButton.Text;

            if (justEvaluated || errorJustDisplayed)
            {
                textDisplay.Text = fourButton.Text;
                justEvaluated = false;
                errorJustDisplayed = false;
            }
        }

        /// <summary>
        /// Handles number five input with validation
        /// Only allows number if:
        /// - Last token isn't a closing parenthesis
        /// If just evaluated or an error is displayed, start new input.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fiveButton_Click(object sender, EventArgs e)
        {
            if (!isLastToken(")"))
                textDisplay.Text = textDisplay.Text + fiveButton.Text;

            if (justEvaluated || errorJustDisplayed)
            {
                textDisplay.Text = fiveButton.Text;
                justEvaluated = false;
                errorJustDisplayed = false;
            }
        }

        /// <summary>
        /// Handles number six input with validation
        /// Only allows number if:
        /// - Last token isn't a closing parenthesis
        /// If just evaluated or an error is displayed, start new input.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sixButton_Click(object sender, EventArgs e)
        {
            if (!isLastToken(")"))
                textDisplay.Text = textDisplay.Text + sixButton.Text;
            
            if (justEvaluated || errorJustDisplayed)
            {
                textDisplay.Text = sixButton.Text;
                justEvaluated = false;
                errorJustDisplayed = false;
            }
        }

        /// <summary>
        /// Handles number seven input with validation
        /// Only allows number if:
        /// - Last token isn't a closing parenthesis
        /// If just evaluated or an error is displayed, start new input.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void sevenButton_Click(object sender, EventArgs e)
        {
            if (!isLastToken(")"))
                textDisplay.Text = textDisplay.Text + sevenButton.Text;

            if (justEvaluated || errorJustDisplayed)
            {
                textDisplay.Text = sevenButton.Text;
                justEvaluated = false;
                errorJustDisplayed = false;
            }
        }

        /// <summary>
        /// Handles number eight input with validation
        /// Only allows number if:
        /// - Last token isn't a closing parenthesis
        /// If just evaluated or an error is displayed, start new input.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void eightButton_Click(object sender, EventArgs e)
        {
            if (!isLastToken(")"))
                textDisplay.Text = textDisplay.Text + eightButton.Text;

            if (justEvaluated || errorJustDisplayed)
            {
                textDisplay.Text = eightButton.Text;
                justEvaluated = false;
                errorJustDisplayed = false;
            }
        }

        /// <summary>
        /// Handles number nine input with validation
        /// Only allows number if:
        /// - Last token isn't a closing parenthesis
        /// If just evaluated or an error is displayed, start new input.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nineButton_Click(object sender, EventArgs e)
        {
            if (!isLastToken(")"))
                textDisplay.Text = textDisplay.Text + nineButton.Text;

            if (justEvaluated || errorJustDisplayed)
            {
                textDisplay.Text = nineButton.Text;
                justEvaluated = false;
                errorJustDisplayed = false;
            }
        }

        /// <summary>
        /// Handles opening parenthesis input with validation
        /// Only allows opening parenthesis if:
        /// - Last token isn't a number
        /// - Last token isn't a closing parenthesis
        /// - Last token isn't a decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openPButton_Click(object sender, EventArgs e)
        {
            if (!isLastToken(")") && !isLastTokenNumber() && !isLastToken(".") && !errorJustDisplayed)
            {
                textDisplay.Text = textDisplay.Text + openPButton.Text;
                openP++;
                justEvaluated = false;
                errorJustDisplayed = false;
            }
        }

        /// <summary>
        /// Handles closing parenthesis input with validation
        /// Only allows closing parenthesis if:
        /// - Must have matching opening parnethsis
        /// - Last token isn't an operator
        /// - Last token isn't an opening parentheses
        /// - Last token isn't a decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closePButton_Click(object sender, EventArgs e)
        {
            if (!isTextboxEmpty() && !isLastTokenOperator() && closeP < openP && !isLastToken("(") && !isLastToken(".") && !errorJustDisplayed)
            {
                textDisplay.Text = textDisplay.Text + closePButton.Text;
                closeP++;
                justEvaluated = false;
                errorJustDisplayed = false;
            }
        }

        /// <summary>
        /// Handles division operator input with validation
        /// Only allows for operator if:
        /// - Last token isn't an operator
        /// - Last token isn't a closing parenthesis
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void divideButton_Click(object sender, EventArgs e)
        {
            if (!isTextboxEmpty() && !isLastTokenOperator() && !isLastToken("(") && !isLastToken(".") && !errorJustDisplayed)
            {
                textDisplay.Text = textDisplay.Text + divideButton.Text;
                justEvaluated = false;
                errorJustDisplayed = false;
            }

        }

        /// <summary>
        /// Handles multiplication operator input with validation
        /// Only allows for operator if:
        /// - Last token isn't an operator
        /// - Last token isn't a closing parenthesis
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void multiplyButton_Click(object sender, EventArgs e)
        {
            if (!isTextboxEmpty() && !isLastTokenOperator() && !isLastToken("(") && !isLastToken(".") && !errorJustDisplayed)
            {
                textDisplay.Text = textDisplay.Text + multiplyButton.Text;
                justEvaluated = false;
                errorJustDisplayed = false;
            }

        }

        /// <summary>
        /// Handles subtraction operator input with validation
        /// Only allows for operator if:
        /// - Last token isn't an operator
        /// - Last token isn't a closing parenthesis
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void subtractButton_Click(object sender, EventArgs e)
        {
            if (!isTextboxEmpty() && !isLastTokenOperator() && !isLastToken("(") && !isLastToken(".") && !errorJustDisplayed)
            {
                textDisplay.Text = textDisplay.Text + subtractButton.Text;
                justEvaluated = false;
                errorJustDisplayed = false;
            }

        }

        /// <summary>
        /// Handles addition operator input with validation
        /// Only allows for operator if:
        /// - Last token isn't an operator
        /// - Last token isn't a closing parenthesis
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            if (!isTextboxEmpty() && !isLastTokenOperator() && !isLastToken("(") && !isLastToken(".") && !errorJustDisplayed)
            {
                textDisplay.Text = textDisplay.Text + addButton.Text;
                justEvaluated = false;
                errorJustDisplayed = false;
            }

        }

        /// <summary>
        /// Handles percentage operator input with validation
        /// Only allows for operator if:
        /// - Last token isn't an operator
        /// - Last token isn't a closing parenthesis
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void percentButton_Click(object sender, EventArgs e)
        {
            if (!isTextboxEmpty() && !isLastTokenOperator() && !isLastToken("(") && !isLastToken(".") && !errorJustDisplayed)
            {
                textDisplay.Text = textDisplay.Text + eButton.Text;
                justEvaluated = false;
                errorJustDisplayed = false;
            }
        }

        /// <summary>
        /// Evaluates the current expression when equals is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void equalsButton_Click(object sender, EventArgs e)
        {
            if (!isTextboxEmpty() && hasValidSyntax())
            {
                String text = textDisplay.Text;
                Formula.Formula formula = new Formula.Formula(text);

                try
                {
                    textDisplay.Text = formula.Evaluate();
                    
                } catch (Exception ex)
                {
                    textDisplay.Text = ex.Message;
                    errorJustDisplayed = true;
                }

                justEvaluated = true;
            }
        }

        /// <summary>
        /// Checks if the last token in the display matches the given token
        /// </summary>
        /// <param name="token">token to check</param>
        /// <returns>true if the last token matches the given token, false if otherwise</returns>
        private bool isLastToken(string token)
        {
            if (!isTextboxEmpty())
                return token == textDisplay.Text[^1].ToString();
            return false;
        }

        /// <summary>
        /// Checks if the last character is an operator
        /// </summary>
        /// <returns>true if the last token was an operator, false if otherwise</returns>
        private bool isLastTokenOperator()
        {
            List<string> operatorTokens = new List<string> { "+", "-", "x", "/", "%" };
            if (!isTextboxEmpty())
            {
                if (operatorTokens.Contains(textDisplay.Text[^1].ToString()))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Checks if the last character is a number
        /// </summary>
        /// <returns>true if the last character was a number, false if otherwise</returns>
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

        /// <summary>
        /// Checks if the display text is empty
        /// </summary>
        /// <returns>true if the textbox is empty, false if otherwise</returns>
        private bool isTextboxEmpty()
        {
            if (textDisplay.Text == string.Empty)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Validates the syntax of the current expression before evaluation
        /// </summary>
        /// <returns>true if syntax is valid, false if otherwise</returns>
        private bool hasValidSyntax()
        {
            // Check for balanced parentheses
            if (openP != closeP)
            {
                return false;
            }

            // Last token must be a number or closing parenthesis
            if (!isLastTokenNumber() && !isLastToken(")"))
            {
                return false;
            }

            return true;
        }
    }
}
