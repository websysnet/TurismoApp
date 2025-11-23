namespace TurismoApp.Infraestructure.Repositories
{
    using TurismoApp.Domain.Entities;
    using TurismoApp.Domain.Repositories;

    public class HotelesRepository : IHotelesRepository
    {
        private List<Hotel> _hoteles = new List<Hotel>
        {
            new Hotel
            {
                Id = 1,
                Nombre = "Hotel Playa Dorada",
                Description = "Frente al mar, desayuno incluido y piscina climatizada.",
                Ubicacion = "Málaga, España",
                Image = "playa_dorada.jpg",
                Rating = 5,
                PrecioPorNoche = 180,
                Habitaciones = new List<Habitacion>
                {
                    new Habitacion
                    {
                        Id = 1,
                        Nombre = "Doble Superior",
                        Descripcion = "Habitación con vista al mar y balcón.",
                        Tipo = Cama.Doble,
                        Imagen = "hab_doble_superior.jpg",
                        Adultos = 2,
                        Ninos = 1,
                        Politica = "Cancelación flexible hasta 48h antes.",
                        Tarifas = new Tarifa { Id = 1, Venta = 140, Impuesto = 10, GastosAdm = 5, Iva = 25 },
                        Servicios = new List<Servicios>
                        {
                            new Servicios { Id = 1, Nombre = "WiFi", Descripcion = "Internet ilimitado", TipoServicio = TipoServicio.Wifi, Imagen = "wifi.png", Precio = 0 },
                            new Servicios { Id = 2, Nombre = "Desayuno buffet", Descripcion = "Desayuno incluido", TipoServicio = TipoServicio.Restaurante, Imagen = "desayuno.png", Precio = 0 }
                        }
                    },
                    new Habitacion
                    {
                        Id = 2,
                        Nombre = "Suite Familiar",
                        Descripcion = "Amplia suite para familias con sala independiente.",
                        Tipo = Cama.Suite,
                        Imagen = "suite_familiar.jpg",
                        Adultos = 4,
                        Ninos = 2,
                        Politica = "Cancelación gratuita 7 días antes.",
                        Tarifas = new Tarifa { Id = 2, Venta = 320, Impuesto = 20, GastosAdm = 10, Iva = 40 },
                        Servicios = new List<Servicios>
                        {
                            new Servicios { Id = 3, Nombre = "Piscina", Descripcion = "Piscina exterior climatizada", TipoServicio = TipoServicio.Piscina, Imagen = "piscina.png", Precio = 0 },
                            new Servicios { Id = 4, Nombre = "Servicio de habitaciones", Descripcion = "24h", TipoServicio = TipoServicio.ServicioDeHabitacion, Imagen = "room_service.png", Precio = 15 }
                        }
                    }
                }
            },

            new Hotel
            {
                Id = 2,
                Nombre = "Montaña Verde Resort",
                Description = "Resort ecológico en plena sierra, ideal para senderismo.",
                Ubicacion = "Sierra Nevada, España",
                Image = "montana_verde.jpg",
                Rating = 4,
                PrecioPorNoche = 120,
                Habitaciones = new List<Habitacion>
                {
                    new Habitacion
                    {
                        Id = 3,
                        Nombre = "Individual Económica",
                        Descripcion = "Cama individual, baño privado.",
                        Tipo = Cama.Individual,
                        Imagen = "ind_economica.jpg",
                        Adultos = 1,
                        Ninos = 0,
                        Politica = "No reembolsable.",
                        Tarifas = new Tarifa { Id = 3, Venta = 70, Impuesto = 5, GastosAdm = 2, Iva = 13 },
                        Servicios = new List<Servicios>
                        {
                            new Servicios { Id = 5, Nombre = "Senderismo guiado", Descripcion = "Rutas incluidas", TipoServicio = TipoServicio.Paseos, Imagen = "senderismo.png", Precio = 0 }
                        }
                    },
                    new Habitacion
                    {
                        Id = 4,
                        Nombre = "Doble Estándar",
                        Descripcion = "Cama doble, vista a la montaña.",
                        Tipo = Cama.Doble,
                        Imagen = "doble_estandar.jpg",
                        Adultos = 2,
                        Ninos = 1,
                        Politica = "Cancelación 48h.",
                        Tarifas = new Tarifa { Id = 4, Venta = 100, Impuesto = 7, GastosAdm = 3, Iva = 10 },
                        Servicios = new List<Servicios>
                        {
                            new Servicios { Id = 6, Nombre = "Spa", Descripcion = "Acceso a spa", TipoServicio = TipoServicio.Spa, Imagen = "spa.png", Precio = 20 }
                        }
                    }
                }
            },

            new Hotel
            {
                Id = 3,
                Nombre = "City Central Hotel",
                Description = "Ubicado en el centro urbano, cercano a transporte y restaurantes.",
                Ubicacion = "Madrid, España",
                Image = "city_central.jpg",
                Rating = 4,
                PrecioPorNoche = 150,
                Habitaciones = new List<Habitacion>
                {
                    new Habitacion
                    {
                        Id = 5,
                        Nombre = "Doble Ejecutivo",
                        Descripcion = "Ideal para viajes de negocio.",
                        Tipo = Cama.Doble,
                        Imagen = "ejecutivo.jpg",
                        Adultos = 2,
                        Ninos = 0,
                        Politica = "Cancelación gratuita 24h.",
                        Tarifas = new Tarifa { Id = 5, Venta = 130, Impuesto = 8, GastosAdm = 4, Iva = 16 },
                        Servicios = new List<Servicios>
                        {
                            new Servicios { Id = 7, Nombre = "Gimnasio", Descripcion = "Acceso 24h", TipoServicio = TipoServicio.Gimnasio, Imagen = "gym.png", Precio = 0 },
                            new Servicios { Id = 8, Nombre = "WiFi", Descripcion = "Alta velocidad", TipoServicio = TipoServicio.Wifi, Imagen = "wifi.png", Precio = 0 }
                        }
                    }
                }
            },

            new Hotel
            {
                Id = 4,
                Nombre = "Lago Azul Hotel",
                Description = "Hotel tranquilo junto al lago con actividades acuáticas.",
                Ubicacion = "Lago Como, Italia",
                Image = "lago_azul.jpg",
                Rating = 5,
                PrecioPorNoche = 210,
                Habitaciones = new List<Habitacion>
                {
                    new Habitacion
                    {
                        Id = 6,
                        Nombre = "Suite Lago",
                        Descripcion = "Suite con terraza privada y vistas al lago.",
                        Tipo = Cama.Suite,
                        Imagen = "suite_lago.jpg",
                        Adultos = 2,
                        Ninos = 1,
                        Politica = "Cancelación gratuita 7 días antes.",
                        Tarifas = new Tarifa { Id = 6, Venta = 180, Impuesto = 12, GastosAdm = 6, Iva = 24 },
                        Servicios = new List<Servicios>
                        {
                            new Servicios { Id = 9, Nombre = "Paseos en bote", Descripcion = "Alquiler de botes", TipoServicio = TipoServicio.Paseos, Imagen = "bote.png", Precio = 30 }
                        }
                    }
                }
            },

            new Hotel
            {
                Id = 5,
                Nombre = "Boutique Las Flores",
                Description = "Pequeño hotel boutique con encanto y jardín privado.",
                Ubicacion = "Sevilla, España",
                Image = "boutique_flores.jpg",
                Rating = 4,
                PrecioPorNoche = 110,
                Habitaciones = new List<Habitacion>
                {
                    new Habitacion
                    {
                        Id = 7,
                        Nombre = "Matrimonial Romántica",
                        Descripcion = "Decoración íntima, ideal para parejas.",
                        Tipo = Cama.Matrimonial,
                        Imagen = "matrimonial.jpg",
                        Adultos = 2,
                        Ninos = 0,
                        Politica = "Cancelación 48h.",
                        Tarifas = new Tarifa { Id = 7, Venta = 95, Impuesto = 6, GastosAdm = 3, Iva = 6 },
                        Servicios = new List<Servicios>
                        {
                            new Servicios { Id = 10, Nombre = "Jardín", Descripcion = "Acceso a zona ajardinada", TipoServicio = TipoServicio.Jardín, Imagen = "jardin.png", Precio = 0 }
                        }
                    }
                }
            },

            new Hotel
            {
                Id = 6,
                Nombre = "Airport Stop Inn",
                Description = "Cercano al aeropuerto, servicio de traslado disponible.",
                Ubicacion = "Barcelona, España",
                Image = "airport_inn.jpg",
                Rating = 3,
                PrecioPorNoche = 75,
                Habitaciones = new List<Habitacion>
                {
                    new Habitacion
                    {
                        Id = 8,
                        Nombre = "Doble Económica",
                        Descripcion = "Habitación funcional para estancias cortas.",
                        Tipo = Cama.Doble,
                        Imagen = "doble_economica.jpg",
                        Adultos = 2,
                        Ninos = 0,
                        Politica = "Cancelación gratuita 24h.",
                        Tarifas = new Tarifa { Id = 8, Venta = 60, Impuesto = 4, GastosAdm = 2, Iva = 9 },
                        Servicios = new List<Servicios>
                        {
                            new Servicios { Id = 11, Nombre = "Transporte", Descripcion = "Shuttle al aeropuerto", TipoServicio = TipoServicio.Transporte, Imagen = "shuttle.png", Precio = 10 }
                        }
                    }
                }
            },

            new Hotel
            {
                Id = 7,
                Nombre = "Plaza Heritage Hotel",
                Description = "Hotel histórico con restaurante gourmet.",
                Ubicacion = "Granada, España",
                Image = "plaza_heritage.jpg",
                Rating = 5,
                PrecioPorNoche = 200,
                Habitaciones = new List<Habitacion>
                {
                    new Habitacion
                    {
                        Id = 9,
                        Nombre = "Junior Suite",
                        Descripcion = "Combinación de lujo y patrimonio.",
                        Tipo = Cama.Suite,
                        Imagen = "junior_suite.jpg",
                        Adultos = 2,
                        Ninos = 1,
                        Politica = "Cancelación gratuita 5 días antes.",
                        Tarifas = new Tarifa { Id = 9, Venta = 170, Impuesto = 11, GastosAdm = 6, Iva = 13 },
                        Servicios = new List<Servicios>
                        {
                            new Servicios { Id = 12, Nombre = "Restaurante gourmet", Descripcion = "Cocina local de autor", TipoServicio = TipoServicio.Restaurante, Imagen = "resto.png", Precio = 0 }
                        }
                    }
                }
            },

            new Hotel
            {
                Id = 8,
                Nombre = "Desert Oasis",
                Description = "Retiro en el desierto con experiencias culturales.",
                Ubicacion = "Marrakech, Marruecos",
                Image = "desert_oasis.jpg",
                Rating = 4,
                PrecioPorNoche = 140,
                Habitaciones = new List<Habitacion>
                {
                    new Habitacion
                    {
                        Id = 10,
                        Nombre = "Suite Tradicional",
                        Descripcion = "Decoración autóctona y patio interior.",
                        Tipo = Cama.Matrimonial,
                        Imagen = "suite_tradicional.jpg",
                        Adultos = 2,
                        Ninos = 1,
                        Politica = "Cancelación 72h.",
                        Tarifas = new Tarifa { Id = 10, Venta = 110, Impuesto = 8, GastosAdm = 4, Iva = 18 },
                        Servicios = new List<Servicios>
                        {
                            new Servicios { Id = 13, Nombre = "Eventos culturales", Descripcion = "Espectáculos y visitas guiadas", TipoServicio = TipoServicio.Eventos, Imagen = "eventos.png", Precio = 20 }
                        }
                    }
                }
            },

            new Hotel
            {
                Id = 9,
                Nombre = "Eco Surf Camp",
                Description = "Campamento de surf sostenible junto a la playa.",
                Ubicacion = "Lisboa, Portugal",
                Image = "eco_surf.jpg",
                Rating = 3,
                PrecioPorNoche = 65,
                Habitaciones = new List<Habitacion>
                {
                    new Habitacion
                    {
                        Id = 11,
                        Nombre = "Dormitorio Compartido",
                        Descripcion = "Camas en habitación compartida, ideal para grupos.",
                        Tipo = Cama.Individual,
                        Imagen = "dorm_compartido.jpg",
                        Adultos = 1,
                        Ninos = 0,
                        Politica = "No reembolsable.",
                        Tarifas = new Tarifa { Id = 11, Venta = 50, Impuesto = 3, GastosAdm = 1, Iva = 11 },
                        Servicios = new List<Servicios>
                        {
                            new Servicios { Id = 14, Nombre = "Clases de surf", Descripcion = "Instructores certificados", TipoServicio = TipoServicio.Paseos, Imagen = "surf.png", Precio = 25 }
                        }
                    }
                }
            },

            new Hotel
            {
                Id = 10,
                Nombre = "Comfort Business Hotel",
                Description = "Alojamiento práctico para viajeros de negocios.",
                Ubicacion = "Valencia, España",
                Image = "comfort_business.jpg",
                Rating = 4,
                PrecioPorNoche = 95,
                Habitaciones = new List<Habitacion>
                {
                    new Habitacion
                    {
                        Id = 12,
                        Nombre = "Individual Business",
                        Descripcion = "Espacio de trabajo y escritorio grande.",
                        Tipo = Cama.Individual,
                        Imagen = "ind_business.jpg",
                        Adultos = 1,
                        Ninos = 0,
                        Politica = "Cancelación 24h.",
                        Tarifas = new Tarifa { Id = 12, Venta = 80, Impuesto = 5, GastosAdm = 2, Iva = 8 },
                        Servicios = new List<Servicios>
                        {
                            new Servicios { Id = 15, Nombre = "Centro de negocios", Descripcion = "Salas de reunión", TipoServicio = TipoServicio.Otros, Imagen = "business.png", Precio = 30 },
                            new Servicios { Id = 16, Nombre = "WiFi", Descripcion = "Conexión estable", TipoServicio = TipoServicio.Wifi, Imagen = "wifi.png", Precio = 0 }
                        }
                    }
                }
            }
        };    
        public Task<List<Hotel>> GetHoteles() => Task.FromResult(_hoteles);
        public Task<Hotel> GetHotelById(int id) => Task.FromResult(_hoteles.FirstOrDefault(h => h.Id == id)!);
    }
    
}