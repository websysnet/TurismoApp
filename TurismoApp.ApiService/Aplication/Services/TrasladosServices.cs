namespace TurismoApp.Aplication.Services
{
    using TurismoApp.Domain.Entities;
    using TurismoApp.Domain.Repositories;
    using TurismoApp.Infraestructure.Repositories;

    public class TrasladosService : ITrasladosService
    {
        private readonly ITrasladosRepository _trasladosRepository;

        public TrasladosService(ITrasladosRepository trasladosRepository)
        {
            _trasladosRepository = trasladosRepository;
        }


        public async Task<List<Traslado>> GetTrasladosAsync()
        {
            return await _trasladosRepository.GetTrasladosAsync();
        }

        public async Task<Traslado> GetTrasladoByIdAsync(int id)
        {
            return await _trasladosRepository.GetTrasladoByIdAsync(id);
        }
    }
}