using System.Collections.Generic;
using System.Linq;

namespace Peli.Core
{
    public static class Repositorio
    {
        static int idProductora = 1;
        static int idGenero = 1;

          static readonly List<Categoria> categorias = new List<Categoria>();
        public static IEnumerable<Categoria> Categorias
            => categorias;
    }
}