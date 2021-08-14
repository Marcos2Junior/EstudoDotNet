using System;

namespace FiltroBancario
{
    public class Conta
    {
        public double Saldo { get; private set; }
        public DateTime DataAbertura { get; private set; }

        public Conta(double saldo, DateTime dataAbertura)
        {
            Saldo = saldo;
            DataAbertura = dataAbertura;
        }

        public override string ToString()
        {
            return $"Saldo {Saldo:C2}; Data de abertura {DataAbertura:dd/MM/yyyy}";
        }
    }
}