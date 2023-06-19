using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sustitucion_de_Liskov.Mal_Hecho
{
    public abstract class AbstractSale
    {
        protected decimal amount;
        protected string customer;
        protected decimal taxes;

        public abstract void Generate();
        public abstract void CalculateTaxes();

    }

   
}
