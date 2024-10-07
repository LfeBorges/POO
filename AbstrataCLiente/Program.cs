// Metodo Main()
using AbstrataCLiente;


// gera erro por não poder instanciar
//Cliente c1 = new Cliente(1,"ANA"); 

Fisico clientefisico = new Fisico(2,"Vinicius", 19, 222);
clientefisico.MostrarAtributos();

Juridico clientejuridico = new Juridico(3,"Rafa", 50, 3333);
clientejuridico.MostrarAtributos();

Teste t = new Teste();
t.AvaliarIdade(clientefisico);
t.AvaliarIdade(clientejuridico);