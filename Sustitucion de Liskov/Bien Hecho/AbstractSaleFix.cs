using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sustitucion_de_Liskov.Mal_Hecho
{
    public abstract class AbstractSaleFix
    {
        protected decimal amount;
        protected string customer;

        public abstract void Generate();
   

    }

   
}
