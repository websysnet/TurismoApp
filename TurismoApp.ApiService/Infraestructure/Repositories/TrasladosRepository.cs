namespace TurismoApp.Infraestructure.Repositories
{
    using TurismoApp.Domain.Entities;
    using TurismoApp.Domain.Repositories;   
    public class TrasladosRepository:ITrasladosRepository
    {
        private readonly List<Traslado> _traslados = [
            new Traslado { Id = 1, Tipo = "Aeropuerto", Origen = "Aeropuerto Internacional", Destino = "Hotel Central", tarifa = new TarifaTraslado { Id = 1, Monto = 50.0m, impuesto= 12.00m } },
            new Traslado { Id = 2, Tipo = "Hotel", Origen = "Hotel Central", Destino = "Sitio Turístico", tarifa = new TarifaTraslado { Id = 2, Monto = 30.0m, impuesto= 7.20m } },
            new Traslado { Id = 3, Tipo = "Ciudad", Origen = "Centro de la Ciudad", Destino = "Museo Histórico", tarifa = new TarifaTraslado { Id = 3, Monto = 20.0m, impuesto= 4.80m } },
            new Traslado { Id = 4, Tipo = "Aeropuerto", Origen = "Hotel Central", Destino = "Aeropuerto Internacional", tarifa = new TarifaTraslado { Id = 4, Monto = 50.0m, impuesto= 12.00m } }
        ];
        public Task<List<Traslado>> GetTrasladosAsync()
        {
            return Task.FromResult(_traslados);
        }

        public Task<Traslado> GetTrasladoByIdAsync(int id)
        {
            return Task.FromResult(_traslados.FirstOrDefault(t => t.Id == id)!);
        }
    }
    
}