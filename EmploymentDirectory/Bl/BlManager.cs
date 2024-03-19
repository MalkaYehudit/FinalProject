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
    public BussinesDetailsForClient BussinesDetailsForClient { get;  }
    public BussinesDetailsForBusinessOwner BussinesDetailsForBusinessOwner { get; }

    public BlManager(object constr) {
        ServiceCollection services = new();
        services.AddSingleton<DalManager>(d => new DalManager(constr));
        services.AddScoped<BussinesDetailsForClient>();
        services.AddScoped<BussinesDetailsForBusinessOwner>();

        ServiceProvider servicesProvider = services.BuildServiceProvider();

        BussinesDetailsForClient = servicesProvider.GetService<BussinesDetailsForClient>();
        BussinesDetailsForBusinessOwner = servicesProvider.GetService<BussinesDetailsForBusinessOwner>();
    
    }

    
}
