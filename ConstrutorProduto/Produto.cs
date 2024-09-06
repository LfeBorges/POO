using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorProduto
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public double Qtde { get; set; }

        //Criar 3 construtores
        //Criar o método MostrarAtributos()
        public Produto()
        {
            //construtor padrão
        }
        public Produto(int codigo)
        {
           this.Codigo = codigo; 
        }
        public Produto(int codigo,string nome )
        {
            this.Codigo = codigo;
            this.Nome = nome;
        }
        public void AdicionarProduto(int qtd)
        {
            Qtde += qtd;
        }
        public void RemoverProduto(int qtd)
        {
            Qtde -= qtd;
        }
        public double ValorTotalEstoque()
        {
            return Qtde * Preco;
        }

        public void MostrarAtributos()
        {
            Console.WriteLine("Nome: " +Nome+ "\tQuantidade: " +Qtde+ "\tPreço: " +Preco);
        }
    }
}