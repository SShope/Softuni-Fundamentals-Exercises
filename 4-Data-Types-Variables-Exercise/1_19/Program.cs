using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_19
{
    class Program
    {
        static void Main(string[] args)
        {

            long picturesTaken = long.Parse(Console.ReadLine());
            long filterTime = long.Parse(Console.ReadLine());
            double filterFactor = double.Parse(Console.ReadLine()) / 100.0;
            long uploadTime = long.Parse(Console.ReadLine());

            var filteredPictures = Math.Ceiling(picturesTaken * filterFactor);
            //Console.WriteLine(filteredPictures);
            long totalTime = (long)(picturesTaken * filterTime + filteredPictures * uploadTime);
            //Console.WriteLine(totalTime);

            TimeSpan t = TimeSpan.FromSeconds(totalTime);

            Console.WriteLine($"{t.Days}:{t.Hours:D2}:{t.Minutes:D2}:{t.Seconds:D2}");
        }
    }
}