using System;
using System.Globalization;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio, area, pi = 3.14159;

            Console.WriteLine("informe o valor da area");
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            area = pi * Math.Pow(raio, 2);
            
            Console.WriteLine("area = " + area.ToString("F4", CultureInfo.InvariantCulture));

        }
    }

}