using System;

namespace _2_15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int PeshoHealth = 100;
            int GoshoHealth = 100;
            int PeshoDmg = int.Parse(Console.ReadLine());
            int GoshoDmg = int.Parse(Console.ReadLine());

            //Calculations
            for (int i = 1; i > 0; i++)
            {
                // Pesho Turn
                if (i % 2 != 0)
                {
                    GoshoHealth -= PeshoDmg;
                    // Check Gosho health
                    if (GoshoHealth <= 0)
                    {
                        Console.WriteLine($"Pesho won in {i}th round.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {GoshoHealth} health.");
                    }
                }
                // Gosho Turn
                else
                {
                    // Gosho Turn
                    PeshoHealth -= GoshoDmg;
                    // Check Pesho health
                    if (PeshoHealth <= 0)
                    {
                        Console.WriteLine($"Gosho won in {i}th round.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {PeshoHealth} health.");
                    }
                }
                // Restore health
                if (i % 3 == 0)
                {
                    PeshoHealth += 10;
                    GoshoHealth += 10;
                }
            }
        }
    }
}
