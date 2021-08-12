namespace ChainOfResponsibility
{
    public class Conta
    {
        public string NomeTitutal { get; set; }
        public double Saldo { get; set; }
        public Conta(string nome, double saldo)
        {
            NomeTitutal = nome;
            Saldo = saldo;
        }

        public Conta()
        {
        }
    }
}
