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
         public static IEnumerable<Productora> Productoras => productoras;

        public static Productora GetProductora(int id)
        => productoras.Find(p => p.Id == id);
        public static void AgregarProductora(Productora productora)
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

        static readonly List<Pelicula> peliculas = new List<Pelicula>();
        public static IEnumerable<Pelicula> Peliculas => peliculas;
        public static Pelicula GetPelicula(int id)
            => peliculas.Find(p => p.Id == id);
        public static void AgregarPelicula(Pelicula pelicula)
        {
            pelicula.Id = idPelicula++;
            peliculas.Add(pelicula);
        }

    }
}