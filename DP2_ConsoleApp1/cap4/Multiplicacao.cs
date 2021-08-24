using System;
using System.Collections.Generic;
using System.Text;

namespace DP2_ConsoleApp1.cap4
{
    public class Multiplicacao : IExpressao
    {
        private IExpressao _direita;
        private IExpressao _esquerda;

        public Multiplicacao(IExpressao esquerda, IExpressao direita)
        {
            _direita = direita;
            _esquerda = esquerda;
        }
        public int Avalia()
        {
            return _esquerda.Avalia() * _direita.Avalia();
        }
    }
}
