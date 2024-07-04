using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Exercise10
{
    public class Apartment
    {
        public int Rooms { get; set; }
        public int SquareMeters { get; set; }
        public int PricePerSquareMeter { get; set; }

        public Apartment(int rooms, int squareMeters, int pricePerSquareMeter)
        {
            Rooms = rooms;
            SquareMeters = squareMeters;
            PricePerSquareMeter = pricePerSquareMeter;
        }

        private int Price()
        {
            return SquareMeters * PricePerSquareMeter;
        }

        public bool LargerThan(Apartment compared)
        {
            return SquareMeters > compared.SquareMeters;
        }

        public int PriceDifference(Apartment compared)
        {
            return Math.Abs(Price() - compared.Price());
        }

        public bool MoreExpensiveThan(Apartment compared)
        {
            if (Price() > compared.Price())
            {
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}
