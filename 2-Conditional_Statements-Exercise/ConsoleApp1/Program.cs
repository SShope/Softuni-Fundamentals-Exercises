using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string noun = Console.ReadLine();

            if (noun.EndsWith("y"))
            {
                noun = noun.Remove(noun.Length - 1);
                Console.WriteLine(noun + "ies");
            }
            else if (noun.EndsWith("ch") || noun.EndsWith("s") || noun.EndsWith("sh") || noun.EndsWith("o") || noun.EndsWith("x") || noun.EndsWith("z"))
            {
                Console.WriteLine(noun + "es");
            }
            else
            {
                Console.WriteLine(noun + "s");
            }
            
        }
    }
}
