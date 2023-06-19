using Segregacion_de_Interfaces.IServices;
using Segregacion_de_Interfaces.Mal_Hecho.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segregacion_de_Interfaces.Mal_Hecho.Services
{
    //Esto esta mal porque en el contexto no se permitiria Editar Las ventas
    public class SaleService : ICrud<Sale>
    {
        public void Add(Sale entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Sale entity)
        {
            throw new NotImplementedException();
        }

        public List<Sale> GetAll()
        {
            throw new NotImplementedException();
        }

        public Sale GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Sale entity)
        {
            throw new NotImplementedException();
        }
    }
}
