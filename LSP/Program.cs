using LSP;
public class Program
{
    public static void Main()
    {
        // Criando os diferentes tipos de pagamento
        IPagamento cartaoCredito = new CartaoCredito();
        IPagamento payPal = new PayPal();
        IPagamento especie = new Especie();

        // Processando os pagamentos diretamente
        cartaoCredito.ProcessarPagamento("12345", 100);
        payPal.ProcessarPagamento("67890", 150);
        especie.ProcessarPagamento("", 50);
    }
}