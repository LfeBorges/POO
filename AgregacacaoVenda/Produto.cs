using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacacaoVenda
{
    public class Produto
    {
        private static int codigoInicial = 500;  // Código inicial a partir de 500
        private int codigo;
        private string nome;
        private double preco;

        public Produto(string nome, double preco)
        {
            this.codigo = codigoInicial++;
            Nome = nome;
            Preco = preco;
        }

        public int Codigo
        {
            get { return codigo; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public double Preco
        {
            get { return preco; }
            set
            {
                if (value > 0)
                    preco = value;
                else
                    Console.WriteLine("Preço inválido.");
            }
        }

        public void MostrarAtributos()
        {
            Console.WriteLine($"Código: {codigo}, Nome: {nome}, Preço: {preco:C}");
        }
    }
}