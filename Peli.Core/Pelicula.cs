using System.Collections.Generic;
using System;

namespace Peli.Core
{
    public class Pelicula
    {
        public int Id {get;set;}
        public string Titulo {get;set;}
        public short Duracion {get; set;}
        public DateTime FechaEstreno {get; set;}
        public string Descripcion {get; set;}

   public pelicula(string titulo,short duracion,DateTime fechaEstreno, string descripcion)
{

   Titulo=titulo;
   Duracion = duracion;
   FechaEstreno = DateTime;
   Descripcion = descripcion

}
    }
}
