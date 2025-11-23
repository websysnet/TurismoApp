namespace TurismoApp.Domain.Entities
{
    public class Servicios
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public List<TipoServicio> TipoServicio { get; set; } = new List<TipoServicio>();
        public string Imagen { get; set; }
        public int Precio { get; set; }
    }

  
    public enum TipoServicio
    {
        Restaurante,
        Bar,
        Gimnasio,
        Spa,
        Jardín,
        Piscina,
        Paseos,
        Transporte,
        Eventos,
        Wifi,
        ServicioDeHabitacion,
        Otros
    }
}