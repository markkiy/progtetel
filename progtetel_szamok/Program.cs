using System;
using System.Xml.Schema;


namespace progtetel_szamok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 2, 3, 4, 5, 15, 6, 36, 47, 7, 8, 9 };

            // 1. párosak ki válogatása
            int n = x.Length;


            int[] parosak = new int[100];
            int db = 0;

            for (int i = 0; i < n; i++)
            {
                if (x[i] % 2 == 0)
                {
                    parosak[db] = x[i];
                    db++;
                }
            }

            for (int i = 0; i < db; i++)
            {
                Console.WriteLine(parosak[i]);
            }


            // 2. maximum hely és érték

        }
    }
}
