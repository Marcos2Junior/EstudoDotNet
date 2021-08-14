using CalculadorDesconto.Impostos;
using System;

namespace CalculadorDesconto
{
    class Program
    {
        static void Main(string[] args)
        {
            Orcamento reforma = new Orcamento(500.0);

            reforma.AplicaDescontoExtra();
            Console.WriteLine(reforma.Valor); // imprime 475,00 pois descontou 5%
            reforma.Aprova(); // aprova nota!

            reforma.AplicaDescontoExtra();
            Console.WriteLine(reforma.Valor); // imprime 465,50 pois descontou 2%

            reforma.Finaliza();
            Console.ReadKey();
        }
    }
}
