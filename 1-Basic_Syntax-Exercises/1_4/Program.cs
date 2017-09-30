using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_4
{
    class Program
    {
        static void Main(string[] args)
        {

            String name = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            double energy = double.Parse(Console.ReadLine());
            double sugarlevel = double.Parse(Console.ReadLine());

            double enperml = energy * volume / 100;
            double sugperml = sugarlevel * volume / 100;

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{enperml}kcal, {sugperml}g sugars");

        }
    }
}
