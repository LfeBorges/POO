//Método Main()
using AgregacacaoVenda;

// Instanciando comprador com verba de R$ 12.000,00
Comprador comp = new Comprador(12000);


Vendedor vend = new Vendedor();


Produto p1 = new Produto("Notebook", 5000);
Produto p2 = new Produto("Smartphone", 3000);
Produto p3 = new Produto("Tablet", 2500);

// Criando a venda
Venda v = new Venda(comp, vend);

// Realizando vendas
v.AdicionarProduto(p1);  
v.AdicionarProduto(p2);  
v.AdicionarProduto(p3);  

v.MostrarAtributos();