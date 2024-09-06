using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseProduto
{
    public class Produto
    {
        //declaração dos produtos
        
        public int qtde;
        public double preco;
        public string nome;

        // declaração de metodo

        public void AdicionarProduto(int qtd)
        {
            qtde += qtd;
        }
        public void RemoverProduto(int qtd)
        {
            qtde -= qtd;
        }
        public double ValorTotalEstoque()
        {
            return qtde * preco;
        }
        public void MostrarAtributos()
        {
            Console.WriteLine("Nome: " +nome+ "\tQuantidade: " +qtde+ "\tPreço: " +preco);
        }
    }
}