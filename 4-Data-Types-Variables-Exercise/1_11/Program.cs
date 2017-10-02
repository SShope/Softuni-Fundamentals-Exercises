using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            byte hours = byte.Parse(Console.ReadLine());
            byte minutes = byte.Parse(Console.ReadLine());
            byte seconds = byte.Parse(Console.ReadLine());
            int totalTime = hours * 3600 + minutes * 60 + seconds;

            float metersPerSecond = (float)distance / (float)totalTime;
            float kilometersPerHour = (float)metersPerSecond * 3.6f;
            float milesPerHour = (float)kilometersPerHour / 1.609f;

            Console.WriteLine(metersPerSecond);
            Console.WriteLine(kilometersPerHour);
            Console.WriteLine(milesPerHour);
        }
    }
}
