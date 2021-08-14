using CalculadorDesconto.Impostos;
using System;

namespace CalculadorDesconto
{
    class Program
    {
        static void Main(string[] args)
        {
            Imposto iss = new ImpostoMuitoAlto(new ICMS());
            Orcamento orcamento = new Orcamento(100);
            double valor = iss.Calcula(orcamento);
            Console.WriteLine(valor);
            Console.ReadKey();
        }
    }
}
