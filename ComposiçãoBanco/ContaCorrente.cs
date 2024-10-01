using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposiçãoBanco
{
    public class ContaCorrente
    {
        public string Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }
        public double ChequeEspecial { get; set; }

        public ContaCorrente(string numero, string titular, double chequeEspecial)
        {
            Numero = numero;
            Titular = titular;
            ChequeEspecial = chequeEspecial;
            Saldo = 0; 
        }
        public void Depositar(double valor)
        {
            Saldo += valor;
            Console.WriteLine($"Conta Corrente: Depositado: {valor}. Saldo Atual: {Saldo}");
        }

        public void Sacar(double valor)
        {
            if (valor <= Saldo + ChequeEspecial)
            {
                Saldo -= valor;
                Console.WriteLine($"Conta Corrente: Sacado: {valor}. Saldo Atual: {Saldo}");
            }
            else
            {
                Console.WriteLine("Conta Corrente: Saldo insuficiente.");
            }
        }

        public void GerarExtrato()
        {
            Console.WriteLine($"Extrato Conta Corrente {Numero}: Titular: {Titular}, Saldo: {Saldo}, Cheque Especial: {ChequeEspecial}");
        }

    }
}