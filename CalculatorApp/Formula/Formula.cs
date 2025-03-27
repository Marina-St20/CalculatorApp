using System.Collections;
using System.Text.RegularExpressions;

namespace Formula
{
    public class Formula
    {
        string formulaString = "";

        List<string> tokenList = new List<string>();

        public Formula(string formula)
        {
            formulaString = formula;

            createTokenList();

            if (!isValidFormula(out string errorMessage))
            {
                throw new InvalidFormulaException(errorMessage);
            }


        }

        //string to token list (dont care about spaces)

        private void createTokenList()
        {
            string pattern = @"\d+(\.\d+)?|[%+\-*/()]";
            MatchCollection matches = Regex.Matches(formulaString, pattern);

            foreach (Match match in matches)
            {
                tokenList.Add(match.Value);
            }
        }

        //Check if valid Formula Method

        private bool isValidFormula(out string errorMessage)
        {
            errorMessage = string.Empty;
            //closing parentheses rule <<in calcform.cs
                //at no point should the number of closing parentheses seen so far be greater than the number of opening parentheses seen so far

            //balanced paraenthese rule <<in calcform.cs
                //the total number of opening parentheses must equal the total number of closing parentheses

            //first token rule <<in calcform.cs
                //first token must be a number, variable, or (

            //last token rule <<in calcform.cs
                //last token must be a number, variable, or ) <<if not, equals will do nothing

            //parenthesis/operator following rule
                //any token after a ( or operator must be a number, variable, or (

            //extra following rule
                //any token after a number, variable, or ) must be an operator or )

            return true;
        }

        //token checks

        //evalute method

        //public string Evaluate() {}

        //Errors/Exceptions: invalid Formulas, invalid methods
        public class InvalidFormulaException : Exception
        {
            public InvalidFormulaException(string message) : base(message) { }
        }

        //private class BadSyntax

        //no need for variables
    }
}
