using System;
using System.Collections.Generic;
using System.Text;

namespace DP2_ConsoleApp1.cap4
{
    public class RaizQuadrada : IExpressao
    {
        private IExpressao _expressao;

        public RaizQuadrada(IExpressao expressao)
        {
            _expressao = expressao;
        }
        public int Avalia()
        {
            double.TryParse(_expressao.Avalia().ToString(), out double result);
            return (int)Math.Sqrt(result);
        }
    }
}
