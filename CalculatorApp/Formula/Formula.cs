using System.Collections;

namespace Formula
{
    public class Formula
    {
        string formulaString = "";

        ArrayList tokenList = new ArrayList();

        public Formula(string formula)
        {
            formulaString = formula;

            if (!isValidFormula())
            {
                //throw something
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

        private bool isValidFormula(out object result)
        {
            createTokenList();


            result = "";

            


            return true;
        }

        //token checks

        //evalute method

        //public string Evaluate() {}

        //Errors/Exceptions: invalid Formulas, invalid methods

        //private class BadSyntax

        //no need for variables
    }
}
