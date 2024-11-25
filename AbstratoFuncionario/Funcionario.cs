using System;
using System.Collections.Generic;

namespace AbstratoFuncionario
{
    public abstract class Funcionario
    {
        protected double salario;
        protected string nome;
        protected int codigo;

        public List<Dependente> Dependentes { get; set; } = new List<Dependente>();

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

        public Funcionario(int codigo, string nome, double salario)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
        }

        public abstract double CalcularSalario(int diasUteis);

        public virtual void MostrarAtributos()
        {
            Console.WriteLine($"Codigo: {Codigo}\tNome: {Nome}\tSalario: {Salario:C}");
        }

        // Métodos para gerenciamento de dependentes
        public void AdicionarDependente(Dependente d)
        {
            Dependentes.Add(d);
        }

        public void RemoverDependente(int codigo)
        {
            for (int i = 0; i < Dependentes.Count; i++)
            {
                if (Dependentes[i].Codigo == codigo)
                {
                    Dependentes.RemoveAt(i);
                    break;
                }
            }
        }

        public int CalcularTotalDependentes()
        {
            return Dependentes.Count;
        }

        public void ListarDependentes()
        {
            Console.WriteLine($"Dependentes de {Nome}:");
            foreach (var d in Dependentes)
            {
                d.MostrarAtributos();
            }
        }
    }
}
