using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Exercise4
{
    public class Product
    {
        private string _name;
        private string _location;
        private int _weight;

        public Product(string name)
        {
            _name = name;
            _location = "Shelf";
            _weight = 1;
        }
        public Product(string name, string location)
        {
            _name = name;
            _location = location;
            _weight = 1;
        }
        public Product(string name, int weight)
        {
            _name = name;
            _weight = weight;
            _location = "Warehouse";
        }

        public override string ToString()
        {
            return _name + "( " + _weight + " Kg" + " ) " + "can be found from the " + _location;
        }
    }
}
