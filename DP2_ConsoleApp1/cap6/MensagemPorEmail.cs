using System;

namespace DP2_ConsoleApp1.cap6
{
    public class MensagemPorEmail : IEnviador
    {
        public void Envia(IMensagem mensagem)
        {
            Console.WriteLine("Enviando mensagem por e-mail");
            Console.WriteLine(mensagem.Formata());
        }
    }
}
