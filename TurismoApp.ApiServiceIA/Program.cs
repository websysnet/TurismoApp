var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapGet("/health", () => Results.Ok("API Service IA is healthy")).WithDisplayName("Health Check");
app.MapGet("/", () => "Welcome to the TurismoApp API Service IA!").WithDisplayName("Home");


app.Run();

