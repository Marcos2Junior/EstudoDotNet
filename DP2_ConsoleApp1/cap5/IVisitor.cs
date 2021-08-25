using DP2_ConsoleApp1.cap4;
using System;
using System.Collections.Generic;
using System.Text;

namespace DP2_ConsoleApp1.cap5
{
    public interface IVisitor
    {
        void ImprimeSoma(Soma soma);
        void ImprimeSubtracao(Subtracao subtracao);
        void ImprimeMultiplicacao(Multiplicacao multiplicacao);
        void ImprimeDivisao(Divisao divisao);
        void ImprimeNumero(Numero numero);
        void ImprimeRaizQuadrada(RaizQuadrada raizQuadrada);
    }
}
