using System;
using System.Linq;
using VendernoCaixa;

namespace VendernoCaixa
{
    class Program
    {
        static void Main()
        {
            Produto produto1 = new Produto(1, "Produto A", 10.00, 100);
            Produto produto2 = new Produto(2, "Produto B", 20.00, 50);

            Venda venda = new Venda();


            Console.WriteLine("Quantos itens do Produto A você deseja comprar?");
            int qtdProdutoA = Convert.ToInt32(Console.ReadLine()); // Converte para inteiro
            ItemVenda itemA = new ItemVenda(produto1, qtdProdutoA);
            venda.AdicionarItem(itemA);

            Console.WriteLine("Quantos itens do Produto B você deseja comprar?");
            int qtdProdutoB = Convert.ToInt32(Console.ReadLine()); // Converte para inteiro
            ItemVenda itemB = new ItemVenda(produto2, qtdProdutoB);
            venda.AdicionarItem(itemB);

            // Calcular o total
            venda.CalcularTotal();
            Console.WriteLine($"Total da venda (com ou sem desconto): R${venda.Total}");

            // Método de pagamento
            Console.WriteLine("\nEscolha o método de pagamento:");
            Console.WriteLine("1 - Espécie");
            Console.WriteLine("2 - Cheque");
            Console.WriteLine("3 - Cartão");

            int escolha = Convert.ToInt32(Console.ReadLine()); 

            Pagamento pagamento = null;

            //Escolha do usuário
            switch (escolha)
            {
                case 1:
                    pagamento = new Espécie(venda.Total);
                    break;
                case 2:
                    pagamento = new Cheque(venda.Total);
                    break;
                case 3:
                    pagamento = new Cartao(venda.Total);
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    return;
            }

            // Processar o pagamento
            pagamento.ProcessarPagamento();
        }
    }
}