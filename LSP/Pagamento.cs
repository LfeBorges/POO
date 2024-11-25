using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LSP
{
public interface IPagamento
{
    void ValidarDetalhesPagamento(string idConta, decimal valor);
    void ProcessarPagamento(string idConta, decimal valor);
}
}