namespace EstadoContaBancario
{
    public interface EstadoConta 
    {
        void Saca(Conta conta, double valor);
        void Deposita(Conta conta, double valor);
    }
}
