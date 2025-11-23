namespace TurismoApp.Domain.Entities
{
    public  class Traslado
    {
        public int Id { get; set; }
        public string? Tipo { get; set; }
        public string? Origen { get; set; }
        public string? Destino { get; set; }
        public TarifaTraslado? tarifa { get; set; }
    }

    public class TarifaTraslado
    {
        public int Id { get; set; }
        public decimal Monto { get; set; }

        public decimal impuesto { get; set; }

        public decimal Total => Monto + impuesto;
    }
    
}