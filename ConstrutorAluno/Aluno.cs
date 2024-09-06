using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorAluno
{
    public class Aluno
    {
        private string aluno;
        private int matricula;
        private static int contador;
    
    }
   /* public string Aluno
    {
        set 
        {
            this.aluno = aluno;
        }
        get
        {
            return aluno;
        }
    }
    public int Matricula
    {
        set
        {
            this.matricula = matricula;
        }
        get
        {
            return matricula;
        }
    }
    */
    public static int Contador
    {
        get{return contador;}
    }

    public Aluno()
    {
        contador ++;
    }
    public Aluno(string nome)
    {
        this.nome = Nome;
        contador ++;
    }
    public Aluno(string nome, int matricula)
    {
        this.nome = nome;
        this.matricula = matricula;
        contador ++;
    }
}