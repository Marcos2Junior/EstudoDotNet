using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Aderente
{
    internal class Pedido
    {
        public long Quantidade { get; set; }
        public DateTime Data { get; set; }

        public void IncluirPedido()
        {
            try
            {
                // Codigo para incluir o pedido
            }
            catch (Exception ex)
            {
            }
        }

        public void DeletaPedido()
        {
            try
            {
                //codigo para deletar o pedido gerado
            }
            catch (Exception ex)
            {
            }
        }
    }
}
