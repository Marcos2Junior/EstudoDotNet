using DP2_ConsoleApp1.cap5;
using System;
using System.Collections.Generic;
using System.Text;

namespace DP2_ConsoleApp1.cap4
{
    public class Divisao : IExpressao
    {
        public IExpressao Esquerda { get; private set; }
        public IExpressao Direita { get; private set; }

        public Divisao(IExpressao esquerda, IExpressao direita)
        {
            Direita = direita;
            Esquerda = esquerda;
        }

        public void Aceita(IVisitor visitor)
        {
            visitor.ImprimeDivisao(this);
        }

        public int Avalia()
        {
            return Esquerda.Avalia() / Direita.Avalia();
        }
    }
}
