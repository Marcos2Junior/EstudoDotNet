namespace ChainOfResponsibility
{
    public interface IProcessaFormato
    {
        string FormataConta(Conta conta, Formato formato);
    }
}
