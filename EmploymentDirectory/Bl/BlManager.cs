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
        services.AddScoped<IBussinesDetailsRepoForClient, BussinesDetailsRepoForClient>();
        services.AddScoped<IBussinesDetailsRepoForBusinessOwner, BussinesDetailsRepoForBussinesOwner>();

        ServiceProvider servicesProvider = services.BuildServiceProvider();

<<<<<<< HEAD
        //BussinesDetailsRepoForClient = servicesProvider.GetService<BussinesDetailsRepoForClient>();
        BussinesDetailsRepoForBussinesOwner = (BussinesDetailsRepoForBussinesOwner)servicesProvider.GetService<IBussinesDetailsRepoForBusinessOwner>();
=======
       BussinesDetailsRepoForClient = (BussinesDetailsRepoForClient)servicesProvider.GetService<IBussinesDetailsRepoForClient>();
        //BussinesDetailsRepoForBussinesOwner = (BussinesDetailsRepoForBussinesOwner)servicesProvider.GetService<IBussinesDetailsRepoForBussinesOwner>();
>>>>>>> 38949907b33994dee104747ad55c00f94ebaa763


    
    }

    
}
