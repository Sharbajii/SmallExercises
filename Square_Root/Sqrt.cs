using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Root
{
    public class Sqrt
    {
        public static double SqrtUserInPut()
        {
            Console.WriteLine("Enter a number to Calculate it's Square root:  ");
            double user = Convert.ToDouble(Console.ReadLine());
            return Sqrtt(user);
        }

        public static double Sqrtt(double y)
        {
            if (y < 0)
            {
                throw new ArgumentException("Input must be Positive");
            }

            double lowerbound = 0;
            double upperbound = y;

            //comparing the "distance" of the result (y vs y_m) instead of the size of the interval
            while (Math.Abs(upperbound - lowerbound) > 0.00001)
            {
                double mid = (lowerbound + upperbound) / 2;


                if (mid * mid > y)
                    upperbound = mid;

                else
                    lowerbound = mid;
            }
            return (lowerbound + upperbound) / 2;
        }



        public static void FindValueInputs()
        {
            Console.WriteLine(" Enter a Number: ");
            double input = Convert.ToDouble(Console.ReadLine());
            double x1 = 0, x2 = 0;
            FindValues(input, ref x1, ref x2);
            Console.WriteLine("X_1 = " + x1);
            Console.WriteLine("X_2 = " + x2);
        }

        static void FindValues(double y, ref double x_l, ref double x_h)
        {
            x_l = 0;
            x_h = y;
            while ((x_h - x_l) > 0.00001)
            {
                double mid = (x_l + x_h) / 2;
                if (mid * mid < y)
                {
                    x_l = mid;
                }
                else
                {
                    x_h = mid;
                }
            }
        }


      

      




        static void Main(string[] args)
        {

            //Console.WriteLine(SqrtUserInPut());
            //Console.ReadKey();

            //FindValueInputs();
            //Console.ReadKey();

            //CalculateSquareInput(3);

            var result = SqrtUserInPut();
            Console.WriteLine(result);

            int x = 15;
            Console.WriteLine($"Before call1: {x}");
            IncreaseWithoutRef(x);
            Console.WriteLine($"After call1: {x}");
            IncreaseWithRef(ref x);
            Console.WriteLine($"After call2: {x}");
            Console.ReadLine();
        }


        public static void IncreaseWithoutRef(int x)
        {
            Console.WriteLine("without ref:");
            Console.WriteLine($"before: {x}");
            x = x + 1;
            Console.WriteLine($"after: {x}");
        }

        public static void IncreaseWithRef(ref int x)
        {
            Console.WriteLine("with ref:");
            Console.WriteLine($"before: {x}");
            x = x + 1;
            Console.WriteLine($"after: {x}");
        }
    }
}
