using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacacaoVenda
{
    public class Venda
    {
        private Comprador comp;
        private Vendedor vend;
        private List<Produto> produtosVendidos;

        public Venda(Comprador comp, Vendedor vend)
        {
            this.comp = comp;
            this.vend = vend;
            produtosVendidos = new List<Produto>();
        }

        // Método para realizar uma venda de produto
        public void AdicionarProduto(Produto produto)
        {
            if (comp.PodeComprar(produto.Preco))
            {
                produtosVendidos.Add(produto);
                comp.SubtrairVerba(produto.Preco);
                vend.CalcularComissao(produto.Preco);
                Console.WriteLine($"Produto {produto.Nome} vendido por {produto.Preco:C}.");
            }
            else
            {
                Console.WriteLine($"Verba insuficiente para comprar {produto.Nome}.");
            }
        }

        public void MostrarAtributos()
        {
            Console.WriteLine("\nDetalhes da Venda:");
            comp.MostrarAtributos();
            vend.MostrarAtributos();
            Console.WriteLine("Produtos vendidos:");
            foreach (var produto in produtosVendidos)
            {
                produto.MostrarAtributos();
            }
        }
    }
}