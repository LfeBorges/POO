// Método Main()

using EncapsulamentoAluno;

Aluno a1 = new Aluno();
a1.Matricula = 1; //set
a1.P1 = 10; //set
a1.P2 = 8; //set
a1.CalacularMedia();
Console.WriteLine("Média: " + a1.Media); //get
a1.Mostrar();
