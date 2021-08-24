using System;
using System.Collections.Generic;
using System.Text;

namespace DP2_ConsoleApp1.cap4
{
    public class Numero : IExpressao
    {
        private int _numero;
        public Numero(int numero)
        {
            _numero = numero;
        }

        public int Avalia()
        {
            return _numero;
        }
    }
}
