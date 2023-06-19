using Abierto_y_Cerrado.Mal_hecho;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abierto_y_Cerrado.Bien_hecho
{
    public  class Invoice
    {
        public decimal GetTotal(IEnumerable<IDrink> lstDrinks)
        {
            decimal total = 0;

            foreach (IDrink drink in lstDrinks)
            {
                total += drink.GetPrice();
            }
            return total;
        }
    }
}
