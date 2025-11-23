namespace TurismoApp.ApiService.Controllers
{
    using TurismoApp.Domain.Entities;
    using TurismoApp.Domain.Repositories;
    using TurismoApp.Aplication.Services;
   

    public class HotelesController
    {
        private readonly IHotelesService _hotelesService;
        
        public HotelesController(IHotelesService hotelesService)
        {
            _hotelesService = hotelesService;
        }
        public Task<List<Hotel>> GetHoteles()
        {
            return _hotelesService.GetHoteles();
        }
        public Task<Hotel> GetHotelById(int id)
        {
            return _hotelesService.GetHotelById(id);
        }
    }
}