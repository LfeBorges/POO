using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LSP
{
public class Especie : IPagamento
{
    public void ValidarDetalhesPagamento(string idConta, decimal valor)
    {
        // Para pagamento em espécie, a validação do idConta não é necessária.
        if (valor <= 0)
            Console.WriteLine("O valor deve ser maior que zero!");
    }

    public void ProcessarPagamento(string idConta, decimal valor)
    {
        // Para pagamento em espécie, o idConta não é necessário.
        Console.WriteLine($"Processado pagamento em espécie de {valor:C}.");
    }
}
}