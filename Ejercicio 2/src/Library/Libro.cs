using System;

namespace SRP
{
    public class Libro
    {
        //  Considero que esta clase cumple  con el SRP ya que cumple con todas las responsabilidades que son necesarias para la identificacion y funcionalidad de los libros 
        //  y tambien conoce toda la informacion de los mismo//
        public string Titulo { get ; }
        public string Autor { get ; }
        public string Codigo { get ;  }
        public string SectorBiblioteca { get ; set; }
        public string EstanteBiblioteca { get ; set; }

        public Libro(String titulo, String autor, String codigo)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
        }

        public void AlmacenarLibro(String sector, String estante)
        {
            this.SectorBiblioteca = sector;
            this.EstanteBiblioteca = estante;
        }

    }
}
