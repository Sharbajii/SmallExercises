using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {




            //List<string> list = new List<string>();
            //string input;
            //Console.WriteLine("enter strings and empty string to stop");
            //while((input =Console.ReadLine())!="")
            //{
            //    list.Add(input);

            //}
            //if(list.Count > 3)
            //{
            //    Console.WriteLine("the thired Element in the lsit ist: " + list[2]);
            //}
            //else
            //{
            //    Console.WriteLine("the List is samller than Elements.");
            //}




            //List<int> numbers= new List<int>();
            //int sum=0;
            //int inputt;
            //Console.WriteLine("enter a numbers and 0 to exit the program: ");
            //while ((inputt = Convert.ToInt32(Console.ReadLine())) != 0)
            //{
            //    numbers.Add(inputt);

            //}
            //if (numbers.Count > 3)
            //{
            //    Console.WriteLine($"the sum of {numbers[1]} and {numbers[2]} is {numbers[1] + numbers[2]}");
            //}
            //else
            //{
            //    Console.WriteLine("the List has less than 3 Elemnets");
            //}


            //List<string> strings= new List<string>();
            //string inputs;
            //Console.WriteLine("Enter some names: ");
            //while (( inputs = Console.ReadLine()) != "")
            //{
            //    strings.Add(inputs);

            //}
            //Console.WriteLine("Totel Names: "+strings.Count);




            //List<string> inputs = new List<string>();
            //string input;
            //Console.WriteLine("Enter values. Press enter on an empty line to stop:");
            //while (( input = Console.ReadLine()) != "")
            //{
            //    inputs.Add(input);
            //}
            //Console.WriteLine("Last value read: " + inputs[inputs.Count-1]);




            //List<string> list = new List<string>();
            //string input;
            //Console.WriteLine("Enter unputs");
            //while((input = Console.ReadLine()) != "")
            //{
            //    list.Add(input);
            //}
            //Console.WriteLine(list[0]);
            //Console.WriteLine(list[list.Count-1]);




            //List<int> list = new List<int>();
            //int input;
            //Console.WriteLine("Enter some Numbers: ");
            //while((input=Convert.ToInt32(Console.ReadLine()))!=-1)
            //{
            //    list.Add(input);
            //}
            //for(int i =0;i<list.Count;i++)
            //{
            //    Console.WriteLine(list[i]);
            //}




            //List<int> list = new List<int>();
            //int input;
            //Console.WriteLine("Enter some Numbers: ");
            //while ((input = Convert.ToInt32(Console.ReadLine())) != -1)
            //{
            //    list.Add(input);
            //}
            //Console.WriteLine("Enter start index:");
            //int startIndex = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter end index:");
            //int endIndex = int.Parse(Console.ReadLine());

            //Console.WriteLine("Numbers in the specified range:");
            //for (int i = startIndex; i <= endIndex; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}




            //List<int> list = new List<int>();
            //int input;
            //Console.WriteLine("Enter some Numbers: ");
            //while ((input = Convert.ToInt32(Console.ReadLine())) != -1)
            //{
            //    list.Add(input);
            //}

            //int max = int.MinValue;
            //foreach (int number in list)
            //{
            //    if (number > max)
            //    {
            //        max = number;
            //    }
            //}
            //Console.WriteLine("The greatest number is: " + max);





            //List<int> list = new List<int>();
            //int input;
            //Console.WriteLine("Enter some Numbers: ");
            //while ((input = Convert.ToInt32(Console.ReadLine())) != -1)
            //{
            //    list.Add(input);
            //}

            //Console.WriteLine("Enter a number to search for its index:");
            //int searchNumber = int.Parse(Console.ReadLine());

            //int index = list.IndexOf(searchNumber);
            //for(int i =searchNumber; i < list.Count; i++)

            //{
            //    Console.WriteLine("The number " + searchNumber + " was found at index " + index);
            //}





            //List<int> list = new List<int>();
            //int input;
            //Console.WriteLine("Enter some Numbers: ");
            //while ((input = Convert.ToInt32(Console.ReadLine())) != -1)
            //{
            //    list.Add(input);
            //}

            //int smallestNumber = list[0];
            //List<int> index = new List<int>();
            //index.Add(0);

            //for (int i = 1; i < list.Count; i++)
            //{
            //    if (list[i] < smallestNumber)
            //    {
            //        smallestNumber = list[i];
            //        index.Clear();
            //        index.Add(i);
            //    }
            //    else if (list[i] == smallestNumber)
            //    {
            //        index.Add(i);
            //    }

            //}

            //Console.WriteLine("Smallest number: " + smallestNumber);
            //Console.WriteLine("Index: " + string.Join(", ", index));





            //List<int> list = new List<int>();
            //int input;
            //int sum = 0;
            //Console.WriteLine("Enter some Numbers: ");
            //while ((input = Convert.ToInt32(Console.ReadLine())) != -1)
            //{
            //    list.Add(input);
            //}
            //sum= list.Sum();
            //Console.WriteLine("Sum of the List is: " + sum);



            //List<string> list = new List<string>();
            //string input;
            //Console.WriteLine("Enter unputs");
            //while ((input = Console.ReadLine()) != "")
            //{
            //    list.Add(input);
            //}
            //Console.WriteLine("Enter a name to search for it ");
            //string search=Console.ReadLine();
            //if (list.Contains(search))
            //{
            //    Console.WriteLine(search + " was found! ");
            //}
            //else
            //{
            //    Console.WriteLine(search+" was not found");
            //}




            ////PrintNumbersInRangeUserInput();

            //SumByUser();
            //List<string> strings = new List<string>();

            //strings.Add("First");
            //strings.Add("Second");
            //strings.Add("Third");

            //// Remember, this is how you print all the items in a list
            //strings.ForEach(Console.WriteLine);

            //RemoveLast(strings);
            //RemoveLast(strings);

            //strings.ForEach(Console.WriteLine);




            //int[] numbers = new int[] { 1, 2, 3, 4, 5 };

            //Console.WriteLine("Original array:");
            //foreach (int number in numbers)
            //{
            //    Console.Write(number + " ");
            //}

            //Console.WriteLine("\n\nEnter two indices to swap:");
            //Console.Write("Index 1: ");
            //int index1 = int.Parse(Console.ReadLine());
            //Console.Write("Index 2: ");
            //int index2 = int.Parse(Console.ReadLine());

            //int temp = numbers[index1];
            //numbers[index1] = numbers[index2];
            //numbers[index2] = temp;

            //Console.WriteLine("\nModified array:");
            //foreach (int number in numbers)
            //{
            //    Console.Write(number + " ");
            //}

            //Console.WriteLine("\n");





            //int[] numbers = { 18, 25, 37, 44, 53, 60, 72, 83, 94, 160 };
            //Console.WriteLine("Enter a number to search in the array: ");
            //int searchNumber = Convert.ToInt32(Console.ReadLine());

            //int index = -1;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] == searchNumber)
            //    {
            //        index = i;
            //        break;
            //    }
            //}

            //if (index == -1)
            //{
            //    Console.WriteLine("The number wasn't found in the array.");
            //}
            //else
            //{
            //    Console.WriteLine("The number was found at index " + index + ".");
            //}





            //int[] numbers = { 5, 1, 3, 4, 2 };
            //int sum = SumOfNumbersInArray(numbers);
            //Console.WriteLine(sum);


            //int[] testArray = { 1, 2, 3, 4, 5 };
            //PrintNeatly(testArray);



            //int[] array = { 10, 11, 13, 24, 12 };
            //PrintArrayInStars(array);




            //Console.WriteLine("Give a word: ");
            //string word=Console.ReadLine();
            //for (int i=0;i<3;i++)
            //{
            //    Console.Write(word);
            //}
            //Console.ReadKey();




            //Console.WriteLine("Give a string: ");
            //string user=Console.ReadLine();
            //if(user=="true")
            //{
            //    Console.WriteLine("You got it right!");
            //}
            //else
            //{
            //    Console.WriteLine("Try Again!");
            //}






            //Console.WriteLine("Enter username:");
            //string username=Console.ReadLine();
            //Console.WriteLine("Enter Password:");
            //string password=Console.ReadLine();
            //if(username=="alex" && password == "sunshine")
            //{
            //    Console.WriteLine("You have successfully logged in!");
            //} 
            //else if(username == "emma" && password == "haskell")
            //{
            //    Console.WriteLine("You have successfully logged in!");
            //}
            //else
            //{
            //    Console.WriteLine("Incorrect username or password!");
            //}


            //Console.WriteLine("enter a string");
            //string user=Console.ReadLine();
            //foreach (string arg in user.Split())
            //{
            //    Console.WriteLine(arg);
            //}





            //Console.WriteLine("Enter a string or press Enter to quit:");
            //string input = Console.ReadLine();

            //while (input != "")
            //{
            //    string[] words = input.Split(' ');
            //    foreach (string word in words)
            //    {
            //        if (word.Contains("av"))
            //        {
            //            Console.WriteLine(word);
            //        }
            //    }
            //    Console.WriteLine("Enter another string or press Enter to quit:");
            //    input = Console.ReadLine();
            //}




            //Console.WriteLine("Enter text (empty line to exit):");

            //string input;
            //while ((input = Console.ReadLine()) != string.Empty)
            //{
            //    string[] words = input.Split(' ');
            //    Console.WriteLine(words[0]);
            //}






            //Console.WriteLine("Enter text (empty line to exit):");

            //string input;
            //while ((input = Console.ReadLine()) != string.Empty)
            //{
            //    string[] words = input.Split(' ');
            //    Console.WriteLine(words[words.Length-1]);
            //}
















        }

        public static void PrintNumbersInRangeUserInput()
        {
            int userInput;
            List<int> numbers = new List<int>();
            Console.WriteLine("Enter numbers");
            while((userInput = Convert.ToInt32(Console.ReadLine())) != 0)
            {
                numbers.Add(userInput);
            }
           
            Console.WriteLine("Enter the lowerlimit: ");
            int lowerLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Upperlimit: ");
            int upperLimit= Convert.ToInt32(Console.ReadLine());
            PrintNumbersInRange(numbers, lowerLimit, upperLimit);
        }

        public static void PrintNumbersInRange(List<int> numbers, int lowerLimit, int upperLimit)
        {
            Console.WriteLine("Numbers in the rage [ " + lowerLimit+ " , " + upperLimit +" ]:");
            foreach(int number in numbers)
            {
                if(number > lowerLimit && number < upperLimit)
                {
                    Console.WriteLine(number);
                }
            }
            
        }




        public static void SumByUser()
        {
            int input=1;
            List<int> numbers = new List<int>();
            Console.WriteLine("enter numbers");
            while (input != 0)
            {
                input = Convert.ToInt32(Console.ReadLine());
                if (input == 0)
                {
                    break;

                }
                numbers.Add(input);
                
            }
          Console.WriteLine("the sum is: "+ Sum(numbers));
            
        }

        public static int Sum(List<int> numbers)
        {
           
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
               
            }
           

              return numbers.Sum();
            

           
        }



        public static void RemoveLast(List<string> strings)
        {
            if (strings.Count > 0)
            {
                strings.RemoveAt(strings.Count - 1);
            }
        }





        public static int SumOfNumbersInArray(int[] array)
        {
            int sum=0;
            int[] ints = new int[] { 5, 4, 3, 2, 1 };
            foreach(int i in ints)
            {
                 sum = sum + i;

            }
            return sum;

        }



        public static void PrintNeatly(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i != array.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }




        public static void PrintArrayInStars(int[] array)
        {
            foreach (int num in array)
            {
                for (int i = 0; i < num; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }


    }
}
