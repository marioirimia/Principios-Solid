using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Responsabilidad_Unica.Bien_Hecho
{
    public class BeerRequest
    {
        private Beer _beer;
        public BeerRequest(Beer beer)
        {
            this._beer = beer;
        }

        public void Send()
        {
            Console.WriteLine($"Enviamos {_beer.Name} y  {_beer.Brand}");
        }
    }
}
