using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    internal class ContaCorrente
    {
        private int agencia;
        private string nmrconta;
        private string nometitular;
        public double Saldo { get; private set; }

        public ContaCorrente(int agencia, string numeroConta, string nomeTitular, double saldo)
        {
            Agencia = agencia;
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
            Saldo = saldo;

        }
        public int Agencia
        {
            get { return agencia; }
            set
            {
                if (value <= 0)
                    throw new Exception("O número da agência deve ser maior que 0");
                else agencia = value;
            }
        }
        public string NumeroConta
        {
            get { return nmrconta; }
            set
            {
                if (value.Trim().Length == 0) throw new Exception("A conta deve possuir um número");
                else nmrconta = value;
            }
        }
        public string NomeTitular
        {
            get { return nometitular; }
            set
            {
                if (value.Trim().Length < 3)
                    throw new Exception("A conta deve possuir um titular válido");
                else if (value.Trim().Split().Length < 2)
                    throw new Exception("O titular deve ter um nome e sobrenome");
                else nometitular = value;
            }
        }
        public void Saque(double valor)
        {
            if (valor > Saldo)
            {
                throw new InvalidOperationException("Saldo insuficiente.");
            }

            Saldo -= valor;
        }
        public void Deposito(double valor)
        {
            Saldo += valor;
        }
    }
}
