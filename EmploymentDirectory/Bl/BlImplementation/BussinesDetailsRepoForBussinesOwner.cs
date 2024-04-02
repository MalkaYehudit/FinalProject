using Bl.BlApi;
using Bl.BlObjects;
using Dal;
using Dal.DalImplementation;
using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.BlImplementation;

public class BussinesDetailsRepoForBussinesOwner : IBussinesDetailsRepoForBusinessOwner
{
    //Account account;
    AddressesRepo addressesRepo;
    BussinesDetailsRepo bussinesDetailsRepo;
    //Profession profession;
    public BussinesDetailsRepoForBussinesOwner(DalManager dalManager)
    {
        //this.account = dalManager.account;
        this.addressesRepo = dalManager.addresses;
        this.bussinesDetailsRepo = dalManager.bussinesDetails;
        //this.profession = dalManager.profession;
    }
    public List<BussinesDetailsForBusinessOwner> GetAllBussinesDetailsForBusinessOwners()
    {
        List<BussinesDetail> bussinesDetailsList = bussinesDetailsRepo.GetAllBussinesDetails();
        List<BussinesDetailsForBusinessOwner> bussinesDetailsForBusinessOwners = new List<BussinesDetailsForBusinessOwner>();
        for(int i = 0; i < bussinesDetailsList.Count; i++)
        {
            bussinesDetailsForBusinessOwners.Add(new BussinesDetailsForBusinessOwner()
            {
                Id = bussinesDetailsList[i].Id,
                FirstName = bussinesDetailsList[i].FirstName,
                LastName = bussinesDetailsList[i].LastName,
                ProfessionId = bussinesDetailsList[i].ProfessionId,
                BussinesName = bussinesDetailsList[i].BussinesName,
                Experience = bussinesDetailsList[i].Experience,
                PriceRange = bussinesDetailsList[i].PriceRange,
                AddressId = bussinesDetailsList[i].AddressId,
                AccountId = bussinesDetailsList[i].AccountId
            });
        }
        return bussinesDetailsForBusinessOwners;
    }

    public BussinesDetailsForBusinessOwner GetBussinesDetailsForBusinessOwnerById(int id)
    {
        BussinesDetail details = bussinesDetailsRepo.GetBussinesDetailsById(id);
        return new BussinesDetailsForBusinessOwner()
        {
            Id = details.Id,
            FirstName = details.FirstName,
            LastName = details.LastName,
            ProfessionId = details.ProfessionId,
            BussinesName = details.BussinesName,
            Experience = details.Experience,
            PriceRange = details.PriceRange,
            AddressId = details.AddressId,
            AccountId = details.AccountId
        };
    }

    public BussinesDetailsForBusinessOwner AddBussinesDetailsForBusinessOwners(BussinesDetailsForBusinessOwner bussinesDetailsForBusinessOwner)
    {
        return new BussinesDetailsForBusinessOwner()
        {
            Id = bussinesDetailsForBusinessOwner.Id,
            FirstName = bussinesDetailsForBusinessOwner.FirstName,
            LastName = bussinesDetailsForBusinessOwner.LastName,
            ProfessionId = bussinesDetailsForBusinessOwner.ProfessionId,
            BussinesName = bussinesDetailsForBusinessOwner.BussinesName,
            Experience = bussinesDetailsForBusinessOwner.Experience,
            PriceRange = bussinesDetailsForBusinessOwner.PriceRange,
            AddressId = bussinesDetailsForBusinessOwner.AddressId,
            AccountId = bussinesDetailsForBusinessOwner.AccountId
        };
    }
}
