using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterfaceItributavel;

namespace InterfaceItributavel
{
    public class TotalizadorDeTributos 
    {
        public double Total { get; private set; }

        public void Adiciona(ITributavel t)
        {
            this.Total += t.CalculaTributos(); // Soma os tributos ao total
        }
    }
}
