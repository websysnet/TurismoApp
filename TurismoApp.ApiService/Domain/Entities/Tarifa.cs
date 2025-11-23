namespace TurismoApp.Domain.Entities
{
    public class Tarifa
    {
        public int Id { get; set; }
        public float Venta { get; set; }
        public float Impuesto { get; set; }
        public float GastosAdm { get; set; }
        public float Iva { get; set; }
        public float Total => Venta + Impuesto + GastosAdm + Iva;
    }
}