using System;
using System.Collections.Generic;
using System.Text;

namespace DP2_ConsoleApp1.cap4
{
    public class Divisao : IExpressao
    {
        private IExpressao _direita;
        private IExpressao _esquerda;

        public Divisao(IExpressao esquerda, IExpressao direita)
        {
            _direita = direita;
            _esquerda = esquerda;
        }
        public int Avalia()
        {
            return _esquerda.Avalia() / _direita.Avalia();
        }
    }
}
