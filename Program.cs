using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("Bem vindo ao site que converte sua idade em: Meses, Dias, Horas e Minutos");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("Qual é a sua idade?");
            int resposta = int.Parse(Console.ReadLine());

            int meses = resposta * 12;
            int dias = resposta * 365;
            double horas = resposta * 8.760;
            double minutos = resposta * 525.600;

            Console.WriteLine("Resposta:" + meses + "meses,"  + dias + "dias," + horas + "horas" + minutos + "minutos,");
        }
    }
}
