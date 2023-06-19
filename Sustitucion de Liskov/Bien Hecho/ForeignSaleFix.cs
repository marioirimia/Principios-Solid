using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sustitucion_de_Liskov.Mal_Hecho
{
    public class ForeignSaleFix : AbstractSaleFix
    {
        //No tiene impuestos porque es de fuera
        public ForeignSaleFix(decimal amount, string customer)
        {
            this.amount = amount;
            this.customer = customer;
        }

        public override void Generate()
        {
            Console.WriteLine("Se genera venta");
        }
    }
}
