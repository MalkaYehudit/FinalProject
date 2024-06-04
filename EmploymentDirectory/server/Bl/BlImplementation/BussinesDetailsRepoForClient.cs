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
        this.profession = dalManager.profession;
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
                Profession = new ProfessionsForBussinesOwner { Profession = temp[i].Profession.Profession1 },
                PriceRange = temp[i].PriceRange,
                Experience = temp[i].Experience,
                City = new AddressesForBussinesOwner{ City = temp[i].Address.City }
                
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
            Profession = new ProfessionsForBussinesOwner { Profession = details.Profession.Profession1},
            PriceRange = details.PriceRange,
            City = new AddressesForBussinesOwner { City = details.Address.City }
        };
    }

    public List<BussinesDetailsForClient> GetAllBussinesDetailsForClientByCityName(string cityName)
    {
        List<BussinesDetail> temp = bussinesDetailsRepo.GetAllBussinesDetailsByCityName(cityName);
        List<BussinesDetailsForClient> bussinesDetailsForClientsByCityName = new List<BussinesDetailsForClient>();
        for (int i = 0; i < temp.Count; i++)
        {
            bussinesDetailsForClientsByCityName.Add(new BussinesDetailsForClient()
            {
                BussinesName = temp[i].BussinesName,
                FirstNameOfOwner = temp[i].FirstName,
                LastNameOfOwner = temp[i].LastName,
                Profession = new ProfessionsForBussinesOwner { Profession = temp[i].Profession.Profession1 },
                PriceRange = temp[i].PriceRange,
                Experience = temp[i].Experience,
                City = new AddressesForBussinesOwner { City = temp[i].Address.City }
            });
        }
        return bussinesDetailsForClientsByCityName;
    }

    public List<BussinesDetailsForClient> GetAllBussinesDetailsForClientByProfession(string professionName)
    {
        List<BussinesDetail> temp = bussinesDetailsRepo.GetAllBussinesDetailsByProfession(professionName);
        List<BussinesDetailsForClient> bussinesDetailsForClientsByProfession = new List<BussinesDetailsForClient>();
        for (int i = 0; i < temp.Count; i++)
        {
            bussinesDetailsForClientsByProfession.Add(new BussinesDetailsForClient()
            {
                BussinesName = temp[i].BussinesName,
                FirstNameOfOwner = temp[i].FirstName,
                LastNameOfOwner = temp[i].LastName,
                Profession = new ProfessionsForBussinesOwner { Profession = temp[i].Profession.Profession1 },
                PriceRange = temp[i].PriceRange,
                Experience = temp[i].Experience,
                City = new AddressesForBussinesOwner { City = temp[i].Address.City }
            });
        }
        return bussinesDetailsForClientsByProfession;
    }

    public List<BussinesDetailsForClient> GetAllBussinesDetailsForClientByEmployersName(string employersName)
    {
        List<BussinesDetail> temp = bussinesDetailsRepo.GetAllBussinesDetailsByEmployersName(employersName);
        List<BussinesDetailsForClient> bussinesDetailsForClientsByEmployersName = new List<BussinesDetailsForClient>();
        for (int i = 0; i < temp.Count; i++)
        {
            bussinesDetailsForClientsByEmployersName.Add(new BussinesDetailsForClient()
            {
                BussinesName = temp[i].BussinesName,
                FirstNameOfOwner = temp[i].FirstName,
                LastNameOfOwner = temp[i].LastName,
                Profession = new ProfessionsForBussinesOwner { Profession = temp[i].Profession.Profession1 },
                PriceRange = temp[i].PriceRange,
                Experience = temp[i].Experience,
                City = new AddressesForBussinesOwner { City = temp[i].Address.City }
            });
        }
        return bussinesDetailsForClientsByEmployersName;
    }

    public List<BussinesDetailsForClient> GetAllBussinesDetailsForClientByExperience(int experience)
    {
        List<BussinesDetail> temp = bussinesDetailsRepo.GetAllBussinesDetailsByExprience(experience);
        List<BussinesDetailsForClient> bussinesDetailsForClientsByExperience = new List<BussinesDetailsForClient>();
        for (int i = 0; i < temp.Count; i++)
        {
            bussinesDetailsForClientsByExperience.Add(new BussinesDetailsForClient()
            {
                BussinesName = temp[i].BussinesName,
                FirstNameOfOwner = temp[i].FirstName,
                LastNameOfOwner = temp[i].LastName,
                Profession = new ProfessionsForBussinesOwner { Profession = temp[i].Profession.Profession1 },
                PriceRange = temp[i].PriceRange,
                Experience = temp[i].Experience,
                City = new AddressesForBussinesOwner { City = temp[i].Address.City }
            });
        }
        return bussinesDetailsForClientsByExperience;
    }
}

