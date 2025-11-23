namespace TurismoApp.Domain.Repositories
{
    interface IHotelesRepository
    {
        Task<List<Hotel>> GetHoteles();
        Task<Hotel> GetHotelById(int id);
    }
}