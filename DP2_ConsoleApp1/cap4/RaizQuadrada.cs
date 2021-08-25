using DP2_ConsoleApp1.cap5;
using System;
using System.Collections.Generic;
using System.Text;

namespace DP2_ConsoleApp1.cap4
{
    public class RaizQuadrada : IExpressao
    {
        public IExpressao Valor { get; set; }

        public RaizQuadrada(IExpressao expressao)
        {
            Valor = expressao;
        }

        public void Aceita(IVisitor visitor)
        {
            visitor.ImprimeRaizQuadrada(this);
        }

        public int Avalia()
        {
            double.TryParse(Valor.Avalia().ToString(), out double result);
            return (int)Math.Sqrt(result);
        }
    }
}
