using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoNotaFiscal
{
    public class NotaFiscal
    {
        public int NumeroNf { get; set; }
        public string Data { get; set; }
        public List<ItemNotaFiscal> VetItens { get; set; }
        public NotaFiscal(int numeroNF, string data)
        {
         NumeroNf = numeroNF;
         Data = data;
         //composição aocntece agora, pois os objetos ...
         // ...nota fiscal e vetor de itens são instanciados juntos
         VetItens = new List<ItemNotaFiscal>();   
        }
        ~NotaFiscal(){
            VetItens = null;
            Console.WriteLine("Destruir a nota fiscal");
        }
    }
}