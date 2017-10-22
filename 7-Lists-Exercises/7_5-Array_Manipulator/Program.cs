using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_5_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {

            var numSequence = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var input = new List<string>();
            var containsList = new List<string>();

            while (true)
            {
                input = Console.ReadLine().Split(' ').ToList();

                switch (input[0])
                {
                    case "add":
                        numSequence.Insert(int.Parse(input[1]), int.Parse(input[2]));
                        break;

                    case "addMany":
                        for (int i = input.Count - 1; i > 1; i--)
                        {
                            numSequence.Insert(int.Parse(input[1]), int.Parse(input[i]));
                        };
                        break;

                    case "contains":
                        if (numSequence.Contains(int.Parse(input[1])))
                        {
                            containsList.Add(numSequence.IndexOf(int.Parse(input[1])).ToString());
                        }
                        else
                        {
                            containsList.Add("-1");
                        };
                        break;

                    case "remove":
                        numSequence.RemoveAt(int.Parse(input[1]));
                        break;

                    case "shift":
                        for (int i = 0; i < int.Parse(input[1]); i++)
                        {
                            int firstDigit = numSequence[0];
                            for (int j = 0; j < numSequence.Count - 1; j++)
                            {
                                numSequence[j] = numSequence[j + 1];
                            }
                            numSequence[numSequence.Count - 1] = firstDigit;
                        }
                        break;

                    case "sumPairs":
                        var pairedList = new List<int>();
                        if (numSequence.Count % 2 != 0)
                        {
                            numSequence.Add(0);
                        }
                        for (int i = 0; i < numSequence.Count; i += 2)
                        {
                            pairedList.Add(numSequence[i] + numSequence[i + 1]);
                        }
                        numSequence = pairedList.ToList(); ;
                        break;

                    case "print":
                        Console.WriteLine(string.Join("\r\n", containsList));
                        Console.WriteLine("[" + string.Join(", ", numSequence) + "]");
                        return;
                }
            }
        }
    }
}
