namespace TurismoApp.Aplication.Services
{
    using TurismoApp.Domain.Interfaces;
    using TurismoApp.Domain.Entities;
    public class VuelosService:IVuelosServices
    {
        private readonly IVuelosRepository _vuelosRepository;

        public VuelosService(IVuelosRepository vuelosRepository)
        {
            _vuelosRepository = vuelosRepository;
        }

        public List<Vuelo> GetVuelos()
        {
            return _vuelosRepository.GetVuelos();
        }

        public Vuelo GetVueloById(int id)
        {
            return _vuelosRepository.GetVueloById(id);
        }
    }
}
