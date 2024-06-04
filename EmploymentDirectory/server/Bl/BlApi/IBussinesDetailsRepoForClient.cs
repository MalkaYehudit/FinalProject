using Bl.BlObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.BlApi;

public interface IBussinesDetailsRepoForClient
{
    List<BussinesDetailsForClient> GetAllBusinessDetailsForClients();
    BussinesDetailsForClient GetBussinesDetailsForClientsById(int id);
    List<BussinesDetailsForClient> GetAllBussinesDetailsForClientByCityName(string cityName);
    List<BussinesDetailsForClient> GetAllBussinesDetailsForClientByProfession(string professionName);
    List<BussinesDetailsForClient> GetAllBussinesDetailsForClientByEmployersName(string employerName);
    List<BussinesDetailsForClient> GetAllBussinesDetailsForClientByExperience(int experience);


    //BusinessDetailsForCliant AddNewBussinesDetails(BusinessDetailsForCliant bussinesDetail);
    //BusinessDetailsForCliant UpdateBussinesDetails(int id,  BusinessDetailsForCliant bussinesDetail);
    //BusinessDetailsForCliant DeleteBussinesDetails(int id);
}
