using ArrayConta;

for(int i = 0; i < vetContas.Lenght; i++)
{
    vetContas[i] = new Conta();
    Console.WriteLine("Digite o núemro da conta: ");
    vetContas[i].numero = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite o Titular da conta: ");
    vetContas[i].nome = Console.ReadLine();
    Console.WriteLine("Digite o saldo da conta: ");
    vetContas[i].saldo = Convert.ToDouble(Console.ReadLine());
}

/*foreach(Conta c in vetContas)
{
    
}
*/
