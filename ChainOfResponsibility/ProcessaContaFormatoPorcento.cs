namespace ChainOfResponsibility
{
    public class ProcessaContaFormatoPorcento : IProcessaFormato
    {
        public IProcessaFormato ProximoProcesso { get; private set; }
        public ProcessaContaFormatoPorcento(IProcessaFormato proximo)
        {
            ProximoProcesso = proximo;
        }
        public string FormataConta(Conta conta, Formato formato)
        {
            if(formato == Formato.PORCENTO)
            {
                return Utils.ConcatenaObjeto(conta, '%');
            }

            return ProximoProcesso.FormataConta(conta, formato);
        }
    }
}
