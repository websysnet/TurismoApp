namespace TurismoApp.Domain.Repositories
{
    using TurismoApp.Domain.Entities;
    public interface ITrasladosRepository
    {
        public Task<List<Traslado>> GetTrasladosAsync();

        public Task<Traslado> GetTrasladoByIdAsync(int id);
    }
}