using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        private static void FibonacciRecursiveInput()
        {

            Console.WriteLine("Enter a Number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The " + n + "th Fibonacci number (Recursive) is: " + FibonacciRecursive(n));
        }

        public static int FibonacciRecursive(int n)
        {
            if (n == 0 || n == 1)
                return n;
            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }



        private static void FibonacciIterativeInput()
        {
            Console.WriteLine("Enter a Number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The " + n + "th Fibonacci number (Iterative) is: " + FibonacciIterative(n));
            Console.ReadLine();
        }

        public static int FibonacciIterative(int n)
        {
            int a = 0, b = 1, c = 0;
            if (n == 0)
                return a;
            for (int i = 2; i <= n; i++)
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

