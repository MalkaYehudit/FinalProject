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
builder.Services.AddScoped<IProfessionalRepo, ProfessionalRepo>();
var app = builder.Build();

app.MapControllers();

app.Run();
