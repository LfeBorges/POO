using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaFuncionario
{
    public class GerenciadorBonificacao
    {
        private double totalBonificacao;

        // Construtor da classe GerenciadorBonificacao
        public GerenciadorBonificacao()
        {
            totalBonificacao = 0;
        }

        // Método para somar bonificação de Funcionário
        public void AdicionarBonificacao(Funcionario funcionario)
        {
            totalBonificacao += funcionario.CalcularBonificacao();
            Console.WriteLine($"Bonificação do Funcionário {funcionario.Nome}: {funcionario.CalcularBonificacao():C}");
        }

        // ... para somar bonificação de Secretário
        public void AdicionarBonificacao(Secretario secretario)
        {
            totalBonificacao += secretario.CalcularBonificacao();
            Console.WriteLine($"Bonificação do Secretário {secretario.Nome}: {secretario.CalcularBonificacao():C}");
        }

        // ... para somar bonificação de Gerente
        public void AdicionarBonificacao(Gerente gerente)
        {
            totalBonificacao += gerente.CalcularBonificacao();
            Console.WriteLine($"Bonificação do Gerente {gerente.Nome}: {gerente.CalcularBonificacao():C}");
        }

        // ... para somar bonificação de Diretor
        public void AdicionarBonificacao(Diretor diretor)
        {
            totalBonificacao += diretor.CalcularBonificacao();
            Console.WriteLine($"Bonificação do Diretor {diretor.Nome}: {diretor.CalcularBonificacao():C}");
        }

        // ... para exibir o total de bonificações
        public void ExibirTotalBonificacoes()
        {
            Console.WriteLine($"Total de Bonificações: {totalBonificacao:C}");
        }
    }
}
