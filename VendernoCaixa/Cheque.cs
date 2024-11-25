using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VendernoCaixa
{
  public class Cheque : Pagamento
    {
        public Cheque(double total) : base(total) { }

        public override void ProcessarPagamento()
        {
            Console.WriteLine($"Pagamento por Cheque de R${Total} realizado com sucesso!");
        }
    }

}