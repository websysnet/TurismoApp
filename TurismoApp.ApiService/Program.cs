using TurismoApp.Infraestructure.Repositories;
using TurismoApp.Aplication.Services;
using TurismoApp.Controllers;
using TurismoApp.Domain.Repositories;
using TurismoApp.Infraestructure;
using TurismoApp.ApiService.Controllers;


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

builder.Services.AddScoped<IHotelesRepository, HotelesRepository>();
builder.Services.AddScoped<IHotelesService, HotelesService>();
builder.Services.AddScoped<HotelesController>();

builder.Services.AddScoped<ITrasladosRepository, TrasladosRepository>();
builder.Services.AddScoped<ITrasladosService, TrasladosService>();
builder.Services.AddScoped<TrasladosController>();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseExceptionHandler();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}



//health check endpoint
app.MapGet("/health", () => Results.Ok("API is healthy")).WithDisplayName("HealthCheck");


//Controlador de Vuelos
app.MapGet("/vuelos", (VuelosController vuelosController) => vuelosController.GetVuelos()).WithDisplayName("GetVuelos");

// Obtener detalles de un vuelo por ID
app.MapGet("/vuelos/{id}", (VuelosController vuelosController,int id) => {
    return vuelosController.GetVueloById(id);
}).WithDisplayName("GetVueloById");

//Controlador de Hoteles
app.MapGet("/hoteles", (HotelesController hotelesController) => hotelesController.GetHoteles()).WithDisplayName("GetHoteles");

// Obtener detalles de un hotel por ID
app.MapGet("/hoteles/{id}", (HotelesController hotelesController, int id) =>
{
    return hotelesController.GetHotelById(id);
    
}).WithDisplayName("GetHotelById");



//Controlador de Traslados
// Obtener lista de traslados
app.MapGet("/traslados", (TrasladosController trasladosController) =>
{
  var traslados =  trasladosController.GetTrasladosAsync();
  return traslados;

}).WithDisplayName("GetTraslados");


// Obtener detalles de un traslado por ID
app.MapGet("/traslados/{id}", (TrasladosController trasladosController, int id) =>
{
    var traslado = trasladosController.GetTrasladoById(id);
    return traslado;
}).WithDisplayName("GetTrasladoById");


//Controlador de Excursiones
// Obtener lista de excursiones

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

app.Run();





app.MapDefaultEndpoints();

app.Run();





internal class Excursiones
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
}

internal class Traslados
{
    public int Id { get; set; }
    public string? Tipo { get; set; }
    public string? Origen { get; set; }
    public string? Destino { get; set; }
    public decimal Price { get; set; }
}



