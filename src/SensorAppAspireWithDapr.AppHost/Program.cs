using Aspire.Hosting.Dapr;

var builder = DistributedApplication.CreateBuilder(args);

var pubsubComponent = builder.AddDaprPubSub("pubsub");


var sensor = builder.AddProject<Projects.SensorService>("sensor")
    .WithDaprSidecar()
    .WithReference(pubsubComponent);

var alert = builder.AddProject<Projects.AlertService>("alert")
    .WithDaprSidecar()
    .WithReference(pubsubComponent);

builder.Build().Run();
