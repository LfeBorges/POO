using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaProduto
{
    public class Perecivel : Produto
    {
        private string dtValidade;  
        private string dtFabricacao;
        private string lote;

        public string DtValidade
        {
            get { return dtValidade; }
            set { dtValidade = value; }
        }
        public string DtFabricacao
        {
            get { return dtFabricacao; }
            set { dtFabricacao = value; }
        }
        
        public string Lote
        {
            get { return lote; }
            set { lote = value; }
        }
        
        public Perecivel(int codigo, string nome, double preco, string dtValidade, string dtFabricacao, string lote) : base(codigo, nome, preco)
        {
            DtValidade = dtValidade;
            DtFabricacao = dtFabricacao;
            Lote = lote;

        }
        public void Mostrar(){
            base.Mostrar();
            Console.WriteLine("Data de Fabricação: "+ DtFabricacao + "Data de Validade: " + DtValidade + "Lote: "+ Lote);
        }
        
    }
}