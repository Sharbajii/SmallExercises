using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LF5KassenArbeitVorbereitung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i=0;
            //while (i <= 10)
            //{
            //    i++;
            //    Console.WriteLine(i);
            //}

            //for (int i = 1; i <=10;i++)
            //{
            //    Console.WriteLine(i);
            //}

            //int i = 0;
            //do
            //{
            //    i++;
            //    Console.WriteLine(i);
            //}while (i < 10);
            while (true)
            {
                Console.WriteLine("Enter a number to get the corresponding day (1-7), or enter 0 to exit:");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num == 0)
                {
                    Console.WriteLine("Bye");
                    break;
                }
                else if (num < 1 || num > 7)
                {
                    Console.WriteLine("You entered an invalid number. Please enter a number between 1 and 7.");
                    continue;
                }

                switch (num)
                {
                    case 1:
                        Console.WriteLine("Montag");
                        break;
                    case 2:
                        Console.WriteLine("Dienstag");
                        break;
                    case 3:
                        Console.WriteLine("Mittwoch");
                        break;
                    case 4:
                        Console.WriteLine("Donnerstag");
                        break;
                    case 5:
                        Console.WriteLine("Freitag");
                        break;
                    case 6:
                        Console.WriteLine("Samstag");
                        break;
                    case 7:
                        Console.WriteLine("Sonntag");
                        break;
                }
            }

        }
        public static void Anas()
        {

        }
        public static int Anas1()
        {
            return 1;
        }
        public static void Anas2(int b)
        {

        }
    }
}
