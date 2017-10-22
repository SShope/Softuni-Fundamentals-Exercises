using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_3_MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var totalResources = new Dictionary<string, long>();
            string input = null;
            string currentResource = null;
            long quantity = 0;
            int evenOdd = 1;

            while (input != "stop")
            {
                input = Console.ReadLine();
                if (evenOdd % 2 != 0)
                {
                    currentResource = input;
                }
                else
                {
                    quantity = long.Parse(input);
                    if (totalResources.ContainsKey(currentResource))
                    {
                        totalResources[currentResource] += quantity;
                    }
                    else
                    {
                        totalResources.Add(currentResource, quantity);
                    }
                }
                evenOdd++;
            }

            foreach (var item in totalResources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
