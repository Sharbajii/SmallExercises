using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortint
{
    class Program
    {
        private static void Random()
        {

            Random numbers = new Random();

            int[] randomNumber = Enumerable.Range(0, 10).Select(xb => numbers.Next(-50, 100)).ToArray();

            Console.WriteLine("Original array: " + string.Join(", ", randomNumber));

            Console.WriteLine();

            SortArrayValue(randomNumber);

            int[] sortedArr = SortArrayValue(randomNumber);

            Console.WriteLine("Sorted array: " + string.Join(", ", sortedArr));
            
        }


        public static int[] SortArrayValue(int[] arr)
        {
            //Mal versuchen, ohne Array.Sort zu lösen
            int[] sortedArr = arr.ToArray();


            Array.Sort(sortedArr);


            return sortedArr;
        }


        private static void RandomNumbers()
        {

            Random rng = new Random();

            int[] randomNumber = Enumerable.Range(0, 10).Select(x => rng.Next(-50, 100)).ToArray();

            Console.WriteLine("Original : " + string.Join(", ", randomNumber));

            Console.WriteLine();

            BubbleSort(randomNumber);

            Console.WriteLine("Sorted : " + string.Join(", ", randomNumber));

        }



        public static void BubbleSort(int[] array)
        {
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);
        }


        public static void BubbleSortClassic(int[] array)
        {
            for (int maxEnd = array.Length ; maxEnd > 0; maxEnd--)
            {
                for (int i = 0; i < maxEnd; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        
                    }
                }
            }
        }


        static void Main(string[] args)
        {
            


            /* a) Schreibe eine MEthode, die ein Array von integers als parameter nimmt uind diese Sortiert (in place) - wie aufgabe 2. Schreibe dabei den Sortieralgorithmus selbst!
         * b) Untersuche die Performance dieser Methode, also wie lange braucht die Methode um arrays unterschiedlicher Größe zu sortieren. Verwende dazu Arrays aus zufallszahlen.
         * c) Verghleiche die Performance mit Array.Sort
         * */

            //Random();

            //Console.WriteLine("\n");

            //RandomNumbers();

            //Console.ReadLine();

        }


        static void GetRandomNumbers(int arraySize, int minValue, int maxValue)
        {
            Random random = new Random();
            int[] array = new int[arraySize];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(minValue, maxValue);
            }
        }




        public static void ComparePerformance(int arraySize, int minValue, int maxValue, int iteration)
        {
             arraySize = 10000;
             minValue = 0;
             maxValue = 100;



            //first your method
            /* start measuring time -> StopWatch
             * repeat iteration time
             *     generate array of size arraySize with randomnumbers bnetween minValue and maxvalue
             *     sort via bubblesort
             * stop measuring time
             **/

            //do the same with array.sort

            //output the time 
            //not array.sort
        }


    }
}
