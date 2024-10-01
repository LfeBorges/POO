// Método Main()
using HerancaFuncionario;

/*Funcionario f = new Funcionario(1,"Ana",1000);
f.MostrarAtributos();
Console.WriteLine($"Bonificação {f.CalcularBonificacao():C}");

Secretario s = new Secretario(2,"Bia",1000);
s.MostrarAtributos();
Console.WriteLine($"Bonificação {s.CalcularBonificacao():C}");

Gerente g = new Gerente(3,"Carla",1000);
g.MostrarAtributos();
Console.WriteLine($"Bonificação {g.CalcularBonificacao():C}");

Diretor d = new Diretor(4,"Diana",1000);
d.MostrarAtributos();
Console.WriteLine($"Bonificação {d.CalcularBonificacao():C}");
*/

Funcionario f = new Funcionario(1, "Kamily", 1000);
f.MostrarAtributos();
Console.WriteLine($"Bonificação: {f.CalcularBonificacao():C}");

Secretario s = new Secretario(2, "Isabela", 1000);
s.MostrarAtributos();
Console.WriteLine($"Bonificação: {s.CalcularBonificacao():C}");

Gerente g = new Gerente(3, "Fabio", 1000);
g.MostrarAtributos();
Console.WriteLine($"Bonificação: {g.CalcularBonificacao():C}");

Diretor d = new Diretor(4, "Leandro", 1000);
d.MostrarAtributos();
Console.WriteLine($"Bonificação: {d.CalcularBonificacao():C}");

// Instanciando GerenciadorBonificacao
GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

// Adicionando bonificações
gerenciador.AdicionarBonificacao(f);
gerenciador.AdicionarBonificacao(s);
gerenciador.AdicionarBonificacao(g);
gerenciador.AdicionarBonificacao(d);

gerenciador.ExibirTotalBonificacoes();

