using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LSP
{
public class CartaoCredito : IPagamento
{
public void ValidarDetalhesPagamento(string idConta, decimal valor)
{
    // Verifica se idConta é nula ou vazia
    if (idConta == null || idConta == "")
    {
        Console.WriteLine("ID da conta é requerido.");
    }

    // Verifica se o valor é menor ou igual a zero
    if (valor <= 0)
    {
        Console.WriteLine("O valor deve ser maior que zero!");
    }
}

    public void ProcessarPagamento(string idConta, decimal valor)
    {
        ValidarDetalhesPagamento(idConta, valor);
        Console.WriteLine($"Processado pagamento de {valor:C} do cartão de crédito, na conta: {idConta}");
    }
}
}