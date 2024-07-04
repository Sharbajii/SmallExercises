using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Exercise9
{
    public class Pet
    {
        public string _Name;
        public string _type;

        public Pet(string name, string breed)
        {
            _Name = name;
            _type = breed;
        }
    }

    public class Person
    {
        public string Name;
        public Pet Pet;

        public Person(string name, Pet pet)
        {
            Name = name;
            Pet = pet;
        }

        public Person(string name)
        {
            Name = name;
            Pet = new Pet("Toothless", "dragon");
        }

        public Person()
        {
            Name = "Lilo";
            Pet = new Pet("Stitch", "blue alien");
        }

        public override string ToString()
        {
            return $"{Name}, has a friend called {Pet._Name} ({Pet._type})";
        }
    }
   
}
