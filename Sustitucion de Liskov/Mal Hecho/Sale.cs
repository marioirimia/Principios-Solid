using Sustitucion_de_Liskov.Mal_Hecho;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sustitucion_de_Liskov.Mal_Hecho
{
    public class Sale : AbstractSale
    {
        public Sale(decimal amount, string customer, decimal taxes)
        {
            this.amount = amount;
            this.customer = customer;
            this.taxes = taxes;
        }

        public override void CalculateTaxes()
        {
            Console.WriteLine("se genera venta");
        }

        public override void Generate()
        {
            Console.WriteLine("se calculan los impuestos");
        }
    }
}
