using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorAluno
{
    public class Aluno
    {
        private string nome;
        private int matricula;
        private static int contador;

        public static int Contador
        {
            get{return contador;}
        }

        public Aluno()
        {
            contador ++;
            this.matricula = GerarMatricula();
        }
        public Aluno(string nome)
        {
            this.nome = nome;
            contador ++;
            this.matricula = GerarMatricula();
        }

        private int GerarMatricula()
        {
            return 1570482313 + contador;  
        }
        public void Mostrar()
        {
            Console.WriteLine($"Nome: {nome}, Matrícula: {matricula}");
        }
    }
}