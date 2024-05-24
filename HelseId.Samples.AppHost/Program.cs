var builder = DistributedApplication.CreateBuilder(args);

var sampleApi = builder.AddProject<Projects.HelseId_Samples_SampleApi>("SampleApi");
builder.AddProject<Projects.HelseId_Samples_ClientCredentials>("ClientCredentials")
    .WithReference(sampleApi);

builder.Build().Run();
