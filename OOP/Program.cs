using OOP.Exercise1;
using OOP.Exercise10;
using OOP.Exercise11;
using OOP.Exercise12;
using OOP.Exercise13;
using OOP.Exercise14;
using OOP.Exercise15;
using OOP.Exercise2;
using OOP.Exercise3;
using OOP.Exercise4;
using OOP.Exercise5;
using OOP.Exercise6;
using OOP.Exercise7;
using OOP.Exercise8;
using OOP.Exercise9;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Xml.Linq;
using static OOP.Program;

namespace OOP
{

    //class PersonWithoutProperties
    //{

    //    public string FirstName { get; set; }

    //    public string LastName { get; set; }

    //    public string FullName
    //    {
    //        get { return $"{FirstName} {LastName}"; }
    //    }


    //    //private string _name;

    //    //public string GetName()
    //    //{
    //    //    return _name;
    //    //}

    //    //public void SetName(string name)
    //    //{
    //    //    _name = name;
    //    //}


    //    //private int _age;

    //    //public int GetAge()
    //    //{
    //    //    return _age;
    //    //}

    //    //public void SetAge(int age)
    //    //{
    //    //    if (age < 0)
    //    //    {
    //    //        throw new ArgumentException("must be non-negative", nameof(age));
    //    //    }
    //    //    _age = age;
    //    //}


    //    private int _ageAsProperty;
    //    //public int AgeAsProperty
    //    //{
    //    //    get { return _ageAsProperty; }
    //    //    set { _ageAsProperty = value; }
    //    //}

    //    public int AgeAsAutoproperty { get; set; }

    //    //public string Foo { get; private set; }



    //}

    //public class xyz
    //{
    //    public void Foo()
    //    {
    //        PersonWithoutProperties person = new PersonWithoutProperties();

    //        person.SetAge(-4);

    //        person.AgeAsProperty = 4;

    //    }
    //}


    //class Person
    //{
    //    public string name { get; }
    //    public int age { get; set; }
    //    public int weight { get; set; }
    //    public int height { get; set; }

    //    public Person(string intialName):this(intialName, 0)
    //    {
    //        //this.name = intialName;
    //        //this.age = 0;
    //        //this.weight = 0;
    //        //this.height = 0;
    //    }

    //    public Person(string name, int age)
    //    {
    //        this.age = age;
    //        this.weight = 0;
    //        this.height = 0;
    //        this.name = name;
    //    }


    //    public double BodyMassIndex()
    //    {
    //        double heigthPerHundred = this.height / 100.0;
    //        return this.weight / (heigthPerHundred * heigthPerHundred);
    //    }


    //    public void GrowOlder()
    //    {
    //        if (this.age < 100)
    //        {
    //            this.age = this.age + 1;
    //        }
    //    }


    //    public bool IsOfLegalAge()
    //    {
    //        return this.age >= 18;
    //    }


    //    public override string ToString()
    //    {
    //        return this.name + ", age " + this.age + " years";
    //    }

    //}

    //public class Account
    //{
    //    public string Name { get; set; }
    //    public double Balance { get; set; }



    //    public Account(string name, double blanace)
    //    {
    //        this.Balance = blanace;
    //        this.Name = name;
    //    }
    //    public double balance()
    //    {
    //        return this.Balance;
    //    }

    //    public double Withdrawal(double amount)
    //    {
    //        if (amount < 0)
    //        {
    //            throw new ArgumentException("Withdrawal amount cannot be negative");
    //        }
    //        if (amount > Balance)
    //        {
    //            throw new ArgumentException("Insufficient funds");
    //        }
    //        return this.Balance = this.Balance - amount;
    //    }
    //    public double Deposit(double money)
    //    {
    //        if (money < 0)
    //        {
    //            throw new ArgumentException("Deposit amount cannot be negative");
    //        }
    //        return this.Balance += money;
    //    }

    //    public override string ToString()
    //    {
    //        return this.Name + " has this Amount of money : " + this.Balance + " Euro.";
    //    }




    //}


    public class Program
    {

        

        static void Main(string[] args)
        {
            {
                {

                    //Person pekka = new Person("Pekka");
                    //Person antti = new Person("Antti");

                    //pekka.GrowOlder();
                    //pekka.GrowOlder();

                    //antti.GrowOlder();

                    //Console.WriteLine("Pekka's age: " + pekka.ReturnAge());
                    //Console.WriteLine("Antti's age: " + antti.ReturnAge());
                    //int combined = pekka.ReturnAge() + antti.ReturnAge();

                    //Console.WriteLine("Pekka's and Antti's combined age " + combined + " years");


                    //Person pekka = new Person("Pekka");
                    //Person antti = new Person("Antti");

                    //int i = 0;
                    //int i = 0;
                    //while (i < 27)
                    //{
                    //    pekka.GrowOlder();
                    //    i = i + 1;
                    //}

                    //antti.GrowOlder();

                    //if (antti.IsOfLegalAge())
                    //{
                    //    Console.Write("Legal age: ");
                    //    antti.PrintPerson();
                    //}
                    //else
                    //{
                    //    Console.Write("Underage: ");
                    //    antti.PrintPerson();
                    //}

                    //if (pekka.IsOfLegalAge())
                    //{
                    //    Console.Write("Legal age: ");
                    //    pekka.PrintPerson();
                    //}
                    //else
                    //{
                    //    Console.Write("Underage: ");
                    //    pekka.PrintPerson();
                    //}


                    //Person pekka = new Person("Pekka");
                    //Person antti = new Person("Antti");

                    //int i = 0;
                    //while (i < 27)
                    //{
                    //    pekka.GrowOlder();
                    //    i = i + 1;
                    //}

                    //antti.GrowOlder();

                    //if (antti.IsOfLegalAge())
                    //{
                    //    Console.WriteLine(antti.name + " is of legal age.");
                    //}
                    //else
                    //{
                    //    Console.WriteLine(antti.name + " is underage.");
                    //}

                    //if (pekka.IsOfLegalAge())
                    //{
                    //    Console.WriteLine(pekka.name + " is of legal age.");
                    //}
                    //else
                    //{
                    //    Console.WriteLine(pekka.name + " is underage.");
                    //}

                    //Person pekka = new Person("Pekka");
                    //Person antti = new Person("annti");

                    //int i = 0;
                    //while (i < 27)
                    //{
                    //    pekka.GrowOlder();
                    //    i++;
                    //}
                    //antti.GrowOlder();

                    //Console.WriteLine(pekka);
                    //Console.WriteLine(antti);
                    //Console.WriteLine(antti.ToString());


                    //Person matti = new Person("Matti");
                    //Person juhana = new Person("Juhana");

                    //matti.height = 180;
                    //matti.weight = 86;

                    //juhana.height = 175;
                    //juhana.weight = 64;

                    //Console.WriteLine(matti.name + ", body mass index is " + matti.BodyMassIndex());
                    //Console.WriteLine(juhana.name + ", body mass index is " + juhana.BodyMassIndex());




                    //List<string> names = new List<string>();

                    //// string can first be stored in a variable
                    //string betty = "Betty Jennings";
                    //// then Add it to the list
                    //names.Add(betty);

                    //// strings can also be directly added to the list:
                    //names.Add("Betty Snyder");
                    //names.Add("Frances Spence");
                    //names.Add("Kay McNulty");
                    //names.Add("Marlyn Wescoff");
                    //names.Add("Ruth Lichterman");

                    //// several different repeat statements can be
                    //// used to go through the list elements

                    //// 1. while loop
                    //int index = 0;
                    //while (index < names.Count)
                    //{
                    //    Console.WriteLine(names[index]);
                    //    index = index + 1;
                    //}
                    //Console.WriteLine();
                    //// 2. for loop with index
                    //for (int i = 0; i < names.Count; i++)
                    //{
                    //    Console.WriteLine(names[i]);
                    //}

                    //Console.WriteLine();
                    //// 3. for each loop (no index)
                    //foreach (string name in names)
                    //{
                    //    Console.WriteLine(name);
                    //}

                    //List<Person> persons = new List<Person>();
                    //Person anas = new Person("Anas");
                    //persons.Add(anas);
                    //persons.Add(new Person("Baraa"));
                    //persons.Add(new Person("Atilla"));
                    //foreach (var names in persons)
                    //{
                    //    Console.WriteLine(names);
                    //}

                    //List<Person> list = new List<Person>();
                    //while(true)
                    //{
                    //    Console.WriteLine("Enter a Name, empty will end: ");
                    //    string name= Console.ReadLine();
                    //    if (name == "")
                    //    {
                    //        break;
                    //    }
                    //    list.Add(new Person(name));
                    //}
                    //Console.WriteLine();
                    //Console.WriteLine("Persons in total: " + list.Count+" Persons");

                    //foreach(var person in list)
                    //{
                    //    Console.WriteLine(person);
                    //}


                    //List<Person> list = new List<Person>();

                    //while(true)
                    //{
                    //    Console.WriteLine("Enter the person details separated by a comma, e.g.: Randall, 2");
                    //    string details = Console.ReadLine();
                    //    if (details == "")
                    //    {
                    //        break;
                    //    }

                    //    string[] parts = details.Split(',');
                    //    string name = parts[0];
                    //    int age = Convert.ToInt32(parts[1]);
                    //    list.Add(new Person(name, age));

                    //}
                    //Console.WriteLine();
                    //Console.WriteLine("Persons in total: " + list.Count);
                    //Console.WriteLine("Persons: ");

                    //foreach (Person person in list)
                    //{
                    //    Console.WriteLine(person);
                    //}


                    //List<Person> list = new List<Person>();
                    //list.Add(new Person("Anas", 25));
                    //list.Add(new Person("Bara", 36));
                    //Console.WriteLine("What is the Age limit ?");
                    //int ageLimit=int.Parse(Console.ReadLine());
                    //foreach(Person person in list)
                    //{
                    //    if (person.age >= ageLimit)
                    //    {
                    //        Console.WriteLine(person);
                    //    }

                    //}

                    // while(true)
                    //{
                    //   Console.WriteLine("Enter your Name and Age but saperated with a comma: ");
                    //     string  name=Console.ReadLine();

                    // //    if (name == "")
                    // //    {
                    // //        break;
                    // //    }
                    // //    string[] parts = name.Split(',');

                    // //    Console.WriteLine("Name: "+parts[0]+" Age: " + parts[1]);
                    // string[] lines = File.ReadAllLines("records.csv");
                    // foreach (string line in lines)
                    // {
                    //     string[] parts = line.Split(',');
                    //     Console.WriteLine("Name: " + parts[0] + " Age: " + parts[1]);
                    // }
                    // }


                    //List<Person> people = new List<Person>();

                    //string[] lines = File.ReadAllLines("records.csv");
                    //foreach (string line in lines)
                    //{
                    //    string[] pieces = line.Split(',');
                    //    string name = pieces[0];
                    //    int age = Convert.ToInt32(pieces[1]);

                    //    people.Add(new Person(name, age));
                    //}
                    //Console.WriteLine("Total amount read: " + people.Count);


                    //OOP 1. Exercise

                    //Account heikkisAccount = new Account("Heikki's account", 100.00);
                    //Account heikkisSwissAccount = new Account("Heikki's account in Switzerland", 1000000.00);

                    //Console.WriteLine("Intial state");
                    //Console.WriteLine(heikkisAccount);
                    //Console.WriteLine(heikkisSwissAccount);

                    //heikkisAccount.Withdrawal(20);
                    //Console.WriteLine("The balance of Heikki's account is now: " + heikkisAccount.Balance);
                    //heikkisSwissAccount.Deposit(200);
                    //Console.WriteLine("The balance of Heikki's other account is now: " + heikkisSwissAccount.Balance);

                    //Console.WriteLine("End state");
                    //Console.WriteLine(heikkisAccount);
                    //Console.WriteLine(heikkisSwissAccount);


                    //2.Exercise
                    //Account heikki = new Account("Heikki's Account", 1000.0);
                    //Account personal = new Account("Personal Account ", 0.0);

                    //Console.WriteLine("Intial state");
                    //Console.WriteLine(heikki);
                    //Console.WriteLine(personal);
                    //Console.WriteLine();
                    //heikki.Withdrawal(100.0);
                    //personal.Deposit(100.0);
                    //Console.WriteLine("Heikki's account Balace : "+heikki.Balance);
                    //Console.WriteLine("Heikki's account Balace : " + personal.Balance);






                    //5.Exercise
                    //Whistle duckWhistle = new Whistle("Kvaak");
                    //Whistle roosterWhistle = new Whistle("Peef");

                    //duckWhistle.Sound();
                    //roosterWhistle.Sound();
                    //duckWhistle.Sound();




                    //6.Exercise
                    // Product banana=new Product("Banana",1.1,13);
                    //banana.PrintProduct();





                    //7.Exercise
                    //secton 1

                    //DecreasingCounter counter = new DecreasingCounter(10);
                    //counter.PrintValue();

                    //counter.Decrement();
                    //counter.PrintValue();

                    //counter.Decrement();
                    //counter.PrintValue();

                    //Scetion 2
                    //DecreasingCounter counter = new DecreasingCounter(2);
                    //counter.PrintValue();



                    //counter.Decrement();
                    //counter.Decrement();
                    //counter.PrintValue();

                    //counter.Decrement();
                    //counter.PrintValue();

                    //Section 3
                    //DecreasingCounter counter = new DecreasingCounter(20);
                    //counter.PrintValue();

                    //counter.Reset();
                    //counter.PrintValue();


                    //8.Exercise
                    //Debt mortgage = new Debt(120000.0, 1.01);
                    //mortgage.PrintBalance();

                    //mortgage.WaitOneYear();
                    //mortgage.PrintBalance();

                    //// Wait 20 years
                    //int years = 0;
                    //while (years < 20)
                    //{
                    //    mortgage.WaitOneYear();
                    //    years = years + 1;
                    //}

                    //mortgage.PrintBalance();





                    //9.Exercise
                    //Dalmatian spotty = new Dalmatian("Spot", 306);
                    //Console.WriteLine(spotty.name + " is a very good dog. He has " + spotty.spots + " darker spots in his fur.");




                    //10.Exercise
                    //Gauge g = new Gauge();
                    //g.value = 12;
                    //Console.WriteLine($"Current aguge: {g.value}");
                    //while (!g.Full())
                    //{
                    //    Console.WriteLine("Not full! Value: " + g.value);
                    //    g.Increase();
                    //}

                    //Console.WriteLine("Full! Value: " + g.value);
                    //g.Decrease();
                    //Console.WriteLine("Not full! Value: " + g.value);


                    //11.Exercise
                    //Agent bond = new Agent("James", "Bond");

                    //string asString = bond.ToString();
                    //Console.WriteLine(asString);
                    //bond.Introdution();


                    //Agent bourne = new Agent("Jason", "Bourne");

                    //string summary = $"We have two agents: {bond} and {bourne}";

                    //Console.WriteLine(bourne);




                    //12.Exercise
                    //Multiplier multiplyByThree = new Multiplier(3);

                    //Console.WriteLine("multiplyByThree.Multiply(2): " + multiplyByThree.Multiply(2));

                    //Multiplier multiplyByFour = new Multiplier(4);

                    //Console.WriteLine("multiplyByFour.Multiply(2): " + multiplyByFour.Multiply(2));
                    //Multiplier multiplyBySix = new Multiplier(6);
                    //Console.WriteLine("multiplyByThree.Multiply(1): " + multiplyBySix.Multiply(1));
                    //Multiplier multiplyByEight = new Multiplier(8);
                    //Console.WriteLine("multiplyByFour.Multiply(1): " + multiplyByEight.Multiply(1));
                    //Console.WriteLine("multiplyByFour.Multiply(3): " + multiplyByEight.Multiply(3));



                    //13.Exercise
                    //Statistics statistics = new Statistics();
                    //statistics.AddNumber(3);
                    //statistics.AddNumber(5);
                    //statistics.AddNumber(1);
                    //statistics.AddNumber(2);
                    //Console.WriteLine("Count: " + statistics.count);
                    //Console.WriteLine("Sum: " + statistics.sum);




                    //14.Exercise
                    //PaymentCard card = new PaymentCard(50);
                    //Console.WriteLine(card);



                    //Exercise 15
                    //PaymentCard card = new PaymentCard(50);
                    //Console.WriteLine(card);

                    //card.EatLunch();
                    //Console.WriteLine(card);

                    //card.DrinkCoffee();
                    //Console.WriteLine(card);



                    //16.Exercise
                    //PaymentCard card = new PaymentCard(10);
                    //Console.WriteLine(card);

                    //card.EatLunch();
                    //Console.WriteLine(card);

                    //card.DrinkCoffee();
                    //Console.WriteLine(card);


                    //17.Exercise
                    //PaymentCard card = new PaymentCard(100);
                    //Console.WriteLine(card);

                    //card.AddMoney(49.99);
                    //Console.WriteLine(card);

                    //card.AddMoney(10000.0);
                    //Console.WriteLine(card);

                    //card.AddMoney(-10);
                    //Console.WriteLine(card);


                    //Objects in  a List Exercise 18
                    //List<Item> items= new List<Item>();
                    //Console.WriteLine("Enter a Name");
                    //while (true)
                    //{
                    //    string user = Console.ReadLine();
                    //    if (user == "")
                    //    {
                    //        break;
                    //    }
                    //    items.Add(new Item(user));
                    //}
                    //Console.WriteLine("All Items: ");
                    //foreach (Item item in items)

                    //{
                    //    Console.WriteLine(item.ToString());
                    //}



                    //19.Exercise
                    //List<PersonalInformation> infoList = new List<PersonalInformation>();
                    //string firstName, lastName;
                    //while (true)
                    //{
                    //    Console.Write("Enter first name: ");
                    //    firstName = Console.ReadLine();

                    //    if (firstName == "")
                    //    {
                    //        break;
                    //    }

                    //    Console.Write("Enter last name: ");
                    //    lastName = Console.ReadLine();

                    //    Console.Write("Enter identification number: ");
                    //    string idNumber = Console.ReadLine();

                    //    PersonalInformation info = new PersonalInformation(firstName, lastName, idNumber);
                    //    infoList.Add(info);
                    //}

                    //Console.WriteLine();

                    //foreach (PersonalInformation info in infoList)
                    //{
                    //    Console.WriteLine(info.firstname + " " + info.lastname);
                    //}


                    //20.Exercise
                    //List<TelevisionProgram> tv = new List<TelevisionProgram>();
                    //while (true)
                    //{
                    //    Console.WriteLine("Name of TV show: ");
                    //    string name = Console.ReadLine();
                    //    if (name == "")
                    //    {
                    //        break;
                    //    }
                    //    Console.WriteLine("Duration:");
                    //    int duration = Convert.ToInt32(Console.ReadLine());

                    //    TelevisionProgram program = new TelevisionProgram(name, duration);
                    //    tv.Add(program);
                    //}
                    //Console.WriteLine("Program's maximum duration? ");
                    //int maxDuration = int.Parse(Console.ReadLine());

                    //Console.WriteLine();

                    //foreach (TelevisionProgram t in tv)
                    //{
                    //    if (t.GetDuration() <= maxDuration)
                    //    {
                    //        Console.WriteLine(t.GetName() + " " + t.GetDuration() + " minuts");
                    //    }
                    //}


                    //21.Exercise
                    //List<BookInformation> books = new List<BookInformation>();
                    //while (true)
                    //{
                    //    Console.WriteLine("Name:");
                    //    string name= Console.ReadLine();
                    //    if (name == "")
                    //    {
                    //        break;
                    //    }
                    //    Console.WriteLine("Pages: ");
                    //    int pages=Convert.ToInt32(Console.ReadLine());

                    //    Console.WriteLine("Publication Year");
                    //    string year= Console.ReadLine();

                    //    BookInformation book=new BookInformation(name, pages, year);
                    //    books.Add(book);
                    //}
                    //Console.WriteLine();
                    //Console.Write("What information will be printed: ");
                    //string info= Console.ReadLine();
                    //foreach (BookInformation bok in books)
                    //{    
                    //    if (info == "everything")
                    //    {
                    //        Console.WriteLine(bok.Title()+", "+bok.Pages()+" Pages"+", "+bok.GetYear());
                    //    }
                    //    else if (info == "title")
                    //    {
                    //        Console.WriteLine(bok.Title().ToString());
                    //    }
                    //    else
                    //    {
                    //        break;
                    //    }
                    //}


                    //22.Exercise
                    //int count = 0;
                    //string input;

                    //Console.WriteLine("Enter strings (type 'end' to finish):");
                    //do
                    //{
                    //    input = Console.ReadLine();
                    //    if (input != "end")
                    //    {
                    //        count++;
                    //    }
                    //} while (input != "end");

                    //Console.WriteLine("Number of strings entered: " + count);






                    //23.Exercise
                    //string input;
                    //int number, cube;

                    //do
                    //{
                    //    Console.Write("Enter a number (or 'end' to stop): ");
                    //    input = Console.ReadLine();

                    //    if (input != "end")
                    //    {
                    //        if (Int32.TryParse(input, out number))
                    //        {
                    //            cube = number * number * number;
                    //            Console.WriteLine($"The cube of {number} is {cube}");
                    //        }
                    //        else
                    //        {
                    //            Console.WriteLine("Invalid input. Please enter an integer or 'end'.");
                    //        }
                    //    }
                    //} while (input != "end");


                    //24.Exercise
                    //string[] lines = File.ReadAllLines("data");


                    //foreach (string line in lines)
                    //{
                    //    Console.WriteLine(line);
                    //}


                    //Console.ReadLine();



                    //25.Exercise
                    //Console.Write("Enter file name: ");
                    //string fileName = Console.ReadLine();

                    //try
                    //{
                    //    string content = File.ReadAllText(fileName);
                    //    Console.WriteLine(content);
                    //}
                    //catch (FileNotFoundException)
                    //{
                    //    Console.WriteLine("File not found.");
                    //}
                    //catch (IOException e)
                    //{
                    //    Console.WriteLine("Error reading file: " + e.Message);
                    //}







                    //26.Exercise
                    //string[] guestList = File.ReadAllLines("guestlist.txt");

                    //// Prompt the user to enter a name
                    //Console.Write("Enter a name: ");
                    //string name = Console.ReadLine();

                    //// Check if the name is on the guest list
                    //bool isOnGuestList = false;
                    //foreach (string guest in guestList)
                    //{
                    //    if (guest.ToLower() == name.ToLower())
                    //    {
                    //        isOnGuestList = true;
                    //        break;
                    //    }
                    //}

                    //// Print the result
                    //if (isOnGuestList)
                    //{
                    //    Console.WriteLine(name + " is on the guest list.");
                    //}
                    //else
                    //{
                    //    Console.WriteLine(name + " is not on the guest list.");
                    //}












                    //Deeper into Objects
                    //Object oriented Revision

                    /* Object - oriented revision typically refers to the process of reviewing and improving the design and implementation of an 
                         object-oriented programming(OOP) system or application.This process involves analyzing the existing codebase, identifying 
                         areas that can be improved, and making modifications to enhance the overall quality of the system.
                           During object-oriented revision, developers may focus on several key areas, such as:

                           Object - oriented design principles: revisiting the fundamental principles of OOP, such as encapsulation, inheritance, and polymorphism,
                         to ensure that the system is designed in a modular and maintainable way.

                           Class hierarchies: reviewing the class hierarchy to ensure that it is well-organized and properly encapsulated, 
                            with clear and concise interfaces between classes.

                          Code reuse: identifying opportunities to reuse code across the system to reduce redundancy and improve maintainability.

                        Performance optimization: reviewing the codebase for potential performance issues, and making modifications to improve the system's performance and scalability.

                       Overall, the goal of object-oriented revision is to ensure that an OOP system or application is well-designed, 
                       maintainable, and performs well.This can involve making significant changes to the existing codebase, or simply making small tweaks to improve overall code quality.*/


                    //int hours = 0;
                    //int minutes = 0;
                    //int seconds = 0;

                    //while (true)
                    //{
                    //    // 1. Printing the time
                    //    if (hours < 10)
                    //    {
                    //        Console.Write("0");
                    //    }

                    //    Console.Write(hours);
                    //    Console.Write(":");

                    //    if (minutes < 10)
                    //    {
                    //        Console.Write("0");
                    //    }

                    //    Console.Write(minutes);
                    //    Console.Write(":");

                    //    if (seconds < 10)
                    //    {
                    //        Console.Write("0");
                    //    }

                    //    Console.Write(seconds);
                    //    Console.WriteLine();

                    //    // 2. The second hand's progress
                    //    seconds = seconds + 1;

                    //    // 3. The other hand's progress when necessary
                    //    if (seconds > 59)
                    //    {
                    //        minutes = minutes + 1;
                    //        seconds = 0;

                    //        if (minutes > 59)
                    //        {
                    //            hours = hours + 1;
                    //            minutes = 0;

                    //            if (hours > 23)
                    //            {
                    //                hours = 0;
                    //            }
                    //        }
                    //    }
                    //}





                    //ClockHand hours = new ClockHand(24);
                    //ClockHand minutes = new ClockHand(60);
                    //ClockHand seconds = new ClockHand(60);

                    //while (true)
                    //{
                    //    // 1. Printing the time
                    //    Console.WriteLine(hours + ":" + minutes + ":" + seconds);

                    //    // 2. Advancing the second hand
                    //    seconds.Advance();

                    //    // 3. Advancing the other hands when required
                    //    if (seconds.value == 0)
                    //    {
                    //        minutes.Advance();

                    //        if (minutes.value == 0)
                    //        {
                    //            hours.Advance();
                    //        }
                    //    }



                    //Clock clock = new Clock();

                    //while (true)
                    //{
                    //    Console.WriteLine(clock);
                    //    clock.Advance();
                    //}




                    //Rectangle Exercise

                    //Rectangle first = new Rectangle(40, 80);
                    //Rectangle second = new Rectangle(10,10);
                    //Console.WriteLine(first);
                    //Console.WriteLine(second);

                    //first.Narrow();
                    //Console.WriteLine(first);
                    //Console.WriteLine(first.SurfaceArea());






                    // Person paul = new Person("Paul", 24);
                    // Person ada = new Person("Ada");

                    // Console.WriteLine(paul);
                    // Console.WriteLine(ada);
                    // paul.GrowOlder();
                    // ada.GrowOlder();
                    // Console.WriteLine(ada);
                    // Console.WriteLine(paul);
                    // ada.GrowOlder(5);
                    // paul.GrowOlder(10);
                    //Console.WriteLine(ada);
                    // Console.WriteLine(paul);


                    //Name john = new Name("John");
                    //Console.WriteLine(john);

                    //Person1 first = new Person1("Luke");

                    //Console.WriteLine(first);
                    //first.MakeYounger();

                    //Console.WriteLine(first);
                    //Person1 second = first;
                    //second.MakeYounger();

                    //Console.WriteLine(first);







                    //Person joan = new Person("Joan Ball");
                    //Console.WriteLine(joan);

                    //Person ball = joan;
                    //ball.GrowOlder();
                    //ball.GrowOlder();
                    //Console.WriteLine(joan);

                    //joan = new Person("Joan B.");
                    //Console.WriteLine(joan);
                    //ball = null;

                    //Console.WriteLine(ball);
                    //ball.GrowOlder();




                    // Our constructor has name, age, weight, height
                    //Person matt =new Person("Matt john", 25,75,180);

                    //Person ali = new Person("Ali baba",40,80,135);

                    //AmusementParkRide park = new AmusementParkRide("Water Truck",140);

                    // if (park.AllowedToRide(matt))
                    // {
                    //     Console.WriteLine(matt._name + " He can Enter. ");

                    // }
                    // else
                    // {
                    //     Console.WriteLine(matt._name + " He cant Enter");
                    // }

                    // if (park.AllowedToRide(ali))
                    // {
                    //     Console.WriteLine(ali._name + " He can Enter. ");
                    // }
                    // else
                    // {
                    //     Console.WriteLine(ali._name + " He Cant Enter.");
                    // }

                    // Console.WriteLine(park);



                    //SimpleDate date =new SimpleDate(1,1,780);

                    //Person mohammad = new Person("Mohamad ibn Musa al-Khwarizmi ", date);

                    //Person pascal = new Person("Blaise Pascal", 19, 6, 1623);



                    //Console.WriteLine(mohammad);
                    //Console.WriteLine(pascal);




                    //DateTime now = DateTime.Now;
                    //Console.WriteLine(now);
                    //int year = now.Year;
                    //int month = now.Month;
                    //int day = now.Day;

                    //Console.WriteLine("today is  " + day + "." + month + "." + year);





                    //Person muhammad = new Person("Muhammad ibn Musa al-Khwarizmi", 1, 1, 780);
                    //Person pascal = new Person("Blaise Pascal", 19, 6, 1623);

                    //if (muhammad.OlderThan(pascal))
                    //{  //  same as muhammad.OlderThan(pascal)==true
                    //    Console.WriteLine(muhammad._name + " is older than " + pascal._name);
                    //}
                    //else
                    //{
                    //    Console.WriteLine(muhammad._name + " is not older than " + pascal._name);






                    //SimpleDate d1 = new SimpleDate(14, 2, 2011);
                    //SimpleDate d2 = new SimpleDate(21, 2, 2011);
                    //SimpleDate d3 = new SimpleDate(1, 3, 2011);
                    //SimpleDate d4 = new SimpleDate(31, 12, 2010);

                    //Console.WriteLine(d1 + " is earlier than " + d2 + ": " + d1.Before(d2));
                    //Console.WriteLine(d2 + " is earlier than " + d1 + ": " + d2.Before(d1));

                    //Console.WriteLine(d2 + " is earlier than " + d3 + ": " + d2.Before(d3));
                    //Console.WriteLine(d3 + " is earlier than " + d2 + ": " + d3.Before(d2));

                    //Console.WriteLine(d4 + " is earlier than " + d1 + ": " + d4.Before(d1));
                    //Console.WriteLine(d1 + " is earlier than " + d4 + ": " + d1.Before(d4));

















                }

                {
                    //Person anas = new Person("Anas");
                    //Console.WriteLine(anas);

                    //Person khaled = anas;

                    //khaled.GrowOlder();
                    //khaled.GrowOlder();
                    //Console.WriteLine(anas);

                    //anas = new Person("Anas.S");
                    //Console.WriteLine(anas);

                    //khaled = null;
                    //Console.WriteLine(khaled);

                }

                {
                    //Person matt = new Person("Matt", 17, 55, 180);
                    //Person anas = new Person("Anas", 25, 88, 130);

                    //MalahiParkRide ride = new MalahiParkRide("Belin Park", 131);

                    //if (ride.AllowToRide(matt))
                    //{
                    //    Console.WriteLine(matt._name + " He is allowed to ride");
                    //}
                    //else
                    //{
                    //    Console.WriteLine(matt._name + " He is not allowed to ride");
                    //}

                    //if (ride.AllowToRide(anas))
                    //{
                    //    Console.WriteLine(anas._name + " He is allowed to ride");
                    //}
                    //else
                    //{
                    //    Console.WriteLine(anas._name + " He is not allowed to ride");

                    //}
                    //Console.WriteLine(ride);
                }

                {
                    //SimpleDate date =new SimpleDate(24,06,1997);
                    //Person anas = new Person("Anas",date);
                    //Person sarah = new Person("Sarah",01,05,2000);
                    //Console.WriteLine(anas);
                    //Console.WriteLine(sarah);



                    //SimpleDate d1 = new SimpleDate(14, 2, 2011);
                    //SimpleDate d2 = new SimpleDate(21, 2, 2011);
                    //SimpleDate d3 = new SimpleDate(1, 3, 2011);
                    //SimpleDate d4 = new SimpleDate(31, 12, 2010);

                    //Console.WriteLine(d1 + " is earlier than " + d2 + ": " + d1.Before(d2));
                    //Console.WriteLine(d2 + " is earlier than " + d1 + ": " + d2.Before(d1));
                    //Console.WriteLine();
                    //Console.WriteLine(d2 + " is earlier than " + d3 + ": " + d2.Before(d3));
                    //Console.WriteLine(d3 + " is earlier than " + d2 + ": " + d3.Before(d2));
                    //Console.WriteLine();
                    //Console.WriteLine(d4 + " is earlier than " + d1 + ": " + d4.Before(d1));
                    //Console.WriteLine(d1 + " is earlier than " + d4 + ": " + d1.Before(d4));

                    //SimpleDate date1 = new SimpleDate(1, 2, 2020);
                    //SimpleDate date2 = new SimpleDate(1, 2, 2020);
                    //Console.WriteLine(date1.Equals(date2));
                    //Console.WriteLine(date1 == date2);
                }

                {
                    //Bird red = new Bird("Red");
                    //Console.WriteLine(red.GetHashCode());

                    //Bird chuck = new Bird("Chuck");
                    //Console.WriteLine(chuck.GetHashCode());


                    //if (red.Equals(chuck))
                    //{
                    //    Console.WriteLine(red+" Equals "+ chuck);
                    //}
                    //else
                    //{
                    //    Console.WriteLine(red + " does not Equal " + chuck);
                    //}

                    //List<Bird> birds = new List<Bird>();
                    //   Bird red = new Bird("Red");

                    //if (birds.Contains(red))
                    //{
                    //    Console.WriteLine("Red is on the list.");
                    //}
                    //else
                    //{
                    //    Console.WriteLine("Red is not on the list.");
                    //}
                    //birds.Add(red);
                    //if (birds.Contains(red))
                    //{
                    //    Console.WriteLine("Red is on the list.");
                    //}
                    //else
                    //{
                    //    Console.WriteLine("Red is not on the list.");
                    //}

                    //Console.WriteLine("However!");

                    //red = new Bird("Red");
                    //if (birds.Contains(red))
                    //{
                    //    Console.WriteLine("Red is on the list.");
                    //}
                    //else
                    //{
                    //    Console.WriteLine("Red is not on the list.");
                    //}

                }

                {
                    //Counter counter = new Counter();
                    //counter.Increase();
                    //counter.Increase();

                    //Console.WriteLine(counter);         // prints 2

                    //Counter clone = counter.Clone();

                    //Console.WriteLine(counter);         // prints 2
                    //Console.WriteLine(clone);          // prints 2

                    //counter.Increase();
                    //counter.Increase();
                    //counter.Increase();
                    //counter.Increase();

                    //Console.WriteLine(counter);         // prints 6
                    //Console.WriteLine(clone);          // prints 2

                    //clone.Increase();

                    //Console.WriteLine(counter);         // prints 6
                    //Console.WriteLine(clone);
                }


                //Exercise 1
                {

                    //Timer timer = new Timer();

                    //while (true)
                    //{
                    //    Console.WriteLine(timer);
                    //    timer.Advance();

                    //    try
                    //    {

                    //        System.Threading.Thread.Sleep(10);
                    //    }

                    //    catch (Exception e)
                    //    {
                    //        Console.WriteLine("Error happened: +" + e);
                    //    }
                    //}
                }


                //Exercise 2
                {
                    //Cube one = new Cube(5);
                    //Console.WriteLine(one);
                }

                //Exercise 3
                {
                    //Fitbyte assistant = new Fitbyte(30, 60);
                    //double percentage = 0.5;

                    //while (percentage < 1.0)
                    //{
                    //    double target = assistant.TargetHeartRate(percentage);
                    //    Console.WriteLine("Target " + (percentage * 100) + "% of maximum: " + target);
                    //    percentage = percentage + 0.1;
                    //}
                }

                //Exercise 4
                {
                    //Product tapeMeasure = new Product("Tape measure");
                    //Product plaster = new Product("Plaster", "home improvement section");
                    //Product tyre = new Product("Tyre", 5);

                    //Console.WriteLine(tapeMeasure);
                    //Console.WriteLine(plaster);
                    //Console.WriteLine(tyre);
                }

                //Exercise 5
                {
                    //Counter counter1 = new Counter(); // create counter1 with start value 0
                    //Console.WriteLine("Counter1 value: " + counter1.value); // should output "Counter1 value: 0"
                    //counter1.Increase(); // increase counter1 value by 1
                    //Console.WriteLine("Counter1 value: " + counter1.value); // should output "Counter1 value: 1"
                    //counter1.Decrease(2); // decrease counter1 value by 2
                    //Console.WriteLine("Counter1 value: " + counter1.value); // should output "Counter1 value: -1"

                    //Counter counter2 = new Counter(5); // create counter2 with start value 5
                    //Console.WriteLine("Counter2 value: " + counter2.value); // should output "Counter2 value: 5"
                    //counter2.Increase(3); // increase counter2 value by 3
                    //Console.WriteLine("Counter2 value: " + counter2.value); // should output "Counter2 value: 8"
                    //counter2.Decrease(); // decrease counter2 value by 1
                    //Console.WriteLine("Counter2 value: " + counter2.value);
                }

                //Exercise 6
                {
                    //HealthStation childrensHospital = new HealthStation();

                    //// create two new persons
                    //Person ethan = new Person("Ethan", 1, 110, 7);
                    //Person peter = new Person("Peter", 33, 176, 85);

                    //// Try out the Persons and method Weigh
                    //Console.WriteLine(ethan._name + " weight: " + childrensHospital.Weigh(ethan) + " kilos");
                    //Console.WriteLine(peter._name + " weight: " + childrensHospital.Weigh(peter) + " kilos");

                    //// Test feeding the persons
                    //childrensHospital.Feed(ethan);
                    //childrensHospital.Feed(peter);
                    //childrensHospital.Feed(peter);

                    //// See that the weights have changed
                    //Console.WriteLine(ethan._name + " weight: " + childrensHospital.Weigh(ethan) + " kilos");
                    //Console.WriteLine(peter._name + " weight: " + childrensHospital.Weigh(peter) + " kilos");

                    //// Keep weighing to increase the 'int weighings'
                    //childrensHospital.Weigh(ethan);
                    //childrensHospital.Weigh(ethan);
                    //childrensHospital.Weigh(ethan);
                    //childrensHospital.Weigh(ethan);
                    //childrensHospital.Weigh(ethan);
                    //childrensHospital.Weigh(ethan);
                    //// See that the variable has increased to 8
                    //Console.WriteLine("weighings performed: " + childrensHospital._weighings);
                }

                //Exercise 7
                {
                    //PaymentCard anascard = new PaymentCard(120);
                    //Console.WriteLine("Money " + anascard.balance);
                    //bool wasSuccessful = anascard.TakeMoney(20);
                    //Console.WriteLine("successfully withdrew: " + wasSuccessful);
                    //Console.WriteLine("remain Money " + anascard.balance);

                    //wasSuccessful = anascard.TakeMoney(98);
                    //Console.WriteLine("successfully withdrew: " + wasSuccessful);
                    //Console.WriteLine("remain money " + anascard.balance);

                }

                //Exercise 8
                {
                    //PaymentTerminal lunchCafeteria = new PaymentTerminal();

                    //double change = lunchCafeteria.DrinkCoffee(10);
                    //Console.WriteLine("remaining change " + change);

                    //change = lunchCafeteria.DrinkCoffee(5);
                    //Console.WriteLine("remaining change " + change);

                    //change = lunchCafeteria.EatLunch(20);
                    //Console.WriteLine("remaining change " + change);

                    //Console.WriteLine(lunchCafeteria);
                }
                {
                    //PaymentTerminal lunchCafeteria = new PaymentTerminal();

                    //double change = lunchCafeteria.DrinkCoffee(10);
                    //Console.WriteLine("remaining change: " + change);

                    //PaymentCard annesCard = new PaymentCard(15);

                    //bool wasSuccessful = lunchCafeteria.EatLunch(annesCard);
                    //Console.WriteLine("there was enough money: " + wasSuccessful);
                    //wasSuccessful = lunchCafeteria.EatLunch(annesCard);
                    //Console.WriteLine("there was enough money: " + wasSuccessful);
                    //wasSuccessful = lunchCafeteria.DrinkCoffee(annesCard);
                    //Console.WriteLine("there was enough money: " + wasSuccessful);

                    //Console.WriteLine(lunchCafeteria);
                }
                {
                    //PaymentTerminal lunchCafeteria = new PaymentTerminal();
                    //Console.WriteLine(lunchCafeteria);

                    //PaymentCard annesCard = new PaymentCard(2);

                    //Console.WriteLine("amount of money on the card is " + annesCard.balance + " euros");

                    //bool wasSuccessful = lunchCafeteria.EatLunch(annesCard);
                    //Console.WriteLine("there was enough money: " + wasSuccessful);

                    //lunchCafeteria.AddMoneyToCard(annesCard, 100);

                    //wasSuccessful = lunchCafeteria.EatLunch(annesCard);
                    //Console.WriteLine("there was enough money: " + wasSuccessful);

                    //Console.WriteLine("amount of money on the card is " + annesCard.balance + " euros");

                    //Console.WriteLine(lunchCafeteria);
                }

                //Exercise 9
                {
                    //Pet lucy = new Pet("Lucy", "golden retriever");
                    //Exercise9.Person leo = new Exercise9.Person("Leo", lucy);
                    //Console.WriteLine(leo);

                    //Exercise9.Person mike = new Exercise9.Person("Mike");
                    //Console.WriteLine(mike);

                    //Exercise9.Person lilo = new Exercise9.Person();
                    //Console.WriteLine(lilo);


                }


                //Exercise 10
                {
                    //Apartment manhattanStudioApt = new Apartment(1, 16, 5500);
                    //Apartment atlantaTwoBedroomApt = new Apartment(2, 38, 4200);
                    //Apartment bangorThreeBedroomApt = new Apartment(3, 78, 2500);

                    //Console.WriteLine(manhattanStudioApt.LargerThan(atlantaTwoBedroomApt));
                    //Console.WriteLine(bangorThreeBedroomApt.LargerThan(manhattanStudioApt));

                    //Console.WriteLine(manhattanStudioApt.PriceDifference(atlantaTwoBedroomApt));
                    //Console.WriteLine(bangorThreeBedroomApt.PriceDifference(manhattanStudioApt));


                    //Console.WriteLine(manhattanStudioApt.MoreExpensiveThan(atlantaTwoBedroomApt));
                    //Console.WriteLine(bangorThreeBedroomApt.MoreExpensiveThan(manhattanStudioApt));
                }

                //Exercise 11
                {
                    //Song jackSparrow = new Song("The Lonely Island", "Jack Sparrow", 196);
                    //Song anotherSparrow = new Song("The Lonely Island", "Jack Sparrow", 196);

                    //if (jackSparrow.Equals(anotherSparrow))
                    //{
                    //    Console.WriteLine("Songs are equal.");
                    //}

                    //if (jackSparrow.Equals("Another object"))
                    //{
                    //    Console.WriteLine("Strange things are afoot.");
                    //}
                }

                //Exercise 12
                {
                    //List<BookInformation> books = new List<BookInformation>();
                    //while (true)
                    //{
                    //    Console.WriteLine("Book Name (empty name ends program: ");
                    //    string name = Console.ReadLine();

                    //    if (string.IsNullOrEmpty(name))
                    //    {
                    //        break;
                    //    }

                    //    Console.WriteLine("Publication year: ");
                    //    string year = Console.ReadLine();

                    //    bool alreadyExists = false;
                    //    foreach (BookInformation book in books)
                    //    {
                    //        if (book.Title() == name && book.GetYear() == year)
                    //        {
                    //            Console.WriteLine("The book is already on the list. Let's not add the same book again.");
                    //            alreadyExists = true;
                    //            break;
                    //        }
                    //    }
                    //        if (!alreadyExists)
                    //        {
                    //            Console.WriteLine("Pages");
                    //            int pages = int.Parse(Console.ReadLine());
                    //            books.Add(new BookInformation(name, pages, year));
                    //        }
                    //}
                    //Console.WriteLine("Thank you! Books added: " + books.Count);

                }
                {
                    //List<BookInformation> books = new List<BookInformation>();

                    //while (true)
                    //{
                    //    string name = BookInformation.GetNameFromUser();
                    //    if (string.IsNullOrEmpty(name))
                    //    {
                    //        break;
                    //    }

                    //    string year = BookInformation.GetYearFromUser();

                    //    if (BookInformation.BookExists(books, name, year))
                    //    {
                    //        Console.WriteLine("The book is already on the list. Let's not add the same book again.");
                    //    }
                    //    else
                    //    {
                    //        int pages = BookInformation.GetPagesFromUser();
                    //        books.Add(new BookInformation(name, pages, year));
                    //    }
                    //}

                    //Console.WriteLine("Thank you! Books added: " + books.Count);
                }

                //Exercise 13
                {
                    //List<Item> list = new List<Item>();
                    //while (true)
                    //{
                    //    Console.WriteLine("Identifier? (empty will stop):");
                    //    string id= Console.ReadLine().Trim();
                    //    if (string.IsNullOrEmpty(id))
                    //    {
                    //        break;
                    //    }

                    //    Console.WriteLine("Name? (empty will stop):");
                    //    string name= Console.ReadLine().Trim();
                    //    if(string.IsNullOrEmpty(name))
                    //    {
                    //        break;
                    //    }

                    //    Item item= new Item(id, name);
                    //    if (!list.Contains(item))
                    //    {
                    //        list.Add(item);
                    //    }
                    //}
                    //Console.WriteLine("\n==Items==");
                    //foreach (Item item in list)
                    //{
                    //    Console.WriteLine($"{item._id}: {item._name}");
                    //}
                }

                //Exercise 14
                {
                    //SimpleDate date = new SimpleDate(13, 2, 2015);
                    //Console.WriteLine("Friday of the examined week is " + date);

                    //SimpleDate newDate = date.AfterNumberOfDays(7);
                    //int week = 1;
                    //while (week <= 7)
                    //{
                    //    Console.WriteLine("Friday after " + week + " weeks is " + newDate);
                    //    newDate = newDate.AfterNumberOfDays(7);

                    //    week = week + 1;
                    //}

                    //Console.WriteLine($"The date after 2933 days from the examined Friday is: {date.AfterNumberOfDays(2933)} !");


                    //SimpleDate now = new SimpleDate(06, 04, 2023);
                    //SimpleDate afterOneWeek = now;

                    //afterOneWeek.Advance(7);

                    //Console.WriteLine("Now: " + now);
                    //Console.WriteLine("After One Week: " + afterOneWeek);

                }

                //Exercise 15 
                {
                    //Money money = new Money(100, 00);
                    //Money moreMoney = new Money(500, 50);

                    //Money combined = money.Plus(moreMoney);

                    //Console.WriteLine(money.ToString());
                    //Console.WriteLine(moreMoney.ToString());
                    //Console.WriteLine(combined.ToString());

                    //Money lessMoney = moreMoney.Minus(money);
                    //Console.WriteLine();
                    //Console.WriteLine(money.ToString());
                    //Console.WriteLine(moreMoney.ToString());
                    //Console.WriteLine(lessMoney.ToString());
                    //Console.WriteLine();
                    //lessMoney = lessMoney.Minus(money);

                    //Console.WriteLine(money.ToString());
                    //Console.WriteLine(moreMoney.ToString());
                    //Console.WriteLine(lessMoney.ToString());
                    //Console.WriteLine();
                    //Console.WriteLine(lessMoney.LessThan(moreMoney));
                    //Console.WriteLine(lessMoney.LessThan(money));

                    //lessMoney = lessMoney.Minus(moreMoney);
                    //Console.WriteLine(lessMoney.ToString());
                }

            }


        }

      

    }
}

