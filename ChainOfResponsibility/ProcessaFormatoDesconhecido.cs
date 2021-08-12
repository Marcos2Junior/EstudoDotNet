using System;

namespace ChainOfResponsibility
{
    public class ProcessaFormatoDesconhecido : IProcessaFormato
    {
        public string FormataConta(Conta conta, Formato formato)
        {
            return "Formato da requisição não foi identificado";
        }
    }
}
