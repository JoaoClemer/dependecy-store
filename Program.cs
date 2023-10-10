using DependencyStore;
using DependencyStore.Extensions;
using DependencyStore.Repositories;
using DependencyStore.Repositories.Contract;
using DependencyStore.Services;
using DependencyStore.Services.Contracts;
using Microsoft.Data.SqlClient;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<Configuration>();
builder.Services.AddSqlConnection("CONN_STR");
builder.Services.AddExternalServices();
builder.Services.AddRepositories();



builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();