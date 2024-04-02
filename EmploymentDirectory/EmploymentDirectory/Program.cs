using Bl;
using Dal.DalApi;
using Dal.DalImplementation;
using Dal.Models;
using DataAccess;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddScoped<BlManager>();

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();
