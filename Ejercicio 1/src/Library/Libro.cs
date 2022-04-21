using System;

namespace SRP
{
    public class Libro
    {

        public string Titulo { get; }
        public string Autor { get; }
        public string Codigo { get; }
        private Almacenamiento Lugar { get; set; }
        public string SectorBiblioteca { get { return Lugar.Sector; } }
        public string EstanteBiblioteca { get { return Lugar.Estante; } }

        public Libro(String titulo, String autor, String codigo)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
        }

        public void AlmacenarLibro(String sector, String estante)
        {
            this.Lugar = new Almacenamiento(sector, estante);
        }

    }
}
