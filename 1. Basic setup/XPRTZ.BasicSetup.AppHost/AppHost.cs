var builder = DistributedApplication.CreateBuilder(args);

var azureSqlReference = builder
    .AddAzureSqlServer("azuresql")
    .RunAsContainer()
    .AddDatabase("BasicSetup");

builder
    .AddProject<Projects.XRPTZ_BasicSetup_Web>("web")
    .WithReference(azureSqlReference);

builder.Build().Run();
