using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace OOP
{

    ////3.Exercise
    ////class Dog
    //{
    ////    private string Name;
    ////    private string Breed;
    ////    private int Age;
    ////}

    ////4.Exercise
    ////class Room
    ////{
    ////    private string code;
    ////    private int Seats;
    ////}

    //class Whistle
    //{
    //    private string sound;

    //    public Whistle(string sound)
    //    {
    //        this.sound = sound;
    //    }
    //    public void Sound()
    //    {
    //        Console.WriteLine(sound);
    //    }
    //}

    //class Product
    //{
    //    private double Price;
    //    private string Name;
    //    private int Quantity;


    //    public Product(string name, double price, int quantity)
    //    {
    //        this.Price = price;
    //        this.Name = name;
    //        this.Quantity = quantity;
    //    }


    //    public void PrintProduct()
    //    {
    //        Console.WriteLine("Name: " + this.Name + " Price: " + this.Price + this.Quantity + " Pcs");
    //    }
    //}


    //class DecreasingCounter
    //{
    //    private int value;

    //    public DecreasingCounter(int initialValue)
    //    {
    //        this.value = initialValue;
    //    }

    //    public void PrintValue()
    //    {
    //        Console.WriteLine("value: " + this.value);
    //    }

    //    public void Decrement()
    //    {
    //        if (this.value > 0)
    //        {
    //            value--;
    //        }
    //    }
    //    public void Reset()
    //    {
    //        this.value = 0;
    //    }



    //}


    //class Debt
    //{
    //    private double balance;
    //    private double interestRate;


    //    public Debt(double initialBalance, double initialInterestRate)
    //    {
    //        this.balance = initialBalance;
    //        this.interestRate = initialInterestRate;
    //    }

    //    public void PrintBalance()
    //    {
    //        Console.WriteLine("the current Balance is: " + this.balance);
    //    }
    //    public void WaitOneYear()
    //    {
    //        double interest = balance * interestRate;
    //        balance += interest;
    //    }
    //}

    //class Dalmatian
    //{
    //    public string name { get; set; }
    //    public int spots { get; set; }


    //    public Dalmatian(string name, int spots)
    //    {
    //        this.name = name;
    //        this.spots = spots;
    //    }
    //}

    //class Gauge
    //{
    //    public int value { get; private set; }


    //    public Gauge()
    //    {
    //        this.value = 0;
    //    }


    //    public void Increase()
    //    {
    //        if (this.value <= 5)
    //        {
    //            this.value++;
    //        }
    //    }

    //    public void Decrease()
    //    {
    //        if (this.value > 0)
    //        {
    //            this.value--;
    //        }
    //    }

    //    public bool Full()
    //    {
    //        if (this.value == 5)
    //        {
    //            return true;
    //        }
    //        return false;
    //    }
    //}

    //class Agent
    //{
    //    private string firstName;
    //    private string lastName;

    //    public Agent(string first, string last)
    //    {
    //        this.firstName = first;
    //        this.lastName = last;
    //    }

    //    public void Introdution()
    //    {
    //        Console.WriteLine("My Name is " + this.lastName + ". " + this.firstName + " " + this.lastName);
    //    }

    //    public override string ToString()
    //    {
    //        return "My Name is " + this.lastName + ". " + this.firstName + " " + this.lastName;
    //    }
    //}

    //class Multiplier
    //{
    //    private int number;


    //    public Multiplier(int number)
    //    {
    //        this.number = number;
    //    }
    //    public int Multiply(int number)
    //    {
    //        int multi = number * this.number;
    //        return multi;
    //    }
    //}

    //class Statistics
    //{
    //    public int count { get; set; }
    //    public int sum { get; set; }

    //    public Statistics()
    //    {
    //        this.count = 0;
    //        this.sum = 0;
    //    }

    //    public void AddNumber(int number)
    //    {
    //        this.sum += number;
    //        this.count++;
    //    }
    //}

    //class PaymentCard
    //{
    //    private double balance;

    //    public PaymentCard(double openingBalance)
    //    {
    //        this.balance = openingBalance;
    //    }

    //    public void EatLunch()
    //    {
    //        if (balance >= 10.60)
    //        {
    //            this.balance -= 10.60;
    //        }
    //    }

    //    public double GetBalance()
    //    {
    //        return balance;
    //    }

    //    public void DrinkCoffee()
    //    {
    //        WithdrawIfPossible(2.0);
    //        //if (balance >= 2.0)
    //        //{
    //        //    balance -= 2.0;
    //        //}
    //        //return this.balance;
    //    }

    //    private void WithdrawIfPossible(double amount)
    //    {
    //        if (balance >= amount)
    //        {
    //            balance -= amount;
    //        }
    //    }


    //    public void AddMoney(double amount)
    //    {
    //        if (amount <= 0)
    //        {
    //            return;
    //        }

    //        this.balance += amount;
    //        if (this.balance > 150)
    //        {
    //            this.balance = 150;
    //        }

    //        //else if (amount < 0)
    //        //{
    //        //    this.balance = 150;
    //        //}

    //    }

    //    public override string ToString()
    //    {
    //        return "The card has a balance of " + this.balance + " Euros";
    //    }
    //}

    //class Item
    //{
    //    private string name;
    //    private DateTime timeCreated;


    //    public Item(string name)
    //    {
    //        this.name = name;
    //        this.timeCreated = DateTime.Now;
    //    }

    //    public override string ToString()
    //    {
    //        return $"{this.name} (created at {this.timeCreated})";
    //    }
    //}

    //class PersonalInformation
    //{
    //    public string firstname { get; set; }
    //    public string lastname { get; set; }

    //    public string id { get; set; }


    //    public PersonalInformation(string firstname, string lastname, string id)
    //    {
    //        this.firstname = firstname;
    //        this.lastname = lastname;
    //        this.id = id;
    //    }

    //    public override string ToString()
    //    {
    //        return $"{this.firstname} {this.lastname}";
    //    }


    //}


    //class TelevisionProgram
    //{
    //    private string name;
    //    private int duration;


    //    public TelevisionProgram(string name, int duration)
    //    {
    //        this.name = name;
    //        this.duration = duration;
    //    }
    //    public string GetName()
    //    {
    //        return name;
    //    }
    //    public int GetDuration()
    //    {
    //        return duration;
    //    }

    //    //public override string ToString()
    //    //{
    //    //    return $"{this.name}, {this.duration} minutes";
    //    //}
    //}


    //class BookInformation
    //{
    //    private string title;
    //    private int pages;
    //    private string year;



    //    public BookInformation(string title, int pages, string year)
    //    {
    //        this.title = title;
    //        this.pages = pages;
    //        this.year = year;
    //    }
    //    public string Title()
    //    {
    //        return title;
    //    }
    //    public int Pages()
    //    {
    //        return pages;
    //    }
    //    public string GetYear()
    //    {
    //        return year;
    //    }

    //}

    //public class ClockHand
    //{
    //    public int value { get; set; }
    //    public int limit { get; set; }

    //    public ClockHand(int limit)
    //    {
    //        this.limit = limit;
    //        this.value = 0;
    //    }

    //    public void Advance()
    //    {
    //        this.value = this.value + 1;

    //        if (this.value >= this.limit)
    //        {
    //            this.value = 0;
    //        }
    //    }

    //    public override string ToString()
    //    {
    //        if (this.value < 10)
    //        {
    //            return "0" + this.value;
    //        }

    //        return "" + this.value;
    //    }
    //}


    //public class Clock
    //{
    //    private ClockHand hours;
    //    private ClockHand minutes;
    //    private ClockHand seconds;

    //    public Clock()
    //    {
    //        this.hours = new ClockHand(24);
    //        this.minutes = new ClockHand(60);
    //        this.seconds = new ClockHand(60);
    //    }

    //    public void Advance()
    //    {
    //        this.seconds.Advance();

    //        if (this.seconds.value == 0)
    //        {
    //            this.minutes.Advance();

    //            if (this.minutes.value == 0)
    //            {
    //                this.hours.Advance();
    //            }
    //        }
    //    }

    //    public override string ToString()
    //    {
    //        return hours + ":" + minutes + ":" + seconds;
    //    }
    //}


    ////Class
    //public class Rectangle
    //{

    //    //instance Variable
    //    private int _width;
    //    private int _height;

    //    //Constructer
    //    public Rectangle(int width, int height)
    //    {
    //        _width = width;
    //        _height = height;
    //    }

    //    //Methods
    //    public void Width()
    //    {
    //        _width++;
    //    }

    //    public void Height()
    //    {
    //        _height++;
    //    }

    //    public void Narrow()
    //    {
    //        if (this._width > 0)
    //        {
    //            this._width--;
    //        }
    //    }

    //    public int SurfaceArea()
    //    {
    //        return _width * _height;
    //    }

    //    public override string ToString()
    //    {
    //        return "(" + _width + ", " + _height + ")";
    //    }
    //}


    ////public class Person
    ////{
    ////    public  string _name { get; set; }
    ////    private int _age;
    ////    private int _weight;
    ////    public int _height;




    ////    // Constructor which only sets the name
    ////    public Person(string name) : this(name, 0, 0, 0)
    ////    {
    ////    }

    ////    // Constructor to set name and age
    ////    public Person(string name, int age) : this(name, age, 0, 0)
    ////    {
    ////    }

    ////    // Constructor to set all the variables.
    ////    // The two constructors above call this when they are used.
    ////    public Person(string name, int age, int weight, int height)
    ////    {
    ////        _name = name;
    ////        _age = age;
    ////        _weight = weight;
    ////        _height = height;
    ////    }


    ////    public double BodyMassIndex()
    ////    {
    ////        double heigthPerHundred = _height / 100.0;
    ////        return _weight / (heigthPerHundred * heigthPerHundred);
    ////    }

    ////    public double MaximumHeartRate()
    ////    {
    ////        return 206.3 - (0.711 * _age);
    ////    }



    ////    public bool IsAdult()
    ////    {
    ////        if (_age < 18)
    ////        {
    ////            return false;
    ////        }
    ////        return true;
    ////    }


    ////    public void GrowOlder()
    ////    {
    ////       this.GrowOlder(1);
    ////    }


    ////    public void GrowOlder(int years)
    ////    {
    ////        _age += years;
    ////    }


    ////    public override string ToString()
    ////    {
    ////        return _name + ", age: " + _age;
    ////    }
    ////}


    //public class Name
    //{
    //    private string _name;

    //    public Name(string name)
    //    {
    //        _name = name;
    //    }


    //    public override string ToString()
    //    {
    //        return _name;
    //    }
    //}


    ////public class Person1
    ////{
    ////    private string name;
    ////    public int birthYear { get; set; }

    ////    public Person1(string name)
    ////    {
    ////        this.name = name;
    ////        this.birthYear = 1970;
    ////    }

    ////    public void MakeYounger()
    ////    {
    ////        birthYear++;
    ////    }

    ////    public override string ToString()
    ////    {
    ////        return this.name + " (" + this.birthYear + ")";
    ////    }
    ////}


    ////public class AmusementParkRide
    ////{
    ////    private string _name;
    ////    private int _lowestHeight;
    ////    private int _visitors;

    ////   public AmusementParkRide(string name, int lowestHeight)
    ////   {
    ////        _visitors = 0;
    ////        _name = name;
    ////        _lowestHeight = lowestHeight;
    ////   }

    ////    public bool AllowedToRide(Person person)
    ////    {
    ////        if (person._height < _lowestHeight)
    ////        {
    ////            return false;
    ////        }
    ////       _visitors++;
    ////        return true;
    ////    }


    ////    public override string ToString()
    ////    {
    ////        return this._name+ ", minimum Height: "+ _lowestHeight+ " , Visitors: "+ _visitors;
    ////    }

    ////}


    //public class SimpleDate
    //{

    //    public int _day;
    //    public int _month;
    //    public int _year;


    //    public SimpleDate(int day, int month, int year)
    //    {
    //        _day = day;
    //        _month = month;
    //        _year = year;
    //    }


    //    public bool Before(SimpleDate compared)
    //    {
    //        if (_year < compared._year)
    //        {
    //            return true;
    //        }
    //        if (_year > compared._year)
    //        {
    //            return false;
    //        }
    //        if (_month < compared._month)
    //        {
    //            return true;
    //        }
    //        if (_month > compared._month)
    //        {
    //            return false;
    //        }
    //        if (_day < compared._day)
    //        {
    //            return true;
    //        }
    //        return false;
    //    }

    //    public override string ToString()
    //    {
    //        return _day + "." + _month + "." + _year;
    //    }
    //}


    //public class Person
    //{
    //    public string _name { get; set; }
    //    private SimpleDate _birthday;
    //    private int _weight;
    //    private int _height;



    //    public Person(string name, SimpleDate birthday)
    //    {
    //        _name = name;
    //        _birthday = birthday;
    //        _weight = 0;
    //        _height = 0;
    //    }

    //    public Person(string name, int day, int month, int year)
    //    {
    //        _name = name;
    //        _birthday = new SimpleDate(day, month, year);
    //    }


    //    public bool OlderThan(Person compared)
    //    {
    //        if (this._birthday.Before(compared._birthday))
    //        {
    //            return true;
    //        }

    //        return false;
    //        {
    //            //    // 1. First compare years
    //            //    int ownYear = this._birthday._year;
    //            //    int comparedYear = compared._birthday._year;

    //            //    if (ownYear < comparedYear)
    //            //    {
    //            //        return true;
    //            //    }

    //            //    if (ownYear > comparedYear)
    //            //    {
    //            //        return false;
    //            //    }

    //            //    // 2. Same birthyear, compare months
    //            //    int ownMonth = this._birthday._month;
    //            //    int comparedMonth = compared._birthday._month;

    //            //    if (ownMonth < comparedMonth)
    //            //    {
    //            //        return true;
    //            //    }

    //            //    if (ownMonth > comparedMonth)
    //            //    {
    //            //        return false;
    //            //    }

    //            //    // 3. Same birth year and month, compare days
    //            //    int ownDay = this._birthday._day;
    //            //    int comparedDay = compared._birthday._day;

    //            //    if (ownDay < comparedDay)
    //            //    {
    //            //        return true;
    //            //    }

    //            //    return false;
    //            //}
    //        }
    //    }


    //    public override string ToString()
    //    {
    //        return _name + ", born on " + _birthday;
    //    }


    //public class Person
    //{
    //    public string _name;
    //    private int _age;
    //    private int _weight;
    //    public int _height;

    //    public Person(string name) : this(name, 0, 0, 0)
    //    {

    //    }
    //    public Person(string name, int age) : this(name, age, 0, 0)
    //    {

    //    }
    //    public Person(string name, int age, int weight, int height)
    //    {
    //        _name = name;
    //        _age = age;
    //        _weight = weight;
    //        _height = height;

    //    }

    //    public double BodyMass()
    //    {
    //        double BodyMassPerHunderd=_height/100;
    //        return _weight/(BodyMassPerHunderd*BodyMassPerHunderd);
    //    }


    //    public double MaximumHeartRate()
    //    {
    //        return 206.3 - (0.711 * _age);
    //    }

    //    public bool IsAdult()
    //    {
    //        if(_age < 18 )
    //        {
    //            return false;
    //        }
    //        return true;
    //    }

    //    public void GrowOlder(int year)
    //    {
    //        _age += year;

    //    }
    //    public void GrowOlder() 
    //    {
    //        GrowOlder(1);
    //    }
    //    public override string ToString()
    //    {
    //        return _name+ " , age "+_age+" years";
    //    }



    //}

    //public class MalahiParkRide
    // {
    //     private string _name;
    //     private int _lowerHeight;
    //     private int _visitor;


    //     public MalahiParkRide(string name, int lowerHeight)
    //     {
    //         _name = name;
    //         _lowerHeight = lowerHeight;
    //         _visitor = 0;
    //     }

    //     public bool AllowToRide(Person person)
    //     {

    //         if (person._height < _lowerHeight)
    //         {
    //             return false;
    //         }
    //         _visitor++;
    //         return true;
    //     }

    //     public override string ToString()
    //     {
    //         return _name+" Minimal Height is: "+ _lowerHeight+ ", Visitors: " + _visitor;
    //     }



    //public class Person
    //{
    //    public string _name;
    //    private SimpleDate _birthday;
    //    public int _height;
    //    private int _weight;



    //    public Person(string name, SimpleDate birthday)
    //    {
    //        _name = name;
    //        _birthday = birthday;
    //        _height = 0;
    //        _weight = 0;
    //    }

    //    public Person(string name, int day, int month, int year)
    //    {
    //        _name = name;
    //        _birthday = new SimpleDate(day, month, year);
    //    }

    //    public bool OlderThan(Person compared)
    //    {
    //        {
    //            //int year = _birthday._year;
    //            //int comparedYear = compared._birthday._year;

    //            //if (year > comparedYear)
    //            //{
    //            //    return true;
    //            //}
    //            //if (year < comparedYear)
    //            //{
    //            //    return false;
    //            //}

    //            //int month = _birthday._month;
    //            //int comparedMonth= compared._birthday._month;

    //            //if (month > comparedMonth)
    //            //{
    //            //    return true;

    //            //}
    //            //if(month < comparedMonth)
    //            //{
    //            //    return false;
    //            //}

    //            //int day= _birthday._day;
    //            //int comparedDay = compared._birthday._day;

    //            //if (day < comparedDay)
    //            //{
    //            //    return true;
    //            //}
    //            //  return false;
    //        }

    //        if (_birthday.Before(compared._birthday))
    //        {
    //            return true;
    //        }
    //        return this._birthday.Before(compared._birthday);

    //    }

    //    public override string ToString()
    //    {
    //        return _name + ", born at: " + _birthday;
    //    }
    //}

    //public class SimpleDate
    //{
    //    public int _year;
    //    public int _month;
    //    public int _day;

    //    public SimpleDate(int day, int month, int year)
    //    {
    //        _day = day;
    //        _month = month;
    //        _year = year;
    //    }
    //    public bool Before(SimpleDate compared)
    //    {
    //        if (_year > compared._year)
    //        {
    //            return false;
    //        }
    //        if (_year < compared._year)
    //        {
    //            return true;
    //        }
    //        if (_month > compared._month)
    //        {
    //            return false;
    //        }
    //        if (_month < compared._month)
    //        {
    //            return true;
    //        }

    //        if (_day < compared._day)
    //        {
    //            return true;
    //        }
    //        return false;
    //    }

    //    public override bool Equals(object compared)
    //    {
    //        // if the variables are located in the same position, they are equal
    //        if (this == compared)
    //        {
    //            return true;
    //        }

    //        // if the compared object is null, or
    //        // if the type of the compared object is not SimpleDate, the objects are not equal
    //        if ((compared == null) || !this.GetType().Equals(compared.GetType()))
    //        {
    //            return false;
    //        }

    //        // convert the Object type compared object
    //        // into an SimpleDate type object called comparedSimpleDate
    //        SimpleDate comparedSimpleDate = (SimpleDate)compared;

    //        // if the values of the object variables are the same, the objects are equal
    //        if (this._day == comparedSimpleDate._day &&
    //            this._month == comparedSimpleDate._month &&
    //            this._year == comparedSimpleDate._year)
    //        {
    //            return true;
    //        }

    //        // otherwise the objects are not equal
    //        return false;
    //    }


    //    public override string ToString()
    //    {
    //        return _day + ", " + _month + ", " + _year;
    //    }


    //}


    //public class Bird
    //{
    //    private string _name;


    //    public Bird(string name)
    //    {
    //        _name = name;
    //    }


    //    public override bool Equals(object compared)
    //    {
    //        // if the variables are located in the same position, they are equal
    //        if (this == compared)
    //        {
    //            return true;
    //        }

    //        // if the compared object is null or not of type Bird, the objects are not equal
    //        if ((compared == null) || !this.GetType().Equals(compared.GetType()))
    //        {
    //            return false;
    //        }
    //        else
    //        {
    //            // convert the object to a Bird object
    //            Bird comparedBird = (Bird)compared;
    //            // if the values of the object variables are equal, the objects are, too
    //            return this._name.Equals(comparedBird._name);
    //        }
    //    }




    //    public override string ToString()
    //    {
    //        return _name;
    //    }
    //}


    //public class Counter
    //{
    //    private int _value;

    //    public Counter() : this(0)
    //    {

    //    }

    //    public Counter(int initailValue)
    //    {
    //        _value = initailValue;
    //    }

    //    public void Increase()
    //    {
    //        _value++;
    //    }

    //    public Counter Clone()
    //    {
    //        // create a new counter object that receives the value of the cloned counter as its initial value
    //        Counter clone = new Counter(_value);

    //        // return the clone to the caller
    //        return clone;
    //    }

    //    public override string ToString()
    //    {
    //        return "Value "+_value;
    //    }
    //}



   


}







