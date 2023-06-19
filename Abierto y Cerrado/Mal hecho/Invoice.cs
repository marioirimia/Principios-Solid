using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abierto_y_Cerrado.Mal_hecho
{
    public class Invoice
    {
        public decimal GetTotal(IEnumerable<Drink> lstDrinks)
        {
            decimal total = 0;

            foreach (Drink drink in lstDrinks)
            {
                if (drink.Type.Equals("Agua"))
                {
                    total += drink.Price;
                }

                else if (drink.Type.Equals("Azucar"))
                {
                    total += drink.Price * 3.33m;
                }
                else if (drink.Type.Equals("Alcohol"))
                {
                    total += drink.Price * 14.3m;
                }

                else if (drink.Type.Equals("Energetica"))
                {
                    total += drink.Price * 14.3m - 2;
                }
            }

            return total;
        }

    }
}
