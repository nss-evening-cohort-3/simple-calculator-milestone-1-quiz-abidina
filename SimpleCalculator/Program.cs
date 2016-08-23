using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //string intialPrompt = "[x]>"; // x is my counter
            int counter = 0;
            bool continued = true;
            char[] possibleOperators = { '/', '*', '-', '+', '%' };
            int[] possibleDigits = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            List<string> Escape = new List<string>() { "quit", "exit", "escape" }; // req exit commands

            while (continued == true)
            {
                Console.Write("[" + counter++ + "]>");

                Expression expression = new Expression(); // so you can access methods in expression

                string user_expression = Convert.ToString(Console.ReadLine().ToLower());

                List<string> userOperands = new List<string>();
                userOperands.Add(expression.getOperandL(user_expression));
                userOperands.Add(expression.getOperandR(user_expression));

                // ------------ testing stuff --------------- //
                Console.WriteLine(expression.getOperandL(user_expression));
                Console.WriteLine(expression.getOperandR(user_expression));
                Console.WriteLine(userOperands.Count);
                foreach (string n in userOperands)
                {
                    Console.Write(n);
                }    // all of the tests were working, i should be accessing the correct info, but it ... doesn't?
                Console.WriteLine(expression.getOperator(user_expression));


                // exit program 
                if (user_expression.Contains(expression.getOperator(user_expression)))
                {
                    Console.Write(expression.getOperator(user_expression));
                }
                else if (Escape.Contains(user_expression))
                {
                    continued = false;
                    Environment.Exit(0); //use 0 to indicate success
                } else if (userOperands.Count > 2 || userOperands.Count < 2) {
                    Console.Write("Please enter two numbers."); // why does it know the userOperands count outside of the if else?
                } else if (userOperands.Count == 2) { Console.Write(":)"); } // THIS IS VERY BROKEN. It quits when any letters are typed and passes as valid whenever numbers are typed

                // make sure user input is 2 operands & an operator, return error if not

            }
        }
    }
}
