using Bl;
using Dal.DalApi;
using Dal.DalImplementation;
using Dal.Models;
using DataAccess;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddScoped<BlManager>();

builder.Services.AddControllers();

var provider = builder.Services.BuildServiceProvider();
var configuration = provider.GetRequiredService<IConfiguration>();

builder.Services.AddCors(options =>
{
    var frontend_url = configuration.GetValue<string>("FrontEnd_URL");
    options.AddDefaultPolicy(builder =>
    {
        builder.WithOrigins(frontend_url)
        .AllowAnyMethod().AllowAnyHeader();
    });
});

var app = builder.Build();

app.UseCors();

app.MapControllers();

app.Run();
