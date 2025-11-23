namespace TurismoApp.Controllers
{
    using TurismoApp.Domain.Entities;
    using TurismoApp.Aplication.Services;

    public class TrasladosController
    {
        private readonly ITrasladosService _trasladosService;

        public TrasladosController(ITrasladosService trasladosService)
        {
            _trasladosService = trasladosService;
        }

        public async Task<List<Traslado>> GetTrasladosAsync()
        {
            return await _trasladosService.GetTrasladosAsync();
        }

        public async Task<Traslado> GetTrasladoById(int id)
        {
            return await _trasladosService.GetTrasladoByIdAsync(id);
        }
    }
    
}