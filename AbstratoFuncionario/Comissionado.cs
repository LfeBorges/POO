using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoFuncionario
{
    public class Comissionado : Funcionario
    {
        private double comissao = 0.20;
        public double Comissao
        {
            get { return comissao; }
            set { comissao = value; }
        }
        public override double CalcularSalario(int diasUteis)
        {
            return (Salario / 30 * diasUteis) * comissao + Salario;
        }
        public override void MostrarAtributos()
        {
            base.MostrarAtributos();
            Console.WriteLine("Comissão: " + Comissao);
        }
        public Comissionado(int codido, string nome, double salario, double comissao) :base (codido, nome, salario)
        {
            Comissao = comissao;   
        }



        
    }
}