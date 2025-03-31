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
