using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Configura o Ocelot
builder.Configuration.AddJsonFile("ocelot.json");
builder.Services.AddOcelot();

var app = builder.Build();

// CONFIGURAR ROTAS QUE O OCELOT IRA RECEBER
await app.UseOcelot();

app.Run();