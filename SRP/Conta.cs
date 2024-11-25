using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SRP
{
public class Conta
{
    public string Titular { get; private set; }
    public decimal Saldo { get; private set; }

    public Conta(string titular)
    {
        Titular = titular;
        Saldo = 0;
    }

    // Responsabilidade de gerenciar saldo
    public void Deposito(decimal valor)
    {
        if (valor <= 0)
        {
            Console.WriteLine("O valor deve ser positivo!");
        }
        else
        {
            Saldo += valor;
        }
    }

    // Responsabilidade de gerenciar saldo
    public void Sacar(decimal valor)
    {
        if (valor > Saldo)
        {
            Console.WriteLine("Saldo insuficiente!");
        }
        else
        {
            Saldo -= valor;
            Console.WriteLine($"Você sacou: {valor:C}");  // Exibe o valor sacado
        }
    }
}
}