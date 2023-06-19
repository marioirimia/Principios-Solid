using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abierto_y_Cerrado.Bien_hecho
{
    public interface IDrink
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public decimal Invoice { get; set; }

        public decimal GetPrice();
        
    }
}
