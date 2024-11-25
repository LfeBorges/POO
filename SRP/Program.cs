using SRP;
public class Program
{
    public static void Main(string[] args)
    {

        Conta conta = new Conta("Luiz");

        // Realizando operações de depósito e saque
        conta.Deposito(1000);
        conta.Sacar(200);  

        // Validando o usuário
        ValidadorUsuario validador = new ValidadorUsuario();
        Console.WriteLine($"Usuário válido: {validador.ValidarUsuario("Luiz", conta)}");

        // Gerando o relatório
        GeradorRelatorio geradorRelatorio = new GeradorRelatorio();
        Console.WriteLine(geradorRelatorio.GerarRelatorio(conta));
    }
}
