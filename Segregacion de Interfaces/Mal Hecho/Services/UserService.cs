using Segregacion_de_Interfaces.IServices;
using Segregacion_de_Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segregacion_de_Interfaces.Mal_Hecho.Services
{
    //Esto estaria bien porque Los Users permiten todos estos metodos
    public class UserService : ICrud<User>
    {
        public void Add(User entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
