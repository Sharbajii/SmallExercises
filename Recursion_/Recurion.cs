using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion_
{
   public  class Recurion
    {
        //The recursive method uses the formula F_n = F_(n-1) + F_(n-2) repeatedly to calculate the nth Fibonacci number.
        //It calls itself recursively until it reaches the base case of F_0=0 or F_1=1, and then it starts working its way back up,
        //adding the previous two Fibonacci numbers to get the current one.

        public static void FibonacciRecursiveInput()
        {

            Console.WriteLine("Enter a Number: ");
            int user = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The " + user + "th Fibonacci number (Recursive) is: " + FibonacciRecursive(user));
        }

        public static int FibonacciRecursive(int input)
        {
            if (input == 0 || input == 1)
                return input;
            return FibonacciRecursive(input - 1) + FibonacciRecursive(input - 2);
        }



        //The iterative method, on the other hand, uses a loop to calculate the nth Fibonacci number.
        //It starts with F_0=0 and F_1=1, and then uses the formula F_n = F_(n-1) + F_(n-2)
        //in each iteration of the loop until it reaches the nth number.

        public static void FibonacciIterativeInput()
        {
            Console.WriteLine("Enter a Number: ");
            int user = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The " + user + "th Fibonacci number (Iterative) is: " + FibonacciIterative(user));
            Console.ReadLine();
        }

        public static int FibonacciIterative(int input)
        {
            int a = 0, b = 1, c = 0;
            if (input == 0)
                return a;
            for (int i = 2; i <= input; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return b;
        }


        static void Main(string[] args)
        {
            FibonacciRecursiveInput();
            Console.WriteLine();
            FibonacciIterativeInput();

           
        }
    }
}
