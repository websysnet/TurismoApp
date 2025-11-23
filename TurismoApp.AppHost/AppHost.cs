var builder = DistributedApplication.CreateBuilder(args);

// Servicio API principal
var apiService = builder.AddProject<Projects.TurismoApp_ApiService>("apiservice")
    .WithHttpHealthCheck("/health");


// Servicio API secundaria (IA)
var iaService = builder.AddProject<Projects.APIServiceIA>("apiserviceia")
    .WithExternalHttpEndpoints()
    .WithHttpHealthCheck("/health")
    .WithReference(apiService);

// Servicio Web frontend
builder.AddProject<Projects.TurismoApp_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithHttpHealthCheck("/health")    
    .WithReference(apiService)
    .WithReference(iaService)
    .WaitFor(apiService)
    .WaitFor(iaService);

builder.Build().Run();
