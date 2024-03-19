using Bl.BlApi;
using Bl.BlObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Microsoft.Extensions.DependencyInjection;
using Bl.BlImplementation;

namespace Bl;

public class BlManager
{
    public BussinesDetailsRepoForClient BussinesDetailsRepoForClient { get;  }
    public BussinesDetailsRepoForBussinesOwner BussinesDetailsRepoForBussinesOwner { get; }

    public BlManager() {
        ServiceCollection services = new();
        services.AddScoped<DalManager>();
        services.AddScoped<BussinesDetailsRepoForClient>();
        services.AddScoped<BussinesDetailsRepoForBussinesOwner>();

        ServiceProvider servicesProvider = services.BuildServiceProvider();

        //BussinesDetailsRepoForClient = servicesProvider.GetService<BussinesDetailsRepoForClient>();
        BussinesDetailsRepoForBussinesOwner = servicesProvider.GetService<BussinesDetailsRepoForBussinesOwner>();
    
    }

    
}
