
using AutoMapper;
using BiblioDataInfo.Config;
using BiblioDataInfo.Context;
using BiblioDataInfo.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using BiblioDataInfo.Context;
using BiblioDataInfo.IRepository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddDbContext<AplicacaoContext>(options => options.UseSqlServer());
builder.Services.AddControllers();
builder.Services.AddMvc();

builder.Services.AddAutoMapper(typeof(LivroProfile));
builder.Services.AddAutoMapper(typeof(UsuarioProfile));
builder.Services.AddAutoMapper(typeof(InstitutoEnsinoProfile));
builder.Services.AddAutoMapper(typeof(EmprestimoProfile));
builder.Services.AddAutoMapper(typeof(ItensEmprestimoProfile));

builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<ILivroRepository, LivroRepository>();
builder.Services.AddScoped<IEmprestimoRepository, EmprestimoRepository>();



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
