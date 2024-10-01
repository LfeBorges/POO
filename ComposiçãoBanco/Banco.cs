using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposiçãoBanco
{
    public class Banco
    {
        private List<ContaCorrente> contasCorrentes;
        private List<Poupanca> contasPoupanca;

        public Banco()
        {
            contasCorrentes = new List<ContaCorrente>();
            contasPoupanca = new List<Poupanca>();
        }

        public void AbrirContaCorrente(string numero, string titular, double chequeEspecial)
        {
            ContaCorrente conta = new ContaCorrente(numero, titular, chequeEspecial);
            contasCorrentes.Add(conta);
            Console.WriteLine($"Conta Corrente aberta para {titular} com número {numero}.");
        }

        public void AbrirContaPoupanca(string numero, string titular)
        {
            Poupanca poup = new Poupanca(numero, titular);
            contasPoupanca.Add(poup);
            Console.WriteLine($"Conta Poupança aberta para {titular} com número {numero}.");
        }
    }
}