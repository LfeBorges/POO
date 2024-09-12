// Método Main()

using ComposicaoNotaFiscal;

ItemNotaFiscal it1 = new ItemNotaFiscal(10);
ItemNotaFiscal it2 = new ItemNotaFiscal(3);

NotaFiscal nf = new NotaFiscal(1,"11/09/2024");
nf.VetItens.Add(it1);
nf.VetItens.Add(it2);

nf = null; // forçando a destruição da instância 
GC.Collect(); //forçando chamada do coletor de lixo e consequentemente o destrutor