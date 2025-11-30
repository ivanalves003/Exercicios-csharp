using System;
using System.Globalization;

namespace ex5{

    class Program { 
        
        static void Main (string[] args) {

            double id_peca1, qtd_peca1, valor_peca1;
            double id_peca2, qtd_peca2, valor_peca2;
            double valor_somado;


            Console.WriteLine("informe o id peça 2");
                id_peca1 = double.Parse (Console.ReadLine());
            Console.WriteLine("informe a quantidade da peça 2");
                qtd_peca1 = double.Parse(Console.ReadLine());
            Console.WriteLine("informe o valor da peça 2");
                valor_peca1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("informe o id peça 2");
                id_peca2 = double.Parse(Console.ReadLine());
            Console.WriteLine("informe a quantidade da peça 2");
                qtd_peca2 = double.Parse(Console.ReadLine());
            Console.WriteLine("informe o valor da peça 2");
                valor_peca2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            valor_somado = (qtd_peca1 * valor_peca1) + (qtd_peca2 * valor_peca2);



            Console.WriteLine("o valor a pagar e: " + valor_somado.ToString("F2", CultureInfo.InvariantCulture));


        } 
    }
}