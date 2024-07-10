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
    //AddressesRepo addressesRepo;
    BussinesDetailsRepo bussinesDetailsRepo;
    //Profession profession;
    public BussinesDetailsRepoForBussinesOwner(DalManager dalManager)
    {
        //this.account = dalManager.account;
        //this.addressesRepo = dalManager.addresses;
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
        BussinesDetail getdetails = bussinesDetailsRepo.GetBussinesDetailsById(id);
        return new BussinesDetailsForBusinessOwner()
        {
            Id = getdetails.Id,
            FirstName = getdetails.FirstName,
            LastName = getdetails.LastName,
            ProfessionId = getdetails.ProfessionId,
            BussinesName = getdetails.BussinesName,
            Experience = getdetails.Experience,
            PriceRange = getdetails.PriceRange,
            AddressId = getdetails.AddressId,
            AccountId = getdetails.AccountId
        };
    }

    public BussinesDetailsForBusinessOwner GetBussinesDetailsForBusinessOwnerByPassword(string password)
    {
        BussinesDetail getdetails = bussinesDetailsRepo.GetAllBussinesDetailsByPassword(password);
        return new BussinesDetailsForBusinessOwner()
        {
            Id = getdetails.Id,
            FirstName = getdetails.FirstName,
            LastName = getdetails.LastName,
            ProfessionId = getdetails.ProfessionId,
            BussinesName = getdetails.BussinesName,
            Experience = getdetails.Experience,
            PriceRange = getdetails.PriceRange,
            AddressId = getdetails.AddressId,
            AccountId = getdetails.AccountId
        };
    }

    public int GetCityId(string cityName)
    {
        return bussinesDetailsRepo.GetCityIdByName(cityName);
    }

    public int GetProfessionId(string professionName) 
    {
        return bussinesDetailsRepo.GetProfessionIdByName(professionName);
    }

    public BussinesDetailsForBusinessOwner AddBussinesDetailsForBusinessOwner(BussinesDetailsForBusinessOwner bussinesDetailsForBusinessOwner, string cityName, string professionName)
    {
        BussinesDetail addDetails = new BussinesDetail();
        addDetails.FirstName = bussinesDetailsForBusinessOwner.FirstName;
        addDetails.LastName = bussinesDetailsForBusinessOwner.LastName;
        addDetails.ProfessionId = GetProfessionId(professionName);
        addDetails.BussinesName = bussinesDetailsForBusinessOwner.BussinesName;
        addDetails.Experience = bussinesDetailsForBusinessOwner.Experience;
        addDetails.PriceRange = bussinesDetailsForBusinessOwner.PriceRange;
        addDetails.AddressId = GetCityId(cityName);
        addDetails.AccountId = bussinesDetailsForBusinessOwner.AccountId;
        bussinesDetailsRepo.AddNewBussinesDetails(addDetails);
        return bussinesDetailsForBusinessOwner;
    }

    public BussinesDetailsForBusinessOwner UpdateBussinesDetailsForBusinessOwner(int id, BussinesDetailsForBusinessOwner bussinesDetailsForBusinessOwner, string cityName, string professionName)
    {
        BussinesDetail updateDetails = new BussinesDetail();
        updateDetails.FirstName = bussinesDetailsForBusinessOwner.FirstName;
        updateDetails.LastName = bussinesDetailsForBusinessOwner.LastName;
        updateDetails.ProfessionId = GetProfessionId(professionName);
        updateDetails.BussinesName = bussinesDetailsForBusinessOwner.BussinesName;
        updateDetails.Experience = bussinesDetailsForBusinessOwner.Experience;
        updateDetails.PriceRange = bussinesDetailsForBusinessOwner.PriceRange;
        updateDetails.AddressId = GetCityId(cityName);
        updateDetails.AccountId = bussinesDetailsForBusinessOwner.AccountId;
        bussinesDetailsRepo.UpdateBussinesDetails(id, updateDetails);
        return bussinesDetailsForBusinessOwner;
        //return bussinesDetailsRepo.UpdateBussinesDetails(bussinesDetailsForBusinessOwner);
    }

    public BussinesDetailsForBusinessOwner DeleteBussinesDetailsForBusinessOwner(int id)
    {
        BussinesDetail deletedetails = bussinesDetailsRepo.DeleteBussinesDetails(id);
        return new BussinesDetailsForBusinessOwner()
        {
            Id = deletedetails.Id,
            FirstName = deletedetails.FirstName,
            LastName = deletedetails.LastName,
            ProfessionId = deletedetails.ProfessionId,
            BussinesName = deletedetails.BussinesName,
            Experience = deletedetails.Experience,
            PriceRange = deletedetails.PriceRange,
            AddressId = deletedetails.AddressId,
            AccountId = deletedetails.AccountId
        };
    }
}
