// Metodo Main()
using AbstratoFuncionario;

Assalariado a1 = new Assalariado(1, "Leandro", 1000);
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
d2.Demitir(1);