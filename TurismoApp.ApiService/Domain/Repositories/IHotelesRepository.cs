namespace TurismoApp.Domain.Repositories
{
    using TurismoApp.Domain.Entities;
    public interface IHotelesRepository
    {
        Task<List<Hotel>> GetHoteles();
        Task<Hotel> GetHotelById(int id);
    }
}