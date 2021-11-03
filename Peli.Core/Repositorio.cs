using System.Collections.Generic;
using System.Linq;

namespace Peli.Core
{
    public static class Repositorio
    {
        static int idProductora = 1;
        static int idGenero = 1;

          static readonly List<Productora> productorass = new List<Productora>();
          
            public static Productora GetProductora(int id)
            => productoras.Find(p => p.Id == id);
        public static void AgregarCategoria(Productora productora)
        {
            productora.Id = idProductora++;
            productoras.Add(productora);
        }
        public static Productora GetProductora(int id)
            => productoras.Find(p => p.Id == id);
        public static void AgregarCategoria(Productora productora)
        {
            productora.Id = idProductora++;
            productoras.Add(productora);
        }
        public static Productora GetProductora(int id)
            => productoras.Find(p => p.Id == id);
        public static void AgregarCategoria(Productora productora)
        {
            productora.Id = idProductora++;
            productoras.Add(productora);
        }

    }
}