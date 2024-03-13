using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float number1;
            float number2;
            string userOperation;

            Console.WriteLine("Enter first number");
            number1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number");
            number2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter operation: + - / *");
            userOperation = Console.ReadLine();

            float result = 0;

            switch (userOperation)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "/":
                    result = number1 / number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
            }

            Console.WriteLine("Result is " + result);
            Console.ReadKey();
        }
    }
}
