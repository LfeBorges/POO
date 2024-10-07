using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataCLiente
{
    public class Teste
    {
        //representação de relacionamento
        // de dependecia, por meio de um parametro
        // que é o objto de outra classe
        public void AvaliarIdade(Cliente cliente)
        {
            cliente.VerificarIdade();
        }
    }
}