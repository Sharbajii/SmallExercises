using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskAge
{
    internal class Program
    {

        public static void CalculateLifeDurationWithDateTime()
        {
            Console.WriteLine("Enter your Birthday in foramt (dd.mm.yyyy): ");
            string Birthday = Console.ReadLine();
            DateTime birthdate = DateTime.Parse(Birthday);
            TimeSpan age = DateTime.Now - birthdate;
            Console.WriteLine(" You have lived a total of " + (int)age.TotalDays + " Days, " + (int)age.TotalHours + " Hours and " + (int)age.TotalMinutes + " minutes. ");
        }

      

        public static void CalculateAgeWithOutUsingDateTime()
        {
            Console.WriteLine("Enter your Birthday in Format (dd.mm.yyyy) ");
            string birthday = Console.ReadLine();

            string[] birthdate = birthday.Split('.');
            int day = int.Parse(birthdate[0]);
            int month = int.Parse(birthdate[1]);
            int year = int.Parse(birthdate[2]);

            DateTime currentDate = DateTime.Now;
            TimeSpan age = DateTime.Now - currentDate;
            int totalDays = (currentDate.Year - year) * 365 + (currentDate.Month - month) * 30 + (currentDate.Day - day);
            int totalHours = totalDays * 24;
            int totalMinutes = totalHours * 60;

            Console.WriteLine(" You have lived a total of " + totalDays + " Days, " + totalHours + " Hours, and " + totalMinutes + " minutes. ");

        }




        static void Main(string[] args)
        {
            CalculateLifeDurationWithDateTime();
            Console.WriteLine();
            CalculateAgeWithOutUsingDateTime();
            Console.ReadLine();







        }

    }
}
