using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_2_Phonebook_Upgrade
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = new List<string>();
            var phoneBook = new Dictionary<string, string>();
            var phoneBookSorted = new Dictionary<string, string>();
            input.Add(null);

            while (input[0] != "END")
            {
                input = Console.ReadLine().Split(' ').ToList();

                if (input[0] == "A")
                {
                    phoneBook[input[1]] = input[2];
                }
                else if (input[0] == "S")
                {
                    if (phoneBook.ContainsKey(input[1]))
                    {
                        Console.WriteLine(input[1] + " -> " + phoneBook[input[1]]);
                    }
                    else
                    {
                        Console.WriteLine("Contact " + input[1] + " does not exist.");
                    }
                }
                else if (input[0] == "ListAll")
                {
                    phoneBookSorted = phoneBook.OrderBy(pair => pair.Key).ToDictionary(pair => pair.Key, pair => pair.Value);
                    foreach (var item in phoneBookSorted)
                    {
                        Console.WriteLine(item.Key +" -> " + item.Value);
                    }
                }

            }

        }
    }
}
