namespace TurismoApp.Aplication.Services
{
    using TurismoApp.Domain.Entities;
    public interface IHotelesService
    {
        Task<List<Hotel>> GetHoteles();
        Task<Hotel> GetHotelById(int id);
    }
}