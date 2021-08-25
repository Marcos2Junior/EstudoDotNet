using DP2_ConsoleApp1.cap5;
using System;
using System.Collections.Generic;
using System.Text;

namespace DP2_ConsoleApp1.cap4
{
    public class Numero : IExpressao
    {
        public int Valor { get; private set; }
        public Numero(int numero)
        {
            Valor = numero;
        }

        public int Avalia()
        {
            return Valor;
        }

        public void Aceita(IVisitor visitor)
        {
            visitor.ImprimeNumero(this);
        }
    }
}
