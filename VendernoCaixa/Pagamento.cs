using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VendernoCaixa
{
    public class Pagamento
    {
        private DateTime data;
        private double total;
        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        public double total
        {
            get { return total; }
            set { total = value; }
        }
        
    }
}