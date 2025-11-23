namespace TurismoApp.Aplication.Services
{
    using TurismoApp.Domain.Entities;
   
    public interface ITrasladosService
    {
        Task<List<Traslado>> GetTrasladosAsync();

        Task<Traslado> GetTrasladoByIdAsync(int id);
    }
    
}