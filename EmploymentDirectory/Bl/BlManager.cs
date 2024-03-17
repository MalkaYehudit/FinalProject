using Bl.BlApi;
using Bl.BlObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Microsoft.Extensions.DependencyInjection;

namespace Bl;

public class BlManager
{
    public BusinessDetailsRepoForCliant BusinessDetailsForCliant { get;  }


    public BlManager(object constr) {
        ServiceCollection services = new();
        services.AddSingleton<DalManager>(d => new DalManager(constr));
        services.AddScoped<BusinessDetailsRepoForCliant>();

        ServiceProvider servicesProvider = services.BuildServiceProvider();

        BusinessDetailsForCliant = servicesProvider.GetService<BusinessDetailsRepoForCliant>();

    
    }

    
}
