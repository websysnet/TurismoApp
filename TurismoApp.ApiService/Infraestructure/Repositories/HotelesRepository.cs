namespace TurismoApp.Infraestructure.Repositories
{
    class HotelesRepository: IHotelesRepository
    {
        private static readonly List<Hotel> _hoteles = new List<Hotel>
        {
            new Hotel { Id = 1, Nombre = "Hotel A", Descripcion = "Descripción del hotel A", Ubicacion = "Ubicación del hotel A", Image = "imagen_a.jpg", Rating = 4, PrecioPorNoche = 100, Habitaciones = new List<Habitacion> { new Habitacion { Id = 1, Nombre = "Habitación A", Descripcion = "Descripción de la habitación A", Tipo = Cama.Doble, Imagen = "imagen_habitacion_a.jpg", Adultos = 2, Ninos = 1, Politica = "Política de la habitación A", Tarifas = new Tarifa { Venta = 100, Impuesto = 10, GastosAdm = 5, Iva = 21, Total = 117 } } } },
            new Hotel { Id = 2, Nombre = "Hotel B", Descripcion = "Descripción del hotel B", Ubicacion = "Ubicación del hotel B", Image = "imagen_b.jpg", Rating = 5, PrecioPorNoche = 200, Habitaciones = new List<Habitacion> { new Habitacion { Id = 2, Nombre = "Habitación B", Descripcion = "Descripción de la habitación B", Tipo = Cama.Suite, Imagen = "imagen_habitacion_b.jpg", Adultos = 4, Ninos = 2, Politica = "Política de la habitación B", Tarifas = new Tarifa { Venta = 200, Impuesto = 20, GastosAdm = 10, Iva = 21, Total = 252 } } } },
            new Hotel { Id = 3, Nombre = "Hotel C", Descripcion = "Descripción del hotel C", Ubicacion = "Ubicación del hotel C", Image = "imagen_c.jpg", Rating = 3, PrecioPorNoche = 150, Habitaciones = new List<Habitacion> { new Habitacion { Id = 3, Nombre = "Habitación C", Descripcion = "Descripción de la habitación C", Tipo = Cama.Matrimonial, Imagen = "imagen_habitacion_c.jpg", Adultos = 2, Ninos = 0, Politica = "Política de la habitación C", Tarifas = new Tarifa { Venta = 150, Impuesto = 15, GastosAdm = 7, Iva = 21, Total = 182 } } } },
            new Hotel { Id = 4, Nombre = "Hotel D", Descripcion = "Descripción del hotel D", Ubicacion = "Ubicación del hotel D", Image = "imagen_d.jpg", Rating = 4, PrecioPorNoche = 120, Habitaciones = new List<Habitacion> { new Habitacion { Id = 4, Nombre = "Habitación D", Descripcion = "Descripción de la habitación D", Tipo = Cama.Doble, Imagen = "imagen_habitacion_d.jpg", Adultos = 2, Ninos = 1, Politica = "Política de la habitación D", Tarifas = new Tarifa { Venta = 120, Impuesto = 12, GastosAdm = 6, Iva = 21, Total = 140 } } } },
            new Hotel { Id = 5, Nombre = "Hotel E", Descripcion = "Descripción del hotel E", Ubicacion = "Ubicación del hotel E", Image = "imagen_e.jpg", Rating = 5, PrecioPorNoche = 250, Habitaciones = new List<Habitacion> { new Habitacion { Id = 5, Nombre = "Habitación E", Descripcion = "Descripción de la habitación E", Tipo = Cama.Suite, Imagen = "imagen_habitacion_e.jpg", Adultos = 4, Ninos = 2, Politica = "Política de la habitación E", Tarifas = new Tarifa { Venta = 250, Impuesto = 25, GastosAdm = 12, Iva = 21, Total = 306 } } } }
        };
        
        public Task<List<Hotel>> GetHoteles() => Task.FromResult(_hoteles);
        public Task<Hotel> GetHotelById(int id) => Task.FromResult(_hoteles.FirstOrDefault(h => h.Id == id)!);
    }
    
}