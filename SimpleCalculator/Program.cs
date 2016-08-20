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
            string intialPrompt = "[x]>"; // x is my counter
            int counter = 0;
            bool continued = true;
            char[] possibleOperators = { '/', '*', '-', '+', '%' };
            int[] possibleDigits = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            
            List<string> Escape = new List<string>() { "quit", "exit", "escape" }; // req exit commands

            while (continued == true)
            {
                Console.Write("[" + counter++ + "]>");

                string user_expression = Convert.ToString(Console.ReadLine().ToLower());
                // need to separate operands & operators

            if (Escape.Contains(user_expression))
                {
                    continued = false;
                    Environment.Exit(0); //"use 0 to indicate success" or something
                }
            }
        }
    }
}
