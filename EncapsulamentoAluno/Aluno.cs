using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoAluno
{
    public class Aluno
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public double P1 { get; set; }
        public double P2 { get; set; }
        public double Media { get; private set; }

        //declaração do métodos
        public void CalacularMedia()
        {
            Media = (P1 + P2) / 2;
        }
        //método mostrar 
        public void Mostrar()
        {
            Console.WriteLine($"Matricula: {Matricula} \tNome: {Nome} \tP1: {P1:n1} \tP2 {P2:n1} \tMédia: {Media:n1}");
        }

    }

}