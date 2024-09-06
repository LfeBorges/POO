using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoFuncionario
{
    public class Funcionario
    {
        //declaração dos atributos
        private int codigo;
        private string nome;
        private double salario;
        //declaração dos métodos
        //
        /*public void setCodigo(int codigo)
        {
            this.codigo = codigo;
        }
        public int getCodigo()
        {
            return this.codigo;
        }*/
        public int Codigo //propriedade
        {
            set
            {
                this.codigo = value;
            }
            get
            {
                return codigo;
            }
        }
        public void setNome(string Nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return this.nome;
        }
        public double Salario
        {
            set
            {
                this.salario = salario;
            }
            get
            {
                return this.salario;
            }
        }
        private void MontraAtributos()
        {
            Console.WriteLine("Código: " + codigo +
            "\tNome: " + nome + "\tSalário R$ " + salario);
        }
        //criar um método para aplicar uma porcentagem 
        //de aumento ao salário
        public void CalcularAumento(double porcentagem)
        {
            salario += salario * porcentagem / 100;
        }
    }
}