using System;

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
            if (waga <= 0)
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
            if (czyWagaNorma == false)
            {
                Console.Write("Tak, prosiaku!");
            }
            else
            {
                Console.Write("Nie, chudzielcu!");
            }
            Console.ReadKey();
        }
    }
}