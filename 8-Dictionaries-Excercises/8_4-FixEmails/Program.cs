using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_4_FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {

            var emails = new Dictionary<string, string>();
            string input = null;
            string name = null;
            string address = null;
            int evenOdd = 1;

            while (input != "stop")
            {
                input = Console.ReadLine();
                if (evenOdd % 2 != 0)
                {
                    name = input;
                }
                else
                {
                    address = input;
                    if (!address.ToLower().EndsWith("us") && !address.ToLower().EndsWith("uk"))
                    {
                        if (emails.ContainsKey(name))
                        {
                            emails[name] = address;
                        }
                        else
                        {
                            emails.Add(name, address);
                        }
                    }
                }
                evenOdd++;
            }

            foreach (var item in emails)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
