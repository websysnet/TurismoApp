namespace TurismoApp.Domain.Entities
{
    public class Servicios
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public TipoServicio TipoServicio { get; set; } =TipoServicio.ServicioDeHabitacion;
        public string Imagen { get; set; }= string.Empty;
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