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

            Expression expression = new Expression(); // so you can access methods in expression

            List<string> Escape = new List<string>() { "quit", "exit", "escape" }; // req exit commands

            while (continued == true)
            {
                Console.Write("[" + counter++ + "]>");

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
                if (possibleOperators.Any(currentOperator => user_expression.Contains(currentOperator)))
                {
                    Console.Write(expression.getOperator(user_expression));
                }
                else
                {
                    Console.WriteLine("Please enter an operator (ex. +, -, /, *, %)");
                }

                if (possibleDigits.Any(currentDigitL => user_expression.Contains((currentDigitL).ToString())))
                {
                    Console.WriteLine(expression.getOperandL(user_expression));
                }
                //else if (currentDigitL = null || )
                //{
                //    Console.WriteLine("Please enter a digit 0-9.");
                //}  THIS NEED TO MAKE SURE THAT EACH OPERAND IS NOT NULL 
                else
                {
                    Console.WriteLine("Please enter a digit 0-9.");
                }

                if (possibleDigits.Any(currentDigitR => user_expression.Contains((currentDigitR).ToString())))
                {
                    Console.WriteLine(expression.getOperandR(user_expression));
                }
                else
                {
                    Console.WriteLine("Please enter a digit 0-9.");
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
