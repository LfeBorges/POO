using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VendernoCaixa
{
  public class ItemVenda
    {
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public double Subtotal => Produto.Preco * Quantidade;

        public ItemVenda(Produto produto, int quantidade)
        {
            Produto = produto;
            Quantidade = quantidade;
        }
    }
}