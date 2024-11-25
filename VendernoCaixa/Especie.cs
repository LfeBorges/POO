using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VendernoCaixa
{
 public class Espécie : Pagamento
    {
        public Espécie(double total) : base(total) { }

        public override void ProcessarPagamento()
        {
            Console.WriteLine($"Pagamento em Espécie de R${Total} realizado com sucesso!");
        }
    }

}