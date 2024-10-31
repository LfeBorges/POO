// Metodo Main()
using InterfaceAutenticavel;

//InterfaceAutenticavel ia = new InterfaceAutenticavel(); erro de compilação

Cliente c = new Cliente();
c.Senha = 123;

InterfaceAutenticavel ia =c;
//ia.Autentica(123);

Console.WriteLine(c.Autentica(123));

Gerente g = new Gerente();
g.Senha = 100;
ia = g;
Console.WriteLine(g.Autentica(100));

Diretor d = new Diretor();
d.Senha = 200;
ia = d;
Console.WriteLine(d.Autentica(100));
