using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhereToBegin
{
    internal class Program
    {
       
        public static void NumbersAndCalculations()
        {
            int sum=0;
            int count=0;
            double average = 0;
            int evenCount = 0, oddCount = 0;
            while (true)
            {
                Console.WriteLine("Give a Number");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num == -1)
                {
                    break;
                }

                sum += num;
                count++;

                if (count > 0)
                {
                    average = (double)sum / count;
                }

                if(num % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
                
            }

            Console.WriteLine("Thxx!, Bye!");
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Count: " + count);
            Console.WriteLine("Average: " + average);
            Console.WriteLine("even: " + evenCount);
            Console.WriteLine("Odd: " + oddCount);
        }


        private static void Phrase()
        {
            Console.WriteLine("How many times ?");
            int times = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < times; i++)
            {
                PrintPhrase();
            }
        }
        public static void PrintPhrase()
        {
            Console.WriteLine("In a hole in the ground there lived a method.");
        }


        public static void PrintUntilNumber(int number)
        {
           
            for(int i=1; i <= number; i++)
            {
                Console.WriteLine(i);
            }
        }


        public static void PrintFromNumberToOne(int number)
        {
            
            for (int i = number; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }


        public static void Division(int numerator, int denominator)
        {
            double result = (double)numerator / denominator;
            Console.WriteLine(result);
        }


        public static void DivisibleByThreeInRange(int beginning, int end)
        {
            for (int i = beginning; i <= end; i ++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
              
            }
        }


        public static int NumberUno()
        {
            return 1;
        }


        public static string Word()
        {
            return "Hello";
        }


        public static int Sum(int number1, int number2, int number3, int number4)
        {
            
            int sum=number1+ number2+number3+number4;
            return sum;
        }


        public static int Smallest(int number1, int number2)
        {
            return (number1<number2) ? number1 : number2;
        }


        public static int Greatest(int number1, int number2, int number3)
        {
            if(number1>number2 && number1 > number3)
            {
                return number1;
            }
            else if(number2>number1 && number2>number3)
            {
                return number2;
            }
            else 
            {
                return number3;
            }
            
        }


        public static void PrintStars(int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.Write("*");
            }
             Console.WriteLine();
        }


        public static void PrintSquare(int size)
        {
            for(int i = 0; i <size; i++)
            {
                PrintStars(size);
            }
        }


        public static void PrintRectangle(int width, int height)
        {
            for(int i=0; i<height; i++)
            {
                PrintStars(width);
              
            }
        }


        public static void PrintTriangle(int size)
        {
            for(int i = 0 ; i <= size; i++)
            {
                PrintStars(i);
            }
        }


        public static void PrintSpaces(int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.Write(" ");
            }
        }


        public static void PrintRightTriangle(int size)
        {
            for(int i = 1; i <= size; i++)
            {
                PrintSpaces(size-i);
                PrintStars(i);
              Console.WriteLine();
            }
        }


        public static void ChristmasTree(int height)
        {
            for(int i= 1; i <= height; i++)
            {
                PrintSpaces(height - i);
                PrintStars(i * 2 - 1);
                Console.WriteLine();
            }
            for(int i = 1; i <= 2; i++)
            {
                PrintSpaces(height - 2);
                PrintStars(3);
                Console.WriteLine();
            }
        }



        static void Main(string[] args)
        {

            // NumbersAndCalculations();                                              //Exercise 2-8

            //Phrase(); //Exercise 2-9 und 2-10

            // PrintUntilNumber(5);                                                   //Exercise 2-11

            // PrintFromNumberToOne(5);                                               //Exercise 2-12

            //Division(6,2); //Exercise 2-13

            //DivisibleByThreeInRange(2,10);                                          //Exercise 2-14

            //int mun = NumberUno();                                                  //Exercise 2-15
            //Console.WriteLine(mun);

            //string man=Word();                                                      //Exercise 2-16
            //Console.WriteLine(man);


            //int answer = Sum(4, 3, 6, 1);                                           //Exercise 2-17
            //Console.WriteLine("Sum: " + answer);

            //int answer = Smallest(20, 7);                                           //Exercise 2-18
            //Console.WriteLine("Smallest: " + answer);

            //int answer = Greatest(112, 50, 13);                                     //Exercise 2-19
            //Console.WriteLine("Greatest: " + answer);

            //PrintStars(10);                                                         //Exercise 2-20.1  
            //PrintStars(20);

            //PrintSquare(10);                                                        //Exercise 2-20.2


            //PrintRectangle(17,3);                                                   //Exercise 2-20.3


            //PrintTriangle(4);                                                       //Exercise 2-20.3  


            // PrintRightTriangle(6);                                                  //Exercise 2-21.1   



            //ChristmasTree(10);                                                        //Exercise 2-21.2     



            





        }
    }

}      


    

