using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacacaoVenda
{
    public class Vendedor
    {
        private double comissao;

        public Vendedor()
        {
            comissao = 0;
        }

        public double Comissao
        {
            get { return comissao; }
        }

        // Método para calcular a comissão (2% do preço do produto)
        public void CalcularComissao(double valorProduto)
        {
            comissao += valorProduto * 0.02;
        }

        public void MostrarAtributos()
        {
            Console.WriteLine($"Comissão acumulada do vendedor: {comissao:C}");
        }
    }
}