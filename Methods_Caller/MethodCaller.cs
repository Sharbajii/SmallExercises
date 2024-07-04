using Factorial_Exercises;
using Recursion_;
using Square_Root;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsCaller
{
    public class MethodCaller
    {

        public static void FindValueInputs()
        {
            Console.WriteLine(" Enter a Number Its Value: ");
            double y = Convert.ToDouble(Console.ReadLine());
            double x1 = 0, x2 = 0;
            FindValues(y, ref x1, ref x2);
            Console.WriteLine("X_1 = " + x1);
            Console.WriteLine("X_2 = " + x2);
        }

        static void FindValues(double y, ref double x_l, ref double x_h)
        {
            x_l = 0;
            x_h = 1;
            while (x_l * x_l < y)
            {
                x_l++;
            }
            while (x_h * x_h <= y)
            {
                x_h++;
            }
        }



        static void MethodsCaller()
        {

             //choice = 0;
            Console.WriteLine("Welcome to the Methods Calculator");
            Console.WriteLine();
            Console.WriteLine("Which method would you like to use? or Press (0) to End:");
            Console.WriteLine("\t1. Fibonacci-Recursive");
            Console.WriteLine("\t2. Fibonacci-Iterative");
            Console.WriteLine("\t3. Factorial-Recursive");
            Console.WriteLine("\t4. Factorial-Iterative");
            Console.WriteLine("\t5. Square Root");
            Console.WriteLine("\t0. To Exit");


            while (true)
            {
                Console.WriteLine("Enter your choice:");
                int choice = int.Parse(Console.ReadLine());
               
                
                if (choice == 0)
                {
                    Console.WriteLine("Bye");
                    break;
                }
                switch (choice)
                {

                    case 1:
                        Recurion.FibonacciRecursiveInput();
                        break;
                    case 2:
                        Recurion.FibonacciIterativeInput();
                        break;
                    case 3:
                        Factorial.FactorialRecursiveIput();
                        break;
                    case 4:
                        Factorial.FactorialIterativeInput();
                        break;
                    case 5:
                        double result = Sqrt.SqrtUserInPut();
                        Console.WriteLine(result);
                        break;
                    case 6:
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;

                }
            }
        }

        static void Main(string[] args)
        {
            MethodsCaller();


        }
    }
}
