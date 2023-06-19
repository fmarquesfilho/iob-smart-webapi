using Microsoft.EntityFrameworkCore;
using iob_smart_webapi.Models;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddControllers();
// add db context for each endpoint of out API
builder.Services.AddDbContext<NotaContext>(opt =>
    opt.UseInMemoryDatabase("Notas"));
builder.Services.AddDbContext<ContratacaoContext>(opt =>
    opt.UseInMemoryDatabase("Contratacoes"));
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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
