using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceAutenticavel
{
    public class Funcionario : IAutenticavel
    {
        public int Senha { get; set; }
        public bool Autentica(int senha)
        {
            
            if (Senha == senha)
            {
                Console.WriteLine("Funcionario autenticado!");
                return true;
            }
            return false;
        }
    }        
}