using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataCLiente
{
    public  abstract class Cliente
    {
        protected int codigo;
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        protected string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        protected int idade;
        public int Idade 
        {
            get { return idade; }
            set { idade = value; }
        }
        public Cliente(int codigo, string nome, int idade)
        {
            Codigo = codigo;
            Nome = nome;
            Idade = idade;
        }
        public virtual void MostrarAtributos()
        {
            Console.WriteLine("Codigo: " + Codigo + "\tNome: "+Nome+ "\tIdade: " + Idade);
        }
        public abstract void VerificarIdade();// Assinatura de metodo, saber se tera retorno, saber o nome/oq fara, saber se tera parametro
    }   
}       