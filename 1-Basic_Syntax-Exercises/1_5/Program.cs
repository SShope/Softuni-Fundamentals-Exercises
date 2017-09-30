using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            String charName = Console.ReadLine();
            int currHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {charName}");
            Console.WriteLine($"Health: |{printStr("|",currHealth)}{printStr(".",maxHealth-currHealth)}|");
            Console.WriteLine($"Energy: |{printStr("|",currEnergy)}{printStr(".",maxEnergy-currEnergy)}|");
        }

        static string printStr(String str, int count)
        {
            String endStr = str;
            if (count == 0){return null;}
            for(int i=0; i<count-1; i++){
                endStr = endStr + str;
            }
            return endStr;
        }
     
    }
}
