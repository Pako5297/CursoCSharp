using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    public class ContaBancaria
    {
        public string Nome { get; set; }
        public int Conta { get; private set; }
        public double Saldo { get; private  set; }

        public ContaBancaria(string nome, int conta)
        {
            Nome = nome;
            Conta = conta;
        }

        public ContaBancaria(string nome, int conta, double saldo)
        {
            Nome = nome;
            Conta = conta;
            Saldo = saldo;
        }
        public void Deposito(double deposito)
        {
            Saldo = Saldo + deposito;
        }
        public void Saque(double saque)
        {
            Saldo -= saque + 5;
        }

        public override string ToString()
        {
            return "Conta: "
                + Conta
                +", Titular: "
                +Nome
                +", Saldo R$"
                + Saldo;
        }
    }
}
