using Dal.DalApi;
using Dal.DalImplementation;
using Dal.Models;
using DataAccess;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

DBActions actions = new DBActions(builder.Configuration);
var connString = actions.GetConnectionString("EmploymentDirectoryDB");
builder.Services.AddDbContext<LibraryContext>(opt => opt.UseSqlServer(connString));

builder.Services.AddScoped<IAddressesRepo, AddressesRepo>();
builder.Services.AddScoped<IBussinesDetailsRepo, BussinesDetailsRepo>();

var app = builder.Build();

app.MapControllers();

app.Run();
