using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VendernoCaixa
{
  public abstract class Pagamento
    {
        public double Total { get; set; }

        public Pagamento(double total)
        {
            Total = total;
        }
        public abstract void ProcessarPagamento();
    }

}