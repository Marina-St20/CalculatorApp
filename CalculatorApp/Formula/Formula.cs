// Formula - Expression evaluation logic for CalculatorApp
// Created by Marina S
// GitHub: github.com/Marina-St20
// License: MIT

using System.Collections;
using System.Runtime.Intrinsics;
using System.Text.RegularExpressions;
using System.Windows.Markup;

namespace Formula
{
    /// <summary>
    /// Represents a mathematical formula for evaluation
    /// </summary>
    public class Formula
    {
        private string formulaString = "";
        private string[] tokenList;

        /// <summary>
        /// Initializes a new Formula with the given expression string
        /// </summary>
        /// <param name="formula">The mathematical expression to evaluate</param>
        public Formula(string formula)
        {
            formulaString = formula;
            
            // Tokenize the input string using regex
            tokenList = Regex.Matches(formulaString, @"\d+(\.\d+)?|[+\-x/%]").Select(m => m.Value).ToArray();
        }

        /// <summary>
        /// Evaluates the mathematical expression
        /// </summary>
        /// <returns>The result as a string</returns>
        /// <exception cref="InvalidFormulaException">Thrown for division by zero or other errors</exception>
        public string Evaluate() 
        {
            Stack<double> numStack = new();
            Stack<string> opStack = new();

            double leftVal;
            double rightVal;
            double resultVal=0;

            foreach (string token in tokenList)
            {
                // Process number
                if (IsNum(token))
                {
                    //Handle multiplication/division/modulus
                    if (IsOnTop(opStack, "x") || IsOnTop(opStack, "/") || IsOnTop(opStack, "%"))
                    {
                        string operatorToken = opStack.Pop();

                        if (operatorToken == "x")
                        {
                            resultVal = numStack.Pop() * Convert.ToDouble(token);
                        }
                        else if (operatorToken == "/")
                        {
                            if (Convert.ToDouble(token) == 0.0)
                            {
                                throw new InvalidFormulaException("Error: div by 0");
                            }
                            resultVal = numStack.Pop() / Convert.ToDouble(token);
                        }
                        else if (operatorToken == "%")
                        {
                            if (Convert.ToDouble(token) == 0.0)
                            {
                                throw new InvalidFormulaException("Error: div by 0");
                            }
                            resultVal = numStack.Pop() % Convert.ToDouble(token);
                        }
                        numStack.Push(resultVal);
                    }
                    else
                    {
                        numStack.Push(Convert.ToDouble(token));
                    }
                }
                // Process addition/subtraction
                if (token.Equals("+") || token.Equals("-"))
                {
                    // Evaluate previous addition/subtraction if exists
                    if (IsOnTop(opStack, "+") || IsOnTop(opStack, "-"))
                    {
                        rightVal = numStack.Pop();
                        leftVal = numStack.Pop();

                        if (opStack.Pop() == "+")
                        {
                            resultVal = rightVal + leftVal;
                        }
                        else
                        {
                            resultVal = rightVal - leftVal;
                        }

                        numStack.Push(resultVal);
                    }
                    opStack.Push(token);
                }
                // Process multiplication/division/modulus/open paranthesis
                if (token.Equals("x")  || token.Equals("/") || token.Equals("%") || token.Equals("("))
                {
                    opStack.Push(token);
                }
                // Process closing parenthesis
                if (token.Equals(")"))
                {
                    // Evaluate inside parentheses
                    if (IsOnTop(opStack, "+") || IsOnTop(opStack, "-"))
                    {
                        leftVal = numStack.Pop();
                        rightVal = numStack.Pop();

                        if (opStack.Pop() == "+")
                        {
                            resultVal = rightVal + leftVal;
                        }
                        else
                        {
                            resultVal = rightVal - leftVal;
                        }

                        numStack.Push(resultVal);
                    }

                    // Remove matching open parenthesis
                    opStack.Pop();

                    // Handle multiplication/division/modulus after parentheses
                    if (IsOnTop(opStack, "x") || IsOnTop(opStack, "/") || token.Equals("%"))
                    {
                        leftVal = numStack.Pop();
                        rightVal = numStack.Pop();

                        string operatorToken = opStack.Pop();

                        if (operatorToken == "x")
                        {
                            resultVal = leftVal * rightVal;
                        }
                        else if (operatorToken == "/")
                        {
                            if (leftVal == 0.0)
                            {
                                throw new InvalidFormulaException("Error: div by 0");
                            }
                            resultVal = leftVal / rightVal;
                        }
                        else if ((operatorToken == "%")) 
                        {
                            if (leftVal == 0.0)
                            {
                                throw new InvalidFormulaException("Error: div by 0");
                            }
                            resultVal = leftVal % rightVal;
                        }
                        numStack.Push(resultVal);
                    }
                }
                
            }

            // Final evaluation if operators remain
            if (opStack.Count == 0)
            {
                return numStack.Pop().ToString();
            }
            else
            {
                leftVal = numStack.Pop();
                rightVal = numStack.Pop();

                if (opStack.Pop().Equals("+"))
                {
                    resultVal = leftVal + rightVal;
                }
                else
                {
                    resultVal = leftVal - rightVal;
                }
                return resultVal.ToString();
            }
        }

        /// <summary>
        /// Checks if a token is a valid number
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        private bool IsNum(string token)
        {
            return double.TryParse(token, out _);
        }

        /// <summary>
        /// Checks if a specific token is on top of the stack
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="stack">stack to check</param>
        /// <param name="token">given token to check</param>
        /// <returns></returns>
        private bool IsOnTop<T>(Stack<T> stack, string token)
        {
            return stack.Count > 0 && stack.Peek().Equals(token);
        }

        /// <summary>
        /// Exception thrown for invalid formulas
        /// </summary>
        public class InvalidFormulaException : Exception
        {
            public InvalidFormulaException(string message) : base(message) { }
        }
    }
}
