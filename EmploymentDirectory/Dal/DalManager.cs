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
    //public Profession profession { get; }
    //public Account account { get; }

    

    public DalManager(object constr) 
    { 
        ServiceCollection services = new();
        services.AddScoped<LibraryContext>();
        services.AddScoped<IAddressesRepo, AddressesRepo>();
        services.AddScoped<IBussinesDetailsRepo, BussinesDetailsRepo>();
        //services.AddScoped<Profession>();
        //services.AddScoped<Account>();

        ServiceProvider serviceProvider = services.BuildServiceProvider();

        addresses = (AddressesRepo)serviceProvider.GetRequiredService<IAddressesRepo>();
        bussinesDetails = (BussinesDetailsRepo)serviceProvider.GetRequiredService<IBussinesDetailsRepo>();
        //profession = serviceProvider.GetRequiredService<Profession>();
        //account = serviceProvider.GetRequiredService<Account>();

    }
}
