namespace TurismoApp.Domain.Entities
{
    public class Vuelo
    {
        public int Id { get; set; }
        public string Origen { get; set; } = "Buenos Aires";
        public string Destino { get; set; } = string.Empty;
        public DateTime HoraSalida { get; set; } = DateTime.Now;
        public DateTime HoraLlegada { get; set; } = DateTime.Now;
        public string Aerolinea { get; set; } = string.Empty;
        public float Precio { get; set; } = 0.0f;

    }
}
