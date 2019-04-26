using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowersOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            bool _continue = true;

            while (_continue)
            {
                int input = MethodLibrary.ParseUserInputAsInteger(MethodLibrary.GetUserInput("Give me a number: "),
                    "I need a number: ");

                Console.WriteLine("\n\n");
                MethodLibrary.Display("Number");
                MethodLibrary.Display("Square");
                MethodLibrary.Display("Cube");
                Console.WriteLine();
                MethodLibrary.Display("==========");
                MethodLibrary.Display("==========");
                MethodLibrary.Display("==========");

                Console.WriteLine("\n");

                for (int i = 1; i <= input; i++)
                {
                    MethodLibrary.Display(i.ToString());
                    MethodLibrary.Display(MethodLibrary.SquaresOfNumber(i).ToString());
                    MethodLibrary.Display(MethodLibrary.CubeOfNumber(i).ToString());
                    Console.WriteLine("\n");
                }

                _continue = MethodLibrary.Confirmation("<Y> to exit: ", "y");
            }
        }
    }
}
