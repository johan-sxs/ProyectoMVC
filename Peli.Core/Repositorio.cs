using System;
using System.Collections.Generic;
using System.Linq;

namespace Peli.Core
{
    public static class Repositorio
    {
        static int idProductora = 1;
        static int idGenero = 1;
        static int idPelicula = 1;

        static readonly List<Productora> productoras = new List<Productora>();
        public static Productora GetProductora(int id)
        => productoras.Find(p => p.Id == id);
        public static void AgregarCategoria(Productora productora)
        {
            productora.Id = idProductora++;
            productoras.Add(productora);
        }
        static readonly List<Genero> generos = new List<Genero>();
        public static IEnumerable<Genero> Generos => generos;
        public static Genero GetGenero(int id)
            => generos.Find(g => g.Id == id);
        public static void AgregarGenero(Genero genero)
        {
            genero.Id = idGenero++;
            generos.Add(genero);
        }

        public static void AgregarPelicula(Pelicula pelicula)
        {
            pelicula.Id = idPelicula++;
      
        }
        public static IEnumerable<Pelicula> Peliculas 
        => generos.SelectMany(c => c.Peliculas);
        public static IEnumerable<Pelicula> PeliculasDe(int idGenero)
        {
            var genero = GetGenero(idGenero);
            if (genero is null)
            {
                return null;
            }
            return genero.Peliculas;
        }
public static Pelicula GetPelicula(int id)
            => Peliculas.First(p => p.Id == id);
    }
}