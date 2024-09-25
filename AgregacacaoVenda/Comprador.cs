using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacacaoVenda
{
    public class Comprador
    {
        private double verba;

        public Comprador(double verbaInicial)
        {
            Verba = verbaInicial;
        }

        public double Verba
        {
            get { return verba; }
            set { verba = value; }
        }

        // Método para verificar se há verba suficiente
        public bool PodeComprar(double valor)
        {
            return verba >= valor;
        }
        // Método para subtrair a verba
        public void SubtrairVerba(double valor)
        {
            if (PodeComprar(valor))
                verba -= valor;
        }

        public void MostrarAtributos()
        {
            Console.WriteLine($"Verba disponível: {verba:C}");
        }
    }
}