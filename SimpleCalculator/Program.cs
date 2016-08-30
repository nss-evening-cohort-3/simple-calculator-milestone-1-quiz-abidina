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

                string user_expression = Console.ReadLine().ToLower();

                List<int> userOperands = new List<int>();
                userOperands.Add(expression.getOperandL(user_expression));
                userOperands.Add(expression.getOperandR(user_expression));

                // ------------ testing stuff --------------- //
                /* Console.WriteLine(expression.getOperandL(user_expression));
                Console.WriteLine(expression.getOperandR(user_expression));
                Console.WriteLine(userOperands.Count);
                foreach (string n in userOperands)
                {
                    Console.Write(n);
                }    
                Console.WriteLine(expression.getOperator(user_expression)); */

                if (user_expression.Contains(possibleOperators.ToString()))
                {
                    Console.Write(expression.getOperator(user_expression));
                }
                else
                {
                    Console.WriteLine("Please enter an operator (ex. +, -, /, *, %)");
                } 


                // exit program 
                if (Escape.Contains(user_expression))
                {
                    continued = false;
                    Environment.Exit(0); //use 0 to indicate success
                } else if (userOperands.Count > 2 || userOperands.Count < 2) {
                    Console.Write("Please enter two numbers."); 
                } else if (userOperands.Count == 2) { Console.Write(":)"); } 

                // make sure user input is 2 operands & an operator, return error if not

            }
        }
    }
}
