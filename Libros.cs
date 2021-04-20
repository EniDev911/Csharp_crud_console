using System;
using System.Collections.Generic;
using System.Linq;

namespace Biblioteca
{
    public class Libros
    {
        public int idLibro { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime Lanzaminto { get; set; }

        public Libros()
        {
            
        }
        public Libros(int id, string titutlo, string description, DateTime lanzamiento)
        {
            this.idLibro = id;
            this.Titulo = titutlo;
            this.Descripcion = description;
            this.Lanzaminto = lanzamiento;
        }


        // public IEnumerable<Libros> getLibros()
        // {
            
        //     return IEnumerable<Libros>;
        // }
            
             

    }
}