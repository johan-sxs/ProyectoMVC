using Peli.Core;
using System.Collections.Generic;

namespace Peli.MVC.ViewModels
{
    public class VMPelicula
    {
        public IEnumerable<Genero> Generos { get; set; }
        public Pelicula Pelicula { get; set; }
        public int? IdGeneroSeleccionado { get; set; }
        public VMPelicula() => Pelicula = new Pelicula();
        public VMPelicula(IEnumerable<Genero> generos) : this()
            => Generos = generos;

        public VMPelicula(Pelicula pelicula)
        {
            Pelicula = pelicula;
        }
    }
}