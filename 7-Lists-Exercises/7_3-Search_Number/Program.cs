using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_3_Search_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            var sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var query = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            if (sequence.Take(query[0]).Skip(query[1]).Contains(query[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
