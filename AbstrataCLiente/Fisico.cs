using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataCLiente
{
    public class Fisico : Cliente
    {
        public int Rg { get; set; }
        public Fisico(int codigo, string nome, int idade, int rg) : base (codigo, nome, idade)
        {
            Rg = rg;
        }
        public override void VerificarIdade()
        {
            if (Idade >= 18 && Idade <=45)
                Console.WriteLine("Cliente Fisico ");
        } 
        public override void MostrarAtributos()
        {
            base.MostrarAtributos();
            Console.WriteLine("Rg: " + Rg);
        }
    }
}