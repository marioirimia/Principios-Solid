using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segregacion_de_Interfaces.IServices
{
    public interface ICrud <T>
    {
        public T GetById (int id);
        public List<T> GetAll();
        public void Add(T entity);
        public void Update(T entity);
        public void Delete(T entity);
    }
}
