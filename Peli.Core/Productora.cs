using System.Collections.Generic;

namespace Peli.Core
  
  {
    public class Productora

    {
       public int Id {get; set;}
       public string Nombre {get; set;}
       public List<Pelicula> Peliculas {get;set;}
       public Productora()
       {
           Peliculas = new List<Pelicula>();
       }
        public void AgregarPelicula(Pelicula pelicula)
            => Peliculas.Add(pelicula);
        }
 }