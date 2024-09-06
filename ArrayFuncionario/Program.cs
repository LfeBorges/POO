// Metodo Main()
using ArrayFuncionario;

//Criar um vetor com 3 elemntentos 
//Cadastar/digitar

//Calcule o total de salarios de todos os funcionarios

//pesquise se há algum funcionario com 100 de salario,
//Informe se encontrou ou não 
double somasalario = 0 ; 

Funcionario[] vetFuncionarios = new Funcionario[3] ;
for(int i = 0; i < vetFuncionarios.Length; i++)
{
    vetFuncionarios[i] = new Funcionario();
    Console.WriteLine("Digite o codigo do funcionario: ");
    vetFuncionarios[i].codigo = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite o nome do funcionario: ");
    vetFuncionarios[i].nome = Console.ReadLine();
    Console.WriteLine("Digite o salario do funcionario: ");
    vetFuncionarios[i].salario = Convert.ToDouble(Console.ReadLine());
    somasalario += vetFuncionarios[i].salario;
}
Console.WriteLine($"Total {somasalario:c}");


foreach(Funcionario f in vetFuncionarios )
{
    f.MontraAtributos();
}
bool achei = false;
foreach(Funcionario f in vetFuncionarios)
{
    if (f.salario == 100)
    {
        achei = true;
if (achei) //(achei == true)
        Console.WriteLine("Funcionario encontrado!");
else
    Console.WriteLine("Funcionario não encontrado!");
    }
}