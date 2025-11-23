namespace TurismoApp.Aplication.Services
{
    public interface IHotelesService
    {
        Task<List<Hotel>> GetHoteles();
        Task<Hotel> GetHotelById(int id);
    }
}