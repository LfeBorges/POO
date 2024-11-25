using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceItributavel
{
    public class ContaCorrente : ITributavel
    {
         public double Saldo { get; set; }

    public ContaCorrente(double saldo)
    {
        Saldo = saldo;
    }

    // Implementação do método CalculaTributos da interface
    public double CalculaTributos()
    {
        return Saldo * 0.05; // 5% do saldo
    }
    }
}