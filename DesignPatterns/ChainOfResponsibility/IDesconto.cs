using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibility
{
    public interface IDesconto
    {
        double Calcula(Orcamento orcamento);
        Desconto Proximo { get; set; }
    }
}
