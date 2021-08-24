using System;
using System.Collections.Generic;
using System.Text;

namespace DP2_ConsoleApp1.cap3
{
    public class Estado
    {
        public Contrato Contrato { get; private set; }
        public Estado(Contrato contrato)
        {
            Contrato = contrato;
        }
    }
}
