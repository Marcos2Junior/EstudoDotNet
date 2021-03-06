using DP2_ConsoleApp1.cap5;
using System;
using System.Collections.Generic;
using System.Text;

namespace DP2_ConsoleApp1.cap4
{
    public class Subtracao : IExpressao
    {
        public IExpressao Esquerda { get; private set; }
        public IExpressao Direita { get; private set; }
        public Subtracao(IExpressao esquerda, IExpressao direita)
        {
            Esquerda = esquerda;
            Direita = direita;
        }

        public int Avalia()
        {
            return Esquerda.Avalia() - Direita.Avalia();
        }

        public void Aceita(IVisitor visitor)
        {
            visitor.ImprimeSubtracao(this);
        }
    }
}
