using Bl.BlObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.BlApi;

public interface IBussinesDetailsRepoForBusinessOwner
{
    List<BussinesDetailsForBusinessOwner> GetAllBussinesDetailsForBusinessOwners();
    BussinesDetailsForBusinessOwner GetBussinesDetailsForBusinessOwnerById(int id);
    BussinesDetailsForBusinessOwner GetBussinesDetailsForBusinessOwnerByPassword(string password);
    BussinesDetailsForBusinessOwner AddBussinesDetailsForBusinessOwner(BussinesDetailsForBusinessOwner bussinesDetailsForBusinessOwner, string cityName, string professionName);
    BussinesDetailsForBusinessOwner UpdateBussinesDetailsForBusinessOwner(int id, BussinesDetailsForBusinessOwner bussinesDetailsForBusinessOwner, string cityName, string professionName);
    BussinesDetailsForBusinessOwner DeleteBussinesDetailsForBusinessOwner(int id);

}
