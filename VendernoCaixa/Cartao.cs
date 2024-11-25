using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VendernoCaixa
{
   public class Cartao : Pagamento
    {
        public Cartao(double total) : base(total) { }

        public override void ProcessarPagamento()
        {
            Console.WriteLine($"Pagamento com Cartão de R${Total} realizado com sucesso!");
        }
    }
}
