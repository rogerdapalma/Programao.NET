using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Encapsulamento
{
    public class ContaBancaria
    {
        public string NumeroConta { get; set; }
        public double Saldo { get; private set; }
        public string Titular { get; set; }

        public ContaBancaria(string numeroConta, string titular, double saldoInicial = 0)
        {
            NumeroConta = numeroConta;
            Titular = titular;
            Saldo = saldoInicial;
        }

        public bool Depositar(double valor)
        {
            if (valor <= 0) return false;
            Saldo += valor;
            return true;
        }

        public bool Sacar(double valor)
        {
            if (valor <= 0 || valor > Saldo) return false;
            Saldo -= valor;
            return true;
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo atual da conta {NumeroConta}: R${Saldo:F2}");
        }
    }
}