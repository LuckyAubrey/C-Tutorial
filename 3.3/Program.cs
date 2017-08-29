using System;
using System.Collections.Generic;

namespace _3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool czyWagaNorma;
            double waga, wzrost, wskaznikBMI;

            Console.Write("Podaj wage w kg: ");
            string text = Console.ReadLine();
            double.TryParse(text, out waga);

            while (waga <= 0) // for ( ;waga <= 0; )
            {
                Console.Write("Podaj wage w kg: ");
                text = Console.ReadLine();
                double.TryParse(text, out waga);
            }

            Console.Write("Podaj wzrost w metrach: ");
            text = Console.ReadLine();
            double.TryParse(text, out wzrost);

            wskaznikBMI = waga / Math.Pow(wzrost, 2.0);
            czyWagaNorma = wskaznikBMI >= 18.5 && wskaznikBMI < 25;
            Console.WriteLine("BMI = {0,6:F2}", wskaznikBMI);
            Console.WriteLine("Czy jestes gruba swinia?");

            if (czyWagaNorma == false) // (!czyWagaNorma)
            {
                Console.Write("Tak, prosiaku!");
            }
            else
            {
                Console.Write("Nie, chudzielcu!");
            }

            Console.WriteLine();
            Console.WriteLine();

            /*
            for (int i = 0; i < 100; i++)
            {

            }

            List<int> list = new List<int> { 1, 2, 3, 56, 7, 4, 2, 45, 23 };

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"i: {i} listCount: {list.Count} listElement: {list[i]}");
            }
            */

            Console.ReadKey();
        }
    }
}