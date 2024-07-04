using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Exercise3
{
    public class Fitbyte
    {
        private int _age;
        private int _restingHeartRate;

        public Fitbyte(int age, int restingHeartRate)
        {
            _age = age;
            _restingHeartRate = restingHeartRate;
        }

        public double TargetHeartRate(double percentageOfMaximum)
        {
            double maxHeartRate = 206.3 - (0.711 * _age);
            double target = (maxHeartRate - _restingHeartRate) * percentageOfMaximum + _restingHeartRate;
            return target;
        }
       

    }
}
