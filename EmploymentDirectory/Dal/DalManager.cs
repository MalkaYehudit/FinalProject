using Dal.DalApi;
using Dal.DalImplementation;
using Dal.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal;

public class DalManager
{
    public AddressesRepo addresses { get; }
    public BussinesDetailsRepo bussinesDetails { get; }
    public EmployersRepo employers { get; }

    public DalManager() 
    { 
        ServiceCollection services = new();
        services.AddScoped<LibraryContext>();
        services.AddScoped<IAddressesRepo, AddressesRepo>();
        services.AddScoped<IBussinesDetailsRepo, BussinesDetailsRepo>();
        services.AddScoped<IEmployersRepo, EmployersRepo>();

        ServiceProvider serviceProvider = services.BuildServiceProvider();

        addresses = serviceProvider.GetRequiredService<AddressesRepo>();
        bussinesDetails = serviceProvider.GetRequiredService<BussinesDetailsRepo>();
        employers = serviceProvider.GetRequiredService<EmployersRepo>();
    }
}
