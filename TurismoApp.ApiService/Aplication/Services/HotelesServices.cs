namespace TurismoApp.Aplication.Services
{
    using TurismoApp.Domain.Entities;
    using TurismoApp.Domain.Repositories;
    using TurismoApp.Infraestructure.Repositories;
    public class HotelesServices : IHotelesService
    {
        private readonly IHotelesRepository _hotelesRepository;
        public HotelesServices(IHotelesRepository hotelesRepository)
        {
            _hotelesRepository = hotelesRepository;
        }
        public Task<List<Hotel>> GetHoteles() => _hotelesRepository.GetHoteles();
        public Task<Hotel> GetHotelById(int id) => _hotelesRepository.GetHotelById(id);
    }
}