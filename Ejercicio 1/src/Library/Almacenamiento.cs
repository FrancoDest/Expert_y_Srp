namespace SRP
{
    public class Almacenamiento
    {
        private string sector;
        private string estante;
        public string Sector
        {
            get
            {
                return sector;
            }
        }
        public string Estante{
            get
            {
                return estante;
            }
        }

        public Almacenamiento(string sector, string estante)
        {
            this.sector = sector;
            this.estante = estante;
        }
    }
}