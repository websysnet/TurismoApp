namespace TurismoApp.Aplication.Services
{
    using TurismoApp.Domain.Entities; 
   

    public interface IVuelosServices    {
       
        public List<Vuelo> GetVuelos();
        public Vuelo GetVueloById(int id);
    }
}
