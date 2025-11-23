namespace TurismoApp.ApiService.Controllers
{
    using TurismoApp.Domain.Entities;
   

    public class HotelesController
    {
        private readonly IVuelosRepository _vuelosRepository;
        
        public List<Hoteles> GetHoteles()
        {
            return new List<Hoteles>();
        }
    }
}