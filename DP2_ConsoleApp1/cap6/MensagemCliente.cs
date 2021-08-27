namespace DP2_ConsoleApp1.cap6
{
    public class MensagemCliente : IMensagem
    {
        private string nome;

        public IEnviador Enviador { get; set; }

        public MensagemCliente(string nome)
        {
            this.nome = nome;
        }
        public void Envia()
        {
            this.Enviador.Envia(this);
        }

        public string Formata()
        {
            return string.Format("Mensagem para o cliente {0}", nome);
        }
    }
}
