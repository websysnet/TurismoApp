namespace TurismoApp.Domain.Entities
{
    public class Habitacion
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public Cama Tipo { get; set; }
        public string? Imagen { get; set; }
        public int Adultos { get; set; }
        public int Ninos { get; set; }      
        public string? Politica { get; set; }
        public Tarifa? Tarifas { get; set; }
        public List<Servicios> Servicios { get; set; }
    }

    public enum Cama
    {
        Individual,
        Doble,
        Matrimonial,
        Suite
    }
}
