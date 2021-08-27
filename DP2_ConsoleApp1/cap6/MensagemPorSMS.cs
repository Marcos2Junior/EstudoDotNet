using System;

namespace DP2_ConsoleApp1.cap6
{
    public class MensagemPorSMS : IEnviador
    {
        public void Envia(IMensagem mensagem)
        {
            Console.WriteLine("Enviando mensagem por SMS");
            Console.WriteLine(mensagem.Formata());
        }
    }
}
