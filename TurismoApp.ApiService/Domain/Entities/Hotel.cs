namespace TurismoApp.Domain.Entities
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Description { get; set; }
        public string Ubicacion { get; set; }
        public string Image { get; set; }
        public int Rating { get; set; }
        public int PrecioPorNoche { get; set; }
        public List<Habitacion> Habitaciones { get; set; } = new List<Habitacion>();

    }

}
