using System.Collections;

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
            foreach (char token in formulaString)
            {
                tokenList.Add(token);
            }
        }

        //Check if valid Formula Method

        private bool isValidFormula(out string errorMessage)
        {
            createTokenList();


            errorMessage = "";

            


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
