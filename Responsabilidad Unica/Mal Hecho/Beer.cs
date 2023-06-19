using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsabilidad_Unica.Mal_Hecho
{
    public class Beer
    {
        public string Name { get; set; }
        public string Brand { get; set; }

        public Beer(string name, string brand)
        {
            Name = name;
            Brand = brand;
        }

        public void Save()
        {
            Console.WriteLine($"Guardamos {Name} y  {Brand}");
        }

        public void Send()
        {
            Console.WriteLine($"Enviamos {Name} y  {Brand}");
        }
    }
}
