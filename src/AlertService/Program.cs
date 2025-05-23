var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers().AddDapr();
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

app.UseCloudEvents();
app.MapControllers();
app.MapSubscribeHandler();

app.Run();