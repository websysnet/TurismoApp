namespace TurismoApp.Domain.Repositories
{
    using TurismoApp.Domain.Entities;
    public interface IVuelosRepository
    {
        public List<Vuelo> GetVuelos();

        public Vuelo GetVueloById(int id);
    }
}
