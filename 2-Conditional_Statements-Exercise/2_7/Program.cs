using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingredient = null;
            int count = 0;

            do
            {
                ingredient = Console.ReadLine();
                if (ingredient != "Bake!")
                {
                    Console.WriteLine($"Adding ingredient {ingredient}.");
                }
                else
                {
                    Console.WriteLine($"Preparing cake with {count} ingredients.");
                }
                count += 1;
            }
            while (ingredient != "Bake!");
        }
    }
}
