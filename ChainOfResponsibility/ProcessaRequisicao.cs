namespace ChainOfResponsibility
{
    public class ProcessaRequisicao
    {
        public string SolicitaConta(Conta conta, Requisicao requisicao)
        {
            IProcessaFormato processaFormato = new ProcessaContaFormatoXML(
                new ProcessaContaFormatoPorcento(
                new ProcessaContaFormatoCSV()));
            string result = processaFormato.FormataConta(conta, requisicao.Formato);
            return string.IsNullOrEmpty(result) ? "Formato não definido" : result;
        }
    }
}
