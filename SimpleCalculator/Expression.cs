using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Expression
    {
        public Expression() // is this necessary?
        {

        }
        string expressionOperator { get; set; }
        string operandL { get; set; }
        string operandR { get; set; }

        public int getOperatorIndex(string user_expression)
        {
            // make array of potential chars
            char[] possibleOperators = { '/', '*', '-', '+', '%' };
            // find index of any potential chars -- IndexOf only finds specific char, IndexOfAny can find any char in an array of chars
            int indexOfOperator = user_expression.IndexOfAny(possibleOperators);
            return indexOfOperator;
        }

        public string getOperator(string user_expression)
        {
            //nothing yet
            expressionOperator = user_expression[getOperatorIndex(user_expression)].ToString(); //ToString converts any value to a string
            return expressionOperator;
        }
    }
}
