// Método Main()
using HerancaFuncionario;

Funcionario f = new Funcionario(1,"Ana",1000);
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