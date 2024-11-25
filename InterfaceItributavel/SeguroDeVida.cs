using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceItributavel
{
    public class SeguroDeVida : ITributavel
    {
         // Implementação do método CalculaTributos da interface
    public double CalculaTributos()
    {
        return 75.0; // valor fixo de R$ 75,00
    }
    }
}