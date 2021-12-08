using Peli.Core;
using System.Collections.Generic;

namespace Peli.MVC.ViewModels
{
    public class VMPelicula
    {
        public IEnumerable<Genero> Generos { get; set; }

        public IEnumerable<Productora> Productoras{get;set;}

        public Pelicula Pelicula { get; set; }

        public int? IdGeneroSeleccionado { get; set; }

        public int? IdProductoraSeleccionada {get;set;}
        public VMPelicula() => Pelicula = new Pelicula();
        
        public VMPelicula(IEnumerable<Genero> generos) : this()
            => Generos = generos;

        public VMPelicula(IEnumerable<Productora> productoras) : this()
            => Productoras = productoras;
        public VMPelicula(Pelicula pelicula , IEnumerable<Genero> generos ) 
        {
            Pelicula = pelicula;
        }

        public VMPelicula(IEnumerable<Genero> generos, IEnumerable<Productora> productoras) : this(generos)
        {
        }
    }
}