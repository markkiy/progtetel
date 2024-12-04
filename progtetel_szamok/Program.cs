using System;


namespace progtetel_szamok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 2, 3, 4, 5, 15, 6, 36, 47, 7, 8, 9 };
           

            // 1. párosak ki válogatása

            // 2. maximum hely és érték
            int maxi = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] > x[maxi])
                {
                    maxi = i;
                }
            }

            Console.WriteLine($"{maxi + 1}, {x[maxi]}");
        }
    }
}
