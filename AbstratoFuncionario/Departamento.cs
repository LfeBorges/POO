using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoFuncionario
{
    public class Departamento
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public List<Funcionario> VetF { get; set; } = new List<Funcionario>();
        public Departamento(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }
        public void MostrarAtributos()
        {
            Console.WriteLine("Codigo: " +Codigo+ "\tNome: "+ Nome);
        }
        public void Admitir(Funcionario f)
        {
            VetF.Add(f);
        }
        public void Listar()
        {
            MostrarAtributos();
            foreach(Funcionario f in VetF)
                f.MostrarAtributos();
        }
        public void Demitir(int codido)
        {
            for(int i = 0; i < VetF.Count; i++)
            {
                Funcionario f = VetF.ElementAt<Funcionario>(i);
                if (f.Codigo == codido)
                    VetF.Remove(f);
            }
        }   
        public double CalcularFolha(int diasUteis)
        {
            double folha = 0;
            for(int i = 0; i < VetF.Count; i++)
            {
                Funcionario f = VetF.ElementAt<Funcionario>(i);
                folha += f.CalcularSalario(diasUteis);
            }    
            return folha;      
        }
    }
}