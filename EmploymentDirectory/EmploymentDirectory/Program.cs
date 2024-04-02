using Bl;
using Dal.DalApi;
using Dal.DalImplementation;
using Dal.Models;
using DataAccess;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddScoped<BlManager>();

builder.Services.AddControllers();

//var provider = builder.Services.BuildServiceProvider();
//var configuration = provider.GetRequiredService<IConfiguration>();

//builder.Services.AddCors(options =>
//{
//    var frontend_url=...
//})

var app = builder.Build();

app.MapControllers();

app.Run();
