using Bl.BlApi;
using Bl.BlObjects;
using Dal.DalImplementation;
using Dal.Models;
using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.BlImplementation;

public class BussinesDetailsRepoForClient : IBussinesDetailsRepoForClient
{
    AddressesRepo addressesRepo;
    BussinesDetailsRepo bussinesDetailsRepo;
    Profession profession;
    public BussinesDetailsRepoForClient(DalManager dalManager)
    {
        this.addressesRepo = dalManager.addresses;
        this.bussinesDetailsRepo = dalManager.bussinesDetails;
        //this.profession = dalManager.profession;
    }
    public List<BussinesDetailsForClient> GetAllBusinessDetailsForClients()
    {
        List<BussinesDetail> temp = bussinesDetailsRepo.GetAllBussinesDetails();
        List<BussinesDetailsForClient> bussinesDetailsForClients = new List<BussinesDetailsForClient>();
        for (int i = 0; i < temp.Count; i++)
        {
            bussinesDetailsForClients.Add(new BussinesDetailsForClient()
            {
                BussinesName = temp[i].BussinesName,
                FirstNameOfOwner = temp[i].FirstName,
                LastNameOfOwner = temp[i].LastName,
                Profession = temp[i].ProfessionId,
                PriceRange = temp[i].PriceRange,
                Experience = temp[i].Experience,
                City = temp[i].AddressId
            });
        }
        return bussinesDetailsForClients;
    }

    public BussinesDetailsForClient GetBussinesDetailsForClientsById(int id)
    {
        BussinesDetail details = bussinesDetailsRepo.GetBussinesDetailsById(id);
        return new BussinesDetailsForClient()
        {
            BussinesName = details.BussinesName,
            FirstNameOfOwner = details.FirstName,
            LastNameOfOwner = details.LastName,
            Profession = details.ProfessionId,
            PriceRange = details.PriceRange,
            City = details.AddressId
        };
    }
}
