using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoFuncionario
{
    public abstract class Funcionario
    {
        protected double salario;
        protected string nome;
        protected int codido;
        

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        
        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }
        public Funcionario(int codido, string nome, double salario)
        {
            Codigo = codido;
            Nome = nome;
            Salario = salario;
        }
        public abstract double CalcularSalario(int diasUteis);
        public virtual void MostrarAtributos()
        {
            Console.WriteLine("Codigo: " +Codigo+ "\tNome:" +Nome+ "\tSalario: " +Salario);
        }  
    }
}