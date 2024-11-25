// Metodo Main()
using AbstratoFuncionario;

/*Assalariado a1 = new Assalariado(1, "Leandro", 1000);
Assalariado a2 = new Assalariado(2, "Rafa", 1100);

Comissionado c1 = new Comissionado(3, "Vini", 1200, 0.20);
Comissionado c2 = new Comissionado(4,"Gabriel", 1300, 0.30);

Departamento d1 = new Departamento(1, "DEV");
d1.VetF = new List<Funcionario>();
d1.Admitir(a1);
d1.Admitir(c1);
d1.Listar();
Console.WriteLine($"Total {d1.CalcularFolha(30):c}");


Departamento d2 = new Departamento(2,"REDES");
d2.VetF = new List<Funcionario>();
d2.Admitir(a2);
d2.Admitir(c2);
d2.Listar();
Console.WriteLine($"Total {d2.CalcularFolha(30):c}");
d2.Demitir(2);
d2.Demitir(1);*/

Assalariado a1 = new Assalariado(1, "Leandro", 1000);
Assalariado a2 = new Assalariado(2, "Rafa", 1100);

Comissionado c1 = new Comissionado(3, "Vini", 1200, 0.20);
Comissionado c2 = new Comissionado(4, "Gabriel", 1300, 0.30);

Dependente d1 = new Dependente(1, "João", 12);
Dependente d2 = new Dependente(2, "Maria", 8);
Dependente d3 = new Dependente(3, "Pedro", 14);

a1.AdicionarDependente(d1);
a1.AdicionarDependente(d2);
c1.AdicionarDependente(d3);

Departamento dept1 = new Departamento(1, "DEV");
dept1.VetF = new List<Funcionario>();
dept1.Admitir(a1);
dept1.Admitir(c1);
dept1.Listar();

Console.WriteLine($"Total na folha de {dept1.Nome}: {dept1.CalcularFolha(30):c}");
Console.WriteLine($"Total de dependentes no departamento {dept1.Nome}: {dept1.VetF.Sum(f => f.CalcularTotalDependentes())}");

Departamento dept2 = new Departamento(2, "REDES");
dept2.VetF = new List<Funcionario>();
dept2.Admitir(a2);
dept2.Admitir(c2);
dept2.Listar();

Console.WriteLine($"Total na folha de {dept2.Nome}: {dept2.CalcularFolha(30):c}");
Console.WriteLine($"Total de dependentes no departamento {dept2.Nome}: {dept2.VetF.Sum(f => f.CalcularTotalDependentes())}");

Console.WriteLine("\n=== Dependentes Listados ===");
a1.ListarDependentes();
c1.ListarDependentes();
