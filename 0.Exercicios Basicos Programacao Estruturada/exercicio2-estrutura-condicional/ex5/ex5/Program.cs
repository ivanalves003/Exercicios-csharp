using System;
using System.Globalization;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int id, qtd;
            double preco;

            Console.WriteLine("informe o ID do produto");
            id = int.Parse(Console.ReadLine()); 


            switch (id)
            {
                case 1:
                    preco = 4.00;
                    Console.WriteLine("informe a quantidade ");
                    qtd = int.Parse(Console.ReadLine());

                    preco = preco * qtd;

                    Console.WriteLine("o total " + preco.ToString("F2", CultureInfo.InvariantCulture) + " reais ");

                    break;


                case 2:
                    preco = 4.50;
                    Console.WriteLine("informe a quantidade ");
                    qtd = int.Parse(Console.ReadLine());

                    preco = preco * qtd;

                    Console.WriteLine("o total " + preco.ToString("F2", CultureInfo.InvariantCulture) + " reais ");

                    break;


                case 3:
                    preco = 5.00;
                    Console.WriteLine("informe a quantidade ");
                    qtd = int.Parse(Console.ReadLine());

                    preco = preco * qtd;

                    Console.WriteLine("o total " + preco.ToString("F2", CultureInfo.InvariantCulture) + " reais ");

                    break;


                case 4:
                    preco = 2.00;
                    Console.WriteLine("informe a quantidade ");
                    qtd = int.Parse(Console.ReadLine());

                    preco = preco * qtd;

                    Console.WriteLine("o total " + preco.ToString("F2", CultureInfo.InvariantCulture) + " reais ");

                    break;


                case 5:
                    preco = 1.50;
                    Console.WriteLine("informe a quantidade ");
                    qtd = int.Parse(Console.ReadLine());

                    preco = preco * qtd;

                    Console.WriteLine("o total " + preco.ToString("F2", CultureInfo.InvariantCulture) + " reais ");

                    break;
                      

            }


        }
    }
}