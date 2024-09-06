using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorConta
{
    public class Conta
    {
       //declaração dos atributos
        private int numero;

        private string titular;

        private double saldo;
        private static int contador;
        public static int Contador 
        {
            get{return contador;}
        }
        public Conta()
        {
            contador ++;
            //construtor padrão
        }
        public Conta(int numero)
        {
            this.numero = numero;
             contador ++;
        }
        public Conta(int numero, string titular)
        {
            this.numero = numero;
            this.titular = titular;
             contador ++;
        }
        public Conta(int numero, string titular, double saldo)
        {
            this.numero = numero;
            this.titular = titular;
            this.saldo = saldo;
             contador ++;
        }

        //declaração metodo
        public void Sacar()
        {

        }
        public void Depositar()
        {
            
        }
        public void MostrarAtributos()
        {
            Console.WriteLine($"Número {numero} \tTitular: {titular} \tSaldo: {saldo}");
        }
    }
}