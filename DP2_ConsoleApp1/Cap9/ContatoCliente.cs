using System;

namespace DP2_ConsoleApp1.Cap9
{
    public class ContatoCliente
    {
        private Cliente cliente;
        private Cobranca cobranca;

        public ContatoCliente(Cliente cliente, Cobranca cobranca)
        {
            this.cliente = cliente;
            this.cobranca = cobranca;
        }

        internal void Dispara()
        {
            throw new NotImplementedException();
        }
    }
}