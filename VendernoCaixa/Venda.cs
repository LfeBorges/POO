using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VendernoCaixa
{
    public class Venda
    {
        private DateTime data;
        private double total;
        private List<ItemVenda> itens;

        public ItemVenda NovoItem(int cod, int quant) {
        ItemVenda item = new ItemVenda(cod, quant);
        total += item.getSubtotal();
        itens.Add(item);
        return item;
        }
    }
}