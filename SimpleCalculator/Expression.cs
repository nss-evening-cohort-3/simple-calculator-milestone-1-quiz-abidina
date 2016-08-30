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
        string expressionOperandL { get; set; }
        string expressionOperandR { get; set; }
        char[] possibleDigits = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };

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
            string expressionOperator = user_expression[getOperatorIndex(user_expression)].ToString(); //ToString converts any value to a string
            return expressionOperator;
        }

        public int getOperandLIndex(string user_expression)
        {
            int indexOfOperandL = user_expression.IndexOfAny(possibleDigits); 
            return indexOfOperandL;
        }

        public int getOperandRIndex(string user_expression)
        {
            int indexOfOperandR = user_expression.LastIndexOfAny(possibleDigits);
            return indexOfOperandR; // still runs even if there's only one digit, so there are always 2 in my userOperands list
        }

        public int getOperandL(string user_expression)
        {
            int expressionOperandL = user_expression[getOperandLIndex(user_expression)];
            return expressionOperandL; 
        }

        public int getOperandR(string user_expression)
        {
            int expressionOperandR = user_expression[getOperandRIndex(user_expression)];
            return expressionOperandR;
        }
    }
}
