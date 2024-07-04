using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial_Exercises
{
    public class Factorial
    {
        public static void FactorialRecursiveIput()
        {
            Console.WriteLine("Enter a Number to Find its Factor: ");
            int num =int.Parse(Console.ReadLine());
            Console.WriteLine("Recursive Factorial of " + num + " is: " + FactorialRecursive(num));
        }

        public static int FactorialRecursive(int input)
        {
            if (input == 1)
            {
                return 1;
            }
            return input * FactorialRecursive(input - 1);
        }


        public static  void FactorialIterativeInput()
        {
            Console.WriteLine("Enter a Number to find its Factor: ");
            int num=int.Parse(Console.ReadLine());
            Console.WriteLine("Iterative Factorial of " + num + " is: " + FactorialIterative(num));
        }

        public static int FactorialIterative(int input)
        {
            int result = 1;
            for (int i = 1; i <= input; i++)
            {
                result *= i;
            }
            return result;
        }


        static void Main(string[] args)
        {

            FactorialRecursiveIput();
            Console.WriteLine();
            FactorialIterativeInput();
         
        }
    }
}
