var builder = DistributedApplication.CreateBuilder(args);

builder.AddKubernetesEnvironment("k8s");

var cache = builder.AddRedis("cache");

var apiService = builder.AddProject<Projects.XPRTZ_Publish_Kubernetes_ApiService>("apiservice")
    .WithHttpHealthCheck("/health");

builder.AddProject<Projects.XPRTZ_Publish_Kubernetes_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithHttpHealthCheck("/health")
    .WithReference(cache)
    .WaitFor(cache)
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
