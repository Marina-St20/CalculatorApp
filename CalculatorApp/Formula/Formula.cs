using System.Collections;
using System.Runtime.Intrinsics;
using System.Text.RegularExpressions;
using System.Windows.Markup;

namespace Formula
{
    public class Formula
    {
        private string formulaString = "";

        private string[] tokenList;

        public Formula(string formula)
        {
            formulaString = formula;

            //createTokenList();
            //tokenList = formulaString.Split(new char[] { '+', '-', '/', 'x', '%' });

            tokenList = Regex.Matches(formulaString, @"\d+(\.\d+)?|[+\-x/%]").Select(m => m.Value).ToArray();

            if (!isValidFormula(out string errorMessage))
            {
                throw new InvalidFormulaException(errorMessage);
            }


        }

        //string to token list (dont care about spaces)

        private void createTokenList()
        {
            //string pattern = @"\d+(\.\d+)?|[%+\-*/()]";
            //MatchCollection matches = Regex.Matches(formulaString, pattern);

            //foreach (Match match in matches)
            //{
            //    tokenList.Add(match.Value);
            //}

            string[] tokenList = formulaString.Split(new char[] { '+', '-', '/', 'x', '%' });
            //string currentNum = tokenList[tokenList.Length - 1];
        }

        //Check if valid Formula Method
        //delete later????
        private bool isValidFormula(out string errorMessage)
        {
            errorMessage = string.Empty;

            return true;
        }

        //token checks

        //evalute method

        public string Evaluate() 
        {
            Stack<double> numStack = new();
            Stack<string> opStack = new();

            double leftVal;
            double rightVal;
            double resultVal=0;

            foreach (string token in tokenList)
            {
                //if token is a number
                if (IsNum(token))
                {
                    if (IsOnTop(opStack, "x") || IsOnTop(opStack, "/"))
                    {
                        if (Convert.ToDouble(token) == 0.0)
                        {
                            throw new InvalidFormulaException("Cannot divide by zero.");
                        }
                        if (opStack.Pop() == "x")
                        {
                            resultVal = numStack.Pop() * Convert.ToDouble(token);
                        }
                        else
                        {
                            resultVal = numStack.Pop() / Convert.ToDouble(token);
                        }
                        numStack.Push(resultVal); ///////////
                    }
                    else
                    {
                        numStack.Push(Convert.ToDouble(token));
                    }
                }
                //if token is + or -
                if (token.Equals("+") || token.Equals("-"))
                {
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
                //if token is *, /, or (
                if (token.Equals("x")  || token.Equals("/") || token.Equals("("))
                {
                    opStack.Push(token);
                }
                //if token is )
                if (token.Equals(")"))
                {
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
                    opStack.Pop();

                    if (IsOnTop(opStack, "x") || IsOnTop(opStack, "/"))
                    {
                        leftVal = numStack.Pop();
                        rightVal = numStack.Pop();

                        if (leftVal == 0.0)
                        {
                            throw new InvalidFormulaException("Cannot divide by zero.");
                        }
                        if (opStack.Pop() == "x")
                        {
                            resultVal = leftVal * rightVal;
                        }
                        else
                        {
                            resultVal = leftVal / rightVal;
                        }
                        numStack.Push(resultVal);
                    }
                }
                
            }

            //if operator stack empty
            if (opStack.Count == 0)
            {
                return numStack.Pop().ToString();
            }
            //if operator stack not empty
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

            return resultVal.ToString();
        }

        private bool IsNum(string token)
        {
            return double.TryParse(token, out _);
        }

        private bool IsOnTop<T>(Stack<T> stack, string token)
        {
            return stack.Count > 0 && stack.Peek().Equals(token);
        }

        //Errors/Exceptions: invalid Formulas, invalid methods
        public class InvalidFormulaException : Exception
        {
            public InvalidFormulaException(string message) : base(message) { }
        }
    }
}
