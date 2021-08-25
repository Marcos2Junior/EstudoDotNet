using DP2_ConsoleApp1.cap5;
using System;
using System.Collections.Generic;
using System.Text;

namespace DP2_ConsoleApp1.cap4
{
    public class Multiplicacao : IExpressao
    {
        public IExpressao Esquerda { get; private set; }
        public IExpressao Direita { get; private set; }

        public Multiplicacao(IExpressao esquerda, IExpressao direita)
        {
            Direita = direita;
            Esquerda = esquerda;
        }
        public int Avalia()
        {
            return Esquerda.Avalia() * Direita.Avalia();
        }

        public void Aceita(IVisitor visitor)
        {
            visitor.ImprimeMultiplicacao(this);
        }
    }
}
