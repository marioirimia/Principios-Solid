using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sustitucion_de_Liskov.Mal_Hecho
{
    public class Main
    {
        public Main()
        {
            AbstractSale sale = new Sale(100, "mario", 0.15m);
            sale.CalculateTaxes();
            sale.Generate();

            sale = new ForeignSale(200,"manolo");
            sale.CalculateTaxes(); //Esto daria expecion porque no se ha desarrollado nada en el metodo de GetTaxes
            sale.Generate();
            
        }
    }
}
