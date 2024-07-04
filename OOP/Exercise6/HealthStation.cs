using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Exercise6
{
    public class Person
    {
        public string _name { get; }
        public int _weight { get; set; }
        public int _age;
        public int _height;

        public Person(string name, int age, int weight, int height)
        {
            _name = name;
            _weight = weight;
            _age = age;
            _height = height;
        }
    }

    public class HealthStation
    {

        public int _weighings;

        public int Weigh(Person person)
        {
            _weighings++;
            return person._weight;
        }

        public void Feed(Person person)
        {
            person._weight += 1;
        }

        public int GetWeighings()
        {
            return _weighings;
        }
    }
}
