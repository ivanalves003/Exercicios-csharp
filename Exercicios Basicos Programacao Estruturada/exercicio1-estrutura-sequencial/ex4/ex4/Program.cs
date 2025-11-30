using System;
using System.Globalization;

namespace ex3
{
    class program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("informe o numero do funcionario");

            int cpf = int.Parse(Console.ReadLine());

            Console.WriteLine("informe o informe o numero de horas trabalhadas");

            double horas = double.Parse(Console.ReadLine());

            Console.WriteLine("informe o valor que recebe por hora");

            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = valor * horas;

            Console.WriteLine("o numero é: " + cpf + "\nhoras trabalhadas é: " + horas + "\nsalario é: " + salario.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}