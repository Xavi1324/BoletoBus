using BoletoBus.Viaje.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using BoletoBus.Vieaje.IOC.Dependencies;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<BoletosBusContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("BoletosBusContext")));



builder.Services.AddViajeDependency();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
