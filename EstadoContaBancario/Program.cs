﻿using System;

namespace EstadoContaBancario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Uma conta bancária realiza operações de saque e depósito diferente de acordo com seu estado.");
            Console.WriteLine();
            Console.WriteLine("Uma conta que está negativo, por exemplo, não aceita saques, e depositam apenas 95% do valor total " +
                "de um depósito efetuado. Uma conta que está com saldo positivo, aceita saques, e o banco deposita 98% do valor do depósito.");
            Console.WriteLine();
            Console.WriteLine("Use o State para representar os possíveis estados da conta, e a sua transição de estado. Se uma conta passa a " +
                "ter saldo positivo, fica com status POSITIVO. Caso contrário, possui saldo NEGATIVO.");



        }
    }
}
