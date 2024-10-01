// Método-Main()

using ComposiçãoBanco;

Banco banco = new Banco();

banco.AbrirContaCorrente("001", "Kamily", 500);
banco.AbrirContaPoupanca("002", "Isabela");

// Operações na conta corrente
ContaCorrente conta = new ContaCorrente("001", "Kamily", 500);
conta.Depositar(1000);
conta.Sacar(300);
conta.GerarExtrato();

// Operações na conta poupança
Poupanca poup = new Poupanca("002", "Isabela");
poup.Depositar(200);
poup.Sacar(50);
poup.GerarRendimento(0.05); 
