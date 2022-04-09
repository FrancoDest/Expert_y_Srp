using System;

namespace SRP
{
    public class Libro
    {

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
        /// <summary>
        /// Segun SRP, cada clase debe tener responsabilidad sobre una parte de la funcionalidad y la responsabilidad debe estar completamente encapsulada por la clase. Esto no se cumple porque la clase libro tiene dos metodos que cumplen dos responsabilidades distintas.
        /// </summary>
        /// <param name="sector"></param>
        /// <param name="estante"></param>
        public void AlmacenarLibro(String sector, String estante)
        {
            this.SectorBiblioteca = sector;
            this.EstanteBiblioteca = estante;
        }

    }
}
