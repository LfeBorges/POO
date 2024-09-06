// Método Main()
using ConstrutorConta;

Conta c1 = new Conta();
c1.MostrarAtributos();
//c1.Saldo = 1;
Conta c2 = new Conta(20);
c2.MostrarAtributos();

Conta c3 = new Conta(30,"Ana");
c3.MostrarAtributos();

Conta c4 = new Conta(40, "Bia", 400);
c4.MostrarAtributos();
Console.WriteLine("Quantidade de instancias: " + Conta.Contador);