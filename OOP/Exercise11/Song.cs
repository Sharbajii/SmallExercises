using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Exercise11
{
    public class Song
    {
        private string _name { get; set; }
        private string _singer { get; set; }
        private int _year { get; set; }

        public Song(string name, string singer, int year)
        {
            _name = name;
            _singer = singer;
            _year = year;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Song otherSong = (Song)obj;

            return _singer == otherSong._singer

                && _name == otherSong._name

                && _year == otherSong._year;
        }

    }
}
