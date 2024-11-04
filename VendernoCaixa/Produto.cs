using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VendernoCaixa
{
    public class Produto
    {
        private long codigo;
        private string nome;
        private double preco;
        private int estoque;
        public  int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }
        public int estoque
        {
            get { return estoque; }
            set { estoque = value; }
        }
    }
}