using Sustitucion_de_Liskov.Mal_Hecho;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sustitucion_de_Liskov.Bien_Hecho
{
    public abstract class LocalSale: AbstractSaleFix
    {
        protected decimal taxes;
        public abstract void CalculateTaxes();

    }
}
