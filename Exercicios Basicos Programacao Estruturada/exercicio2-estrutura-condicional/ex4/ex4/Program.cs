using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int hora_inicial, hora_final, duracao;

            Console.WriteLine("informe as horas");
            hora_inicial = int.Parse(Console.ReadLine());
            hora_final = int.Parse(Console.ReadLine());

            if(hora_inicial < hora_final)
            {
                duracao = hora_final - hora_inicial;
            }
            else
            {
                duracao = 24 - hora_inicial + hora_final;
            }

            Console.WriteLine("O jogo durou " + duracao + " horas");

        }
    }
}