namespace DP2_ConsoleApp1.cap6
{
    public class MensagemAdministrativa : IMensagem
    {
        private string nome;

        public IEnviador Enviador { get; set; }

        public MensagemAdministrativa(string nome)
        {
            this.nome = nome;
        }
        public void Envia()
        {
            this.Enviador.Envia(this);
        }

        public string Formata()
        {
            return string.Format("Mensagem administrativa para {0}", nome);
        }
    }
}
