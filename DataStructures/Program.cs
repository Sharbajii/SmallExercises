using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class Program
    {


        static void Main(string[] args)
        {

            List<int> listt = new List<int>();          //Creating a new list is done with the command List<type> list = new List<type>();
            listt.Add(1);

            List<string> strings = new List<string>();
            strings.Add("what are you up to ?");

            List<double> doubles = new List<double>();
            doubles.Add(5.7);

            List<bool> bools = new List<bool>();                        //Listing begins with index 0 like Array
            bools.Add(true);


            List<int> intergers = new List<int>();
            int integer = 1;
            intergers.Add(integer);

            List<double> doubls = new List<double>();
            double d = 3.5;
            doubles.Add(d);


            List<string> wordList = new List<string>();
            wordList.Add("one");
            wordList.Add("two");
            wordList.Add("three");

            //Console.WriteLine(wordList[2]);


            //first exercise (Listing)

            List<string> students = new List<string>();
            students.Add("Anas");
            students.Add("Bara");
            students.Add("Atilla");                                  //simple example where we print a list containing five values.
            students.Add("Ahmad");
            students.Add("Sarah");

            //Console.WriteLine(students[0]);
            //Console.WriteLine(students[1]);
            //Console.WriteLine(students[2]);
            //Console.WriteLine(students[3]);
            //Console.WriteLine(students[4]);



            List<string> list = new List<string>();

            //Console.WriteLine(" Number of Values on the List: "+list.Count);      //The number of values on a list is provided with the list’s Count property,
            //list.Add("one");                                                      //which returns the number of elements the list contains.
            //Console.WriteLine(" Number of Values on the List: " + list.Count);        
            //list.Add("Second");
            //int values=list.Count;
            //Console.WriteLine(" Number of Values on the List: " + values);







            List<string> studentss = new List<string>();
            studentss.Add("Anas");
            studentss.Add("Bara");                                    //Calling the list through using while Loop ,For Loop and foreach
            studentss.Add("Atilla");
            studentss.Add("Ahmad");
            studentss.Add("Sarah");

            int index = 0;

            while (index < studentss.Count)
            {
                //Console.WriteLine(studentss[index]);
                index++;

            }
            // Console.WriteLine();
            for (int indexx = 0; indexx < studentss.Count; indexx++) 
            {
                //Console.WriteLine(studentss[indexx]);
            }
            
            //Console.WriteLine();

            foreach (string s in studentss)
            {
                //Console.WriteLine(s);
            }


            List<int> numbersss = new List<int>();
            numbersss.Add(1);
            numbersss.Add(2);
            numbersss.Add(3);
            numbersss.Add(4);
            numbersss.Add(5);
            numbersss.Add(6);

            
            for (int numss = 0; numss < numbersss.Count; numss++)
            {
                //int number = numbers[numss];                     <==//alternatively
                //Console.WriteLine(number);

                // Console.WriteLine(numbers[nums]);
            }



            List<string> teachers = new List<string>();
            teachers.Add("Samuel");
            teachers.Add("Baz");
            teachers.Add("Ann");
            teachers.Add("Anna");
            teachers.Add("Anna");

            teachers.RemoveAt(1);                             // we use this method to remove one of the index 
            teachers.Remove("Anna");                          //same thing goes here too but the defferenz is you need to know the Value of the item


            foreach (string teacher in teachers)
            {
                //Console.WriteLine(teacher);

            }



            List<int> nummers = new List<int>();
            nummers.Add(1);
            nummers.Add(2);
            nummers.Add(3);
            nummers.Add(4);

            //Console.WriteLine("does the list contain Number 3 ? " + nummers.Contains(3));

            if (nummers.Contains(4))
            {
                //Console.WriteLine("we have Number 4 ");
            }



            List<int> nums = new List<int>();
            nums.Add(1);
            nums.Add(2);
            nums.Add(3);
            nums.Add(4);
            Print(nums);



            List<int> random = new List<int>();
            random.Add(1);
            random.Add(2);
            random.Add(3);
            random.Add(4);
            random.Add(5);
            random.Add(6);
            random.Add(7);
            random.Add(8);
            random.Add(9);
            random.Add(1);
            random.Add(2);
            random.Add(3);
            random.Add(4);
            PrintSmallerThan(random, 4);




            List<int> random2 = new List<int>();
            random2.Add(1);
            random2.Add(2);
            random2.Add(3);
            random2.Add(4);
            random2.Add(5);
            random2.Add(6);
            random2.Add(7);
            //random2.ForEach(Console.WriteLine);

            //Console.WriteLine( Average(random2));



            List<int> numberssss = new List<int>();
            numberssss.Add(3);
            numberssss.Add(2);
            numberssss.Add(6);
            numberssss.Add(-1);

            //Console.WriteLine("First print: ");
            //numberssss.ForEach(Console.WriteLine);

            RemoveFirst(numberssss);

            //Console.WriteLine("Second print: ");
            //numberssss.ForEach(Console.WriteLine);

            RemoveFirst(numberssss);
            RemoveFirst(numberssss);
            RemoveFirst(numberssss);

            //Console.WriteLine("Third print: ");
            //numberssss.ForEach(Console.WriteLine);

        }


        public static void Print(List<int> list)
        {
            foreach (int value in list)
            {
                //Console.WriteLine(value);

            }
        }


        public static void PrintSmallerThan(List<int> numbers, int thershold)
        {
            foreach (int number in numbers)
            {
                if (number <= thershold)
                {
                    //Console.WriteLine(number);
                }
            }
        }


        public static int Average(List<int> numbers)
        {
            if (numbers.Count == 0)
            {
                return -1;
            }
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum / numbers.Count;
        }


        public static void RemoveFirst(List<int> numbers)
        {
            if (numbers.Count == 0)
            {
                return;
            }

            numbers.RemoveAt(0);
        }




    }
}
