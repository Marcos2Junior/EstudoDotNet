using FiltroBancario.Filtros;
using System;
using System.Collections.Generic;

namespace FiltroBancario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ao identificar contas que possam ser fraudulentas, um banco possui uma série de filtros que devem ser aplicados sobre uma lista de contas.");
            Console.WriteLine();
            Console.WriteLine("=> Contas com saldo menor que 100 reais ou");
            Console.WriteLine("=> Contas com saldo maior do que 500 mil reais, ou");
            Console.WriteLine("=> Contas com data de abertura no mês corrente Todas essas são geralmente selecionadas para uma análise mais detalhada.");
            Console.WriteLine();
            Console.WriteLine("Usando Decorators, implemente esse conjunto de filtros e faça com que, ao receber uma lista, o decorator devolva uma nova lista com as contas " +
                "que atendam a pelo menos um dos critérios acima. Isto é, queremos que o Filtro tenha pelo menos o método de filtragem de contas:");

            List<Conta> contas = new List<Conta>
            {
                new Conta(500, new DateTime(2021, 08, 22)),
                new Conta(500, new DateTime(2020, 02, 05)),
                new Conta(500, new DateTime(2015, 07, 14)),
                new Conta(500, new DateTime(2016, 02, 19)),
                new Conta(500, new DateTime(2020, 04, 01)),
                new Conta(500, new DateTime(2021, 08, 16))
            };


            Filtro filtro = new FiltroDataAberturaMesmoMes(new FiltroSaldoMaiorQue500MilReais(new FiltroSaldoMenorQue100Reais()));

            IList<Conta> resultadoFiltro = filtro.Filtra(contas);
            if(resultadoFiltro.Count > 0)
            {
                foreach (Conta conta in resultadoFiltro)
                {
                    Console.WriteLine($"=> {conta}");
                }
            }
            else
            {
                Console.WriteLine("Filtro não retornou nenhuma conta");
            }

            Console.ReadKey();
        }
    }
}
