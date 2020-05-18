using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Calculator
{
    public static class Calculate
    {
        public static bool InputMethod()
        {
            var symbol = Console.ReadLine();
            if (String.IsNullOrEmpty(symbol))
            {
                Console.WriteLine("You didn't choose anything");
                return true;
            }
            if (symbol.ToLower() == "exit")
            {
                return false;
            }
            IdentityOperations(symbol);
            return true;
        }

        public static void IdentityOperations(string input)
        {
            var arrayOfNumbers = Regex.Matches(input, "[0-9]+").Cast<Match>().Select(i => i.Value).ToArray();
            var arrayOfOperations = Regex.Matches(input, @"[*/+-]").Cast<Match>().Select(i => i.Value).ToArray();

            double[] numbersToBeCalculated = Array.ConvertAll(arrayOfNumbers, double.Parse);
            char[] operations = Array.ConvertAll(arrayOfOperations, char.Parse);

            double result = numbersToBeCalculated[0];

            var j = 0;
            for (var i = 1; i < numbersToBeCalculated.Length; i++)
            {
                switch (operations[j])
                {
                    case '+':
                        result += numbersToBeCalculated[i];
                        break;
                    case '-':
                        result -= numbersToBeCalculated[i];
                        break;
                    case '*':
                        result *= numbersToBeCalculated[i];
                        break;
                    case '/':
                        result /= numbersToBeCalculated[i];
                        break;
                    default:
                        break;
                }
                j++;
            }
            Console.WriteLine($" = {result}");
            Console.WriteLine("Type \"exit\" to leave.");
        }
    }
}
