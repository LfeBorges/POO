// Método Main()
using ConstrutorProduto;

Produto p1 = new Produto();
Console.WriteLine("Digite o nome do produto: ");
p1.Nome = Console.ReadLine();
Console.WriteLine("Digite o preço do produto: ");
p1.Preco = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite a quantidade do produto: ");
p1.Qtde = Convert.ToInt32(Console.ReadLine());
p1.RemoverProduto(1);
p1.AdicionarProduto(2);
Console.WriteLine($"Valor Total {p1.ValorTotalEstoque():c}");