var builder = DistributedApplication.CreateBuilder(args);

builder.AddAzureContainerAppEnvironment("aspire-env");

var cache = builder.AddRedis("cache");

var apiService = builder.AddProject<Projects.XPRTZ_Publish_ContainerApps_ApiService>("apiservice")
    .WithHttpHealthCheck("/health");

builder.AddProject<Projects.XPRTZ_Publish_ContainerApps_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithHttpHealthCheck("/health")
    .WithReference(cache)
    .WaitFor(cache)
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
