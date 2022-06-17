using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Violacao
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
                // apos incluir entao envia o email
                MailMessage mailMessage = new MailMessage("emailFrom", "emailTo",
                    "emailSubject", "emailbody");
                EnviarEmailPedido(mailMessage);
            }
            catch (Exception ex)
            {
                File.WriteAllText(@"c:\dados\ErrorLog.txt", ex.ToString());
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
                File.WriteAllText(@"c:\dados\ErrorLog.txt", ex.ToString());
            }
        }

        public void EnviarEmailPedido(MailMessage mailMessage)
        {

        }
    }
}
