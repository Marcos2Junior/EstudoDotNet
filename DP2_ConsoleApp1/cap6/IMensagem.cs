﻿namespace DP2_ConsoleApp1.cap6
{
    public interface IMensagem
    {
        IEnviador Enviador { get; set; }
        void Envia();
        string Formata();
    }
}
