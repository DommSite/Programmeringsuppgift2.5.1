using System;
using System.Diagnostics;
using System.Diagnostics.Metrics;

namespace övning2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en multiplikation (x*y)");
            string skrivenmultiplikation = Console.ReadLine();
            int multi = skrivenmultiplikation.IndexOf("*");
            string tal1text = skrivenmultiplikation[..multi];
            string tal2text = skrivenmultiplikation[(multi + 1)..];

            float tal1 = float.Parse(tal1text);
            float tal2 = float.Parse(tal2text);
            float summa = tal1 * tal2;

            Console.WriteLine(skrivenmultiplikation + "=" + summa);

            Console.ReadKey();
        }
    }
}