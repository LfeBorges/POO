using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaCliente
{ //           classe derivada : classe base
    public class ClienteFisico : Cliente
    {
        private int cpf;
        private int rg;
        public int Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public int Rg
        {
            get { return rg; }
            set { rg = value; }
        }
        public ClienteFisico(int codigo, string nome, int cpf, int rg) : base(codigo, nome)
        {
            Cpf = cpf;
            Rg = rg;
        }
        public ClienteFisico() : base()
        {            
        }
        
    
        public void Mostrar()
        {
            base.Mostrar(); //Apresenta o código e o nome
            Console.WriteLine("RG: " + Rg + "\tCPF: " +Cpf);
        }
    }
}