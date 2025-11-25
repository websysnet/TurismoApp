using TurismoApp.ApiServiceIA.Controller;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

// Register HttpClient to call the main ApiService
builder.Services.AddHttpClient("ApiService", client =>
{
    var baseUrl = builder.Configuration["ApiService:BaseUrl"] ?? "http://localhost:5448";
    client.BaseAddress = new Uri(baseUrl);
});

builder.Services.AddScoped<BusquedasController>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapGet("/health", () => Results.Ok("API Service IA is healthy")).WithDisplayName("Health Check");
app.MapGet("/", () => "Welcome to the TurismoApp API Service IA!").WithDisplayName("Home");

app.MapGet("/HotelMasBarato/{destino}", async (BusquedasController busqueda, string destino) =>
{
    // Lógica para obtener el hotel más barato en el destino proporcionado
    var result = await busqueda.ObtenerHotelMasBaratoAsync(destino);
    return Results.Ok(result);

}).WithDisplayName("GetHotelMasBarato");


app.Run();

