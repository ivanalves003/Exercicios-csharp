using System;
using System.Globalization;

namespace ex6
{
    class Program
        {  
        static void Main(string[] args) {

            double A, B, C, area_Triangulo, area_Circulo, area_Trapezio, area_Quadrado, area_Retangulo;

            Console.WriteLine("informe A, B e C");

            string[] valores = Console.ReadLine().Split(' ');
            A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            area_Triangulo = A * C / 2.0;
            area_Circulo = 3.14159 * C * C;
            area_Trapezio = (A + B) / 2.0 * C;
            area_Quadrado = B * B;
            area_Retangulo = A * B;

            Console.WriteLine("TRIANGULO: " + area_Triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + area_Circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + area_Trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + area_Quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + area_Retangulo.ToString("F3", CultureInfo.InvariantCulture));


        }
    }
}