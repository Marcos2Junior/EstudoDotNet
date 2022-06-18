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

        private ILogger infoLogger;
        private EnviarEmail enviarEmail;

        public Pedido()
        {
            infoLogger = new RegistraLog();
            enviarEmail = new EnviarEmail();
        }
        public void IncluirPedido()
        {
            try
            {
                infoLogger.Info("Incluindo um pedido");

                enviarEmail.EmailFrom = "emailfrom@xyz.com";
                enviarEmail.EmailTo = "emailto@xyz.com";
                enviarEmail.EmailSubject = "SRP";
                enviarEmail.EmailBody = "um";
                enviarEmail.Enviar();
            }
            catch (Exception ex)
            {
                infoLogger.Info("Erro ao enviar email :" + ex.Message);
            }
        }

        public void DeletaPedido()
        {
            try
            {
                infoLogger.Info("pedido deletado em " + DateTime.Now);
            }
            catch (Exception ex)
            {
                infoLogger.Info("Erro ao deletar o pedido" + ex.Message);
            }
        }
    }
}
