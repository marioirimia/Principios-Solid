using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sustitucion_de_Liskov.Mal_Hecho
{
    public class ForeignSale : AbstractSale
    {
        //No tiene impuestos porque es de fuera
        public ForeignSale(decimal amount, string customer)
        {
            this.amount = amount;
            this.customer = customer;
        }

        public override void CalculateTaxes()
        {
            throw new NotImplementedException();
        }

        public override void Generate()
        {
            Console.WriteLine("Se genera venta");
        }
    }
}
