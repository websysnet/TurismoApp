namespace TurismoApp.Aplication.Services
{
    using TurismoApp.Domain.Entities;
    using TurismoApp.Domain.Repositories;
    using TurismoApp.Infraestructure.Repositories;  
    public class HotelesService: IHotelesService
    {
        private readonly IHotelesRepository _hotelesRepository;
        public HotelesService(IHotelesRepository hotelesRepository)
        {
            _hotelesRepository = hotelesRepository;
        }
        public Task<List<Hotel>> GetHoteles()
        {
            return _hotelesRepository.GetHoteles();
        }

        public Task<Hotel> GetHotelById(int id)
        {
           return _hotelesRepository.GetHotelById(id);
        }
    }

    
  
}