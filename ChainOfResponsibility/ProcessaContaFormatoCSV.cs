namespace ChainOfResponsibility
{
    public class ProcessaContaFormatoCSV : IProcessaFormato
    {
        public ProcessaContaFormatoCSV()
        {
        }

        public string FormataConta(Conta conta, Formato formato)
        {
            if (formato == Formato.CSV)
            {
                return Utils.ConcatenaObjeto(conta, ',');
            }

            return "Formato da requisição não foi identificado";
        }
    }
}
