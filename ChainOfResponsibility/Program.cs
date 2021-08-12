using System;
using System.Text.RegularExpressions;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcessaRequisicao processaRequisicao = new ProcessaRequisicao();
            Console.WriteLine("CSV: " + processaRequisicao.SolicitaConta(new Conta("MARCOS JUNIOR", 500), new Requisicao(Formato.CSV)));
            Console.WriteLine("XML: " + processaRequisicao.SolicitaConta(new Conta("SAMANTHA CRISTINA", 350.25), new Requisicao(Formato.XML)));
            Console.WriteLine("PORCENTO: " + processaRequisicao.SolicitaConta(new Conta("DANIEL ZEBINI", 1250.75), new Requisicao(Formato.PORCENTO)));
            Console.WriteLine("DESCONHECIDO: " + processaRequisicao.SolicitaConta(new Conta("PAULO CESAR CALEFFI", 100), new Requisicao((Formato)999)));

        }
    }
}
