namespace TurismoApp.Infraestructure.Repositories
{
    using TurismoApp.Domain.Entities;
    using TurismoApp.Domain.Repositories;
    [Serializable]
    public class VuelosRepository:IVuelosRepository
    {
        
        private static readonly List<Vuelo> _vuelos = new List<Vuelo>
        {
            new Vuelo { Id = 1, Origen = "Buenos Aires", Destino = "Madrid", HoraSalida = DateTime.Now.AddHours(5), HoraLlegada = DateTime.Now.AddHours(15), Aerolinea = "Iberia", Precio = 750.0f },
            new Vuelo { Id = 2, Origen = "Buenos Aires", Destino = "New York", HoraSalida = DateTime.Now.AddHours(3), HoraLlegada = DateTime.Now.AddHours(12), Aerolinea = "American Airlines", Precio = 680.0f },
            new Vuelo { Id = 3, Origen = "Buenos Aires", Destino = "Paris", HoraSalida = DateTime.Now.AddHours(6), HoraLlegada = DateTime.Now.AddHours(16), Aerolinea = "Air France", Precio = 720.0f },
            new Vuelo { Id = 4, Origen = "Buenos Aires", Destino = "Tokyo", HoraSalida = DateTime.Now.AddHours(8), HoraLlegada = DateTime.Now.AddHours(22), Aerolinea = "Japan Airlines", Precio = 950.0f },
            new Vuelo { Id = 5, Origen = "Buenos Aires", Destino = "Sydney", HoraSalida = DateTime.Now.AddHours(10), HoraLlegada = DateTime.Now.AddHours(26), Aerolinea = "Qantas", Precio = 1100.0f }
        };

        public List<Vuelo> GetVuelos()=> _vuelos;

        public Vuelo GetVueloById(int id)=> _vuelos.FirstOrDefault(v => v.Id == id)!;








    }
}
