using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VendernoCaixa
{
   public class Venda
    {
        public List<ItemVenda> Itens { get; set; } = new List<ItemVenda>();
        public double Total { get; private set; }

        public void AdicionarItem(ItemVenda item)
        {
            Itens.Add(item);
        }

        public void CalcularTotal()
        {
            Total = Itens.Sum(i => i.Subtotal);
            if (Itens.Sum(i => i.Quantidade) > 50)
            {
                Total *= 0.8;  // Aplica 20% de desconto
            }
        }
    }
}