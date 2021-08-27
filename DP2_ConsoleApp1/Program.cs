using DP2_ConsoleApp1.cap2;
using DP2_ConsoleApp1.cap3;
using DP2_ConsoleApp1.cap4;
using DP2_ConsoleApp1.cap5;
using DP2_ConsoleApp1.cap6;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DP2_ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Capitulo 6

            IEnviador enviador = new MensagemPorEmail();
            IMensagem mensagem = new MensagemAdministrativa("Marcos");
            mensagem.Enviador = enviador;
            mensagem.Envia();
            #endregion

            #region Capitulo 4
            //IExpressao esquerda = new Soma(new Numero(1), new Numero(10));
            //IExpressao direita = new Subtracao(new Numero(20), new Numero(10));

            //IExpressao soma = new Soma(esquerda, direita);

            //Console.WriteLine(soma.Avalia());

            //ImpressoraVisitor impressora = new ImpressoraVisitor();
            //soma.Aceita(impressora);

            //Expression soma = Expression.Add(Expression.Constant(10), Expression.Constant(100));
            //Func<int> funcao = Expression.Lambda<Func<int>>(soma).Compile();
            //Console.WriteLine(funcao());
            #endregion

            #region Capitulo 3
            //Historico historico = new Historico();
            //Contrato c = new Contrato(DateTime.Now, "Marcos", TipoContrato.Novo);
            //historico.Adiciona(c.SalvaEstado());

            //c.Avanca();
            //historico.Adiciona(c.SalvaEstado());

            //c.Avanca();
            //historico.Adiciona(c.SalvaEstado());

            //Console.WriteLine(historico.Pega(0).Contrato.Tipo);
            //Console.WriteLine(historico.Pega(1).Contrato.Tipo);
            //Console.WriteLine(historico.Pega(2).Contrato.Tipo);
            #endregion

            #region Capitulo 2

            //    NotasMusicais notas = new NotasMusicais();
            //    IList<INota> musica = new List<INota>()
            //    {
            //        notas.Pega("do"),
            //    notas.Pega("re"),
            //    notas.Pega("mi"),
            //    notas.Pega("fa"),
            //    notas.Pega("fa"),
            //    notas.Pega("fa"),

            //    notas.Pega("do"),
            //    notas.Pega("re"),
            //    notas.Pega("do"),
            //    notas.Pega("re"),
            //    notas.Pega("re"),
            //    notas.Pega("re"),

            //    notas.Pega("do"),
            //    notas.Pega("sol"),
            //    notas.Pega("fa"),
            //    notas.Pega("mi"),
            //    notas.Pega("mi"),
            //    notas.Pega("mi"),

            //    notas.Pega("do"),
            //    notas.Pega("re"),
            //    notas.Pega("mi"),
            //    notas.Pega("fa"),
            //    notas.Pega("fa"),
            //    notas.Pega("fa")
            //    };

            //    Piano piano = new Piano();
            //    piano.Toca(musica);

            #endregion
        }
    }
}
