using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowersOfNumber
{
    class MethodLibrary
    {
        public static string GetUserInput(string message)
        {
            Console.Write($"\n{message} ");
            return Console.ReadLine();
        }

        public static int ParseUserInputAsInteger(string input, string message = "")
        {
            if (int.TryParse(input, out int result))
            {
                return result;
            }
            else
            {
                return ParseUserInputAsInteger(GetUserInput($"There was an error! Try again. {message}"));
            }
        }

        public static void Display(string message)
        {
            Console.Write($"{message, -15}");
        }

        public static int SquaresOfNumber(int number)
        {
             return number * number;
        }

        public static int CubeOfNumber(int number)
        {
            return number * number * number;
        }

        public static bool Confirmation(string message, string trueOption, string falseOption = "")
        {
            if (trueOption.ToLower().StartsWith(GetUserInput(message), StringComparison.InvariantCultureIgnoreCase))
            {
                return true;
            }
            return false;
        }

    }
}
