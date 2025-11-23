

using TurismoApp.Domain.Entities;
using TurismoApp.Domain.Repositories;
using TurismoApp.Infraestructure.Repositories;
using TurismoApp.Aplication.Services;
using TurismoApp.Controllers;


var builder = WebApplication.CreateBuilder(args);

// Add service defaults & Aspire client integrations.
builder.AddServiceDefaults();


// Add services to the container.
builder.Services.AddProblemDetails();

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddScoped<IVuelosRepository, VuelosRepository>();
builder.Services.AddScoped<IVuelosServices, VuelosService>();
builder.Services.AddScoped<VuelosController>();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseExceptionHandler();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}




//Controlador de Vuelos
app.MapGet("/vuelos", (VuelosController vuelosController) => vuelosController.GetVuelos()).WithDisplayName("GetVuelos");

// Obtener detalles de un vuelo por ID
app.MapGet("/vuelos/{id}", (int id) => {
    return $"Detalles del vuelo {id}: Origen - Ciudad A, Destino - Ciudad B, Hora de salida - 10:00 AM";
}).WithDisplayName("GetVueloById");

//Controlador de Hoteles
app.MapGet("/hoteles", (HotelesController hotelesController) => hotelesController.GetHoteles()).WithDisplayName("GetHoteles");

// Obtener detalles de un hotel por ID
app.MapGet("/hoteles/{id}", (int id) =>
{
    var hotel = new Hoteles { Id = id, Name = $"Hotel {id}", Description = "Descripci n del hotel", Location = "Ubicaci n del hotel" };
    return hotel;
}).WithDisplayName("GetHotelById");

app.MapGet("/excursiones", () =>
{
    // Simulamos una lista de excursiones
    List<Excursiones> excursiones = new List<Excursiones>
    {
        new() { Id = 1, Name = "Excursi n a la Monta a", Description = "Una emocionante excursi n a las monta as cercanas", Price = 49.99M },
        new() { Id = 2, Name = "Tour por la Ciudad", Description = "Un recorrido guiado por los principales puntos tur sticos de la ciudad", Price = 29.99M },
        new() { Id = 3, Name = "Visita al Museo", Description = "Una visita educativa al museo local", Price = 19.99M }
    };
    return excursiones;
}).WithDisplayName("GetExcursiones");

// Obtener detalles de una excursi n por ID 
app.MapGet("/excursiones/{id}", (int id) =>
{
    var excursion = new Excursiones { Id = id, Name = $"Excursi n {id}", Description = "Descripci n de la excursi n", Price = 39.99M };
    return excursion;
}).WithDisplayName("GetExcursionById");


//Controlador de Traslados
app.MapGet("/traslados", () =>
{
    // Simulamos una lista de traslados
    List<Traslados> traslados = new List<Traslados>
    {
        new() { Id = 1, Tipo = "Aeropuerto", Origen = "Aeropuerto Internacional", Destino = "Hotel Central", Price = 25.00M },
        new() { Id = 2, Tipo = "Ciudad", Origen = "Hotel Central", Destino = "Centro Comercial", Price = 15.00M },
        new() { Id = 3, Tipo = "Evento", Origen = "Hotel Central", Destino = "Centro de Convenciones", Price = 30.00M }
    };
    return traslados;
}).WithDisplayName("GetTraslados");

app.Run();





app.MapDefaultEndpoints();

app.Run();



internal class Hoteles
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Location { get; set; }

}


internal class Excursiones
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
}

internal class Traslados
{
    public int Id { get; set; }
    public string Tipo { get; set; }
    public string Origen { get; set; }
    public string Destino { get; set; }
    public decimal Price { get; set; }
}



