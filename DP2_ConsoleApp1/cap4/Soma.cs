using System;
using System.Collections.Generic;
using System.Text;

namespace DP2_ConsoleApp1.cap4
{
    public class Soma : IExpressao
    {
        private IExpressao _esquerda;
        private IExpressao _direita;
        public Soma(IExpressao esquerda, IExpressao direita)
        {
            _esquerda = esquerda;
            _direita = direita;
        }

        public int Avalia()
        {
            return _esquerda.Avalia() + _direita.Avalia();
        }
    }
}
