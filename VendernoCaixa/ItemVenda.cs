using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VendernoCaixa
{
    public class ItemVenda
    {
        private int quantidade;
        private double preco, subtotal;
        private Produto produto;

        public ItemVenda(int cod, int quant) {
        produto = new Produto();
        quantidade = quant;
        }
    }
}