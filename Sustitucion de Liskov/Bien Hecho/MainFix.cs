using Sustitucion_de_Liskov.Bien_Hecho;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sustitucion_de_Liskov.Mal_Hecho
{
    public class MainFix
    {
        public MainFix()
        {
            LocalSale sale = new SaleFix(500, "mario", 0.25m);
            sale.Generate();
            sale.CalculateTaxes();

            AbstractSale saleForeign = new ForeignSale(200, "paco");
            saleForeign.Generate();
            saleForeign.CalculateTaxes();
            
        }
    }
}
