var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.XRPTZ_BasicSetup_Web>("web");

builder.Build().Run();
