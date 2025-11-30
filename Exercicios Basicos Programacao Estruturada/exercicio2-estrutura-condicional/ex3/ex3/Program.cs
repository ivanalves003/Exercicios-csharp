using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            if (A % 2 == 0 || B % 2 == 0)
            {
                Console.WriteLine("São multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao multiplos");
            }

        }
    }
}