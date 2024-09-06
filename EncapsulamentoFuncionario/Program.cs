// Método Main()

using EncapsulamentoFuncionario;

/*Funcionario f1 = new Funcionario();
f1.setCodigo(1);
Console.WriteLine("Codigo" + f1.getCodigo());

Funcionario f2 = new Funcionario();
f2.setCodigo(2);
Console.WriteLine("Codigo" + f2.getCodigo());
*/
Funcionario f1 = new Funcionario();
f1.Codigo = 1; //aqui é executado o método set
Console.WriteLine("Codigo: " + f1.Codigo); // aqui é executado o método get
f1.getNome = "Ana";
Console.WriteLine("Nome: " + f1.Nome); // aqui é executado o método get
f1.Salario = 100;
Console.WriteLine("Salario: " + f1.Salario); // aqui é executado o método get