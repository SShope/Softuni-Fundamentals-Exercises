using System;

namespace _5_10
{
    class Program
    {
        static void Main(string[] args)
        {
            double cubeSide = double.Parse(Console.ReadLine());
            string cubeParam = Console.ReadLine();
            Console.WriteLine($"{CalculateCube(cubeSide, cubeParam):F2}");
        }

        static double CalculateCube(double cubeSide, string paramName)
        {
            double paramResult = 0;
            switch (paramName)
            {
                case "face":
                    paramResult = Math.Sqrt(2 * cubeSide * cubeSide);
                    break;
                case "space":
                    double faceDiag = Math.Sqrt(2 * cubeSide * cubeSide);
                    paramResult = Math.Sqrt(faceDiag * faceDiag + cubeSide * cubeSide);
                    break;
                case "volume":
                    paramResult = cubeSide * cubeSide * cubeSide;
                    break;
                case "area":
                    paramResult = 6 * cubeSide * cubeSide;
                    break;
            }
            return paramResult;
        }
    }
}
