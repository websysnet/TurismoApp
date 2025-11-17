namespace TurismoApp.Controllers
{
    using TurismoApp.Aplication.Services;
    using TurismoApp.Domain.Entities;
    public class VuelosController
    {
        private readonly IVuelosServices? _vuelosService;

        public VuelosController(IVuelosServices vuelosService)
        {
            _vuelosService = vuelosService ?? throw new ArgumentNullException(nameof(vuelosService));
        }

        public List<Vuelo> GetVuelos()
        {
            
            List<Vuelo> vuelos = _vuelosService.GetVuelos();
            if (vuelos == null || vuelos.Count == 0)
            {
                throw new Exception("No se encontraron vuelos disponibles.");
            }
            return vuelos;
        }
        public Vuelo GetVueloById(int id)
        {
            Vuelo vuelo = _vuelosService.GetVueloById(id);
            if (vuelo == null)
            {
                throw new Exception($"No se encontró ningún vuelo con ID {id}.");
            }
            return vuelo;
        }

       

    }
}
