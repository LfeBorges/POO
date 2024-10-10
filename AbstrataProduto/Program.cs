// Método Main()
using AbstrataProduto;

Disco d = new Disco(1, 21, "ImagineDragons", "Sla");
d.AtualizarPreco(100);
Console.WriteLine(d.preco);

Livro l = new Livro(2, 300, " Box Jogos Vorazes", 1111111);
l.AtualizarPreco(200);
Console.WriteLine(l.preco);
