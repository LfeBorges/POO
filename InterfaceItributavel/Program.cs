using System;
using InterfaceItributavel;

namespace InterfaceItributavel
{
    public class Program
    {
        static void Main()
        {
            ContaCorrente cc = new ContaCorrente(1000.0);  
            Console.WriteLine($"Tributo da Conta Corrente: {cc.CalculaTributos()}");

            SeguroDeVida sv = new SeguroDeVida();
            Console.WriteLine($"Tributo do Seguro de Vida: {sv.CalculaTributos()}");

            TotalizadorDeTributos totalizador = new TotalizadorDeTributos();
            totalizador.Adiciona(cc);  
            totalizador.Adiciona(sv);  

            Console.WriteLine($"Total de tributos: {totalizador.Total}");
        }
    }
}