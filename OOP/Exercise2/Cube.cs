using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Exercise2
{
    public class Cube
    {
        private int _edgeLength;
        public Cube(int edgeLength)
        {
            _edgeLength = edgeLength;
        }

        public int Volume()
        {
            int cube = _edgeLength * _edgeLength * _edgeLength;
            return cube;
        }

        public override string ToString()
        {

            return "The length of the edge is " + _edgeLength + " and the volume is " + Volume();
        }
    }
}
