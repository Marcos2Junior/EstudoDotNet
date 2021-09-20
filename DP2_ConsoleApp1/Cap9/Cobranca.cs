using System;

namespace DP2_ConsoleApp1.Cap9
{
    public class Cobranca
    {
        private Tipo tipo;
        private Fatura fatura;

        public Cobranca(Tipo tipo, Fatura fatura)
        {
            this.tipo = tipo;
            this.fatura = fatura;
        }

        internal void Emite()
        {
            throw new NotImplementedException();
        }
    }
}