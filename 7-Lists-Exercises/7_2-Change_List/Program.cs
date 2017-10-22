using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _7_2_Change_List
{
    class Program
    {
        static void Main(string[] args)
        {

            var numList = Console.ReadLine().Split(' ').ToList();
            var tempList = new List<string>();
            string input = null;

            while (true)
            {
                input = Console.ReadLine();
                if (input == "Odd")
                {
                    Console.WriteLine(string.Join(" ", numList.Where(x => long.Parse(x) % 2 != 0)));
                    break;
                }
                else if (input == "Even")
                {
                    Console.WriteLine(string.Join(" ", numList.Where(x => long.Parse(x) % 2 == 0)));
                    break;
                }
                else
                {
                    tempList = input.Split(' ').ToList();
                    if (tempList.Count == 2)
                    {
                        numList = DeleteInsert(numList, tempList[0], tempList[1]);
                    }
                    else
                    {
                        numList = DeleteInsert(numList, tempList[0], tempList[1], tempList[2]);
                    }
                }
            }
            
        }

        static List<string> DeleteInsert(List<string> list, string command , string element, [Optional] string position)
        {
            if (command == "Insert")
            {
                list.Insert(int.Parse(position), element);
            }
            else
            {
                list.RemoveAll(x => x == element);
            }
            return list;
        }
    }
}
