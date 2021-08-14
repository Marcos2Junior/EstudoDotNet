using System;

namespace EstadoContaBancario
{
    public class Conta
    {
        public double Saldo { get; private set; }
        protected EstadoConta EstadoConta;

        public Conta(double saldo)
        {
            Saldo = saldo;
        }

        public void Saca(double valor)
        {
            EstadoConta.Saca(this, valor);
        }

        public void Deposita(double valor)
        {
            EstadoConta.Deposita(this, valor);
        }

        /*
         * Repare que a classe Positivo foi declarada dentro da classe Conta, e por isso ela pode acessar os atributos privados da conta, 
         * então agora podemos deixar o saldo escondido e somente o código da conta e de seus estados poderá acessá-lo
         * 
         * Você vê algum problema em deixar os estados como classes internas da conta?
         * 
         * Geralmente quanto mais frouxa a visibilidade de um atributo (como por exemplo, protected, default, public), maior a chance de uma quebra de encapsulamento ocorrer.
         * Nesse caso, os estados SÃO PARTE do objeto Conta, e precisam conhecer como essa classe é implementada para trabalhar.
         * Optamos por separar os estados em diferentes classes para termos classes menores e mais fáceis de manter, mas eles são quase como uma "continuação" da classe Conta. A quebra de encapsulamento sim ocorre, mas nesse caso, pode ser tolerada.
         * Veja que isso é uma exceção e não uma regra. Fique sempre atento e mantenha suas classes sempre bem encapsuladas!
         */

        class Negativa : EstadoConta
        {
            public void Deposita(Conta conta, double valor)
            {
                conta.Saldo += valor * 0.95;
                if (conta.Saldo > 0)
                {
                    conta.EstadoConta = new Positiva();
                }
            }

            public void Saca(Conta conta, double valor)
            {
                throw new Exception("Sua conta está no vermelho. não é posível sacar!");
            }
        }

        class Positiva : EstadoConta
        {
            public void Deposita(Conta conta, double valor)
            {
                conta.Saldo += valor * 0.98;
            }

            public void Saca(Conta conta, double valor)
            {
                conta.Saldo -= valor;
                if (conta.Saldo < 0)
                {
                    conta.EstadoConta = new Negativa();
                }
            }
        }
    }
}
