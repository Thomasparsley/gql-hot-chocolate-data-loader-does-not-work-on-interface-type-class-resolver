
var builder = WebApplication.CreateBuilder(args);

builder.Services
       .AddSingleton<MemoryDatabase>();

builder.AddGraphQL().AddTypes();

var app = builder.Build();

app.MapGraphQL();

app.RunWithGraphQLCommands(args);