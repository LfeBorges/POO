using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposiçãoBanco
{
    public class Poupanca
    {
        public string Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public Poupanca(string numero, string titular)
        {
            Numero = numero;
            Titular = titular;
            Saldo = 0;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
            Console.WriteLine($"Conta Poupança: Depositado: {valor}. Saldo Atual: {Saldo}");
        }

        public void Sacar(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"Conta Poupança: Sacado: {valor}. Saldo Atual: {Saldo}");
            }
            else
            {
                Console.WriteLine("Conta Poupança: Saldo insuficiente.");
            }
        }

        public double GerarRendimento(double taxa)
        {
            double rendimento = Saldo * taxa;
            Saldo += rendimento;
            Console.WriteLine($"Rendimento Gerado: {rendimento}. Saldo Atual: {Saldo}");
            return rendimento;
        }
    }
}