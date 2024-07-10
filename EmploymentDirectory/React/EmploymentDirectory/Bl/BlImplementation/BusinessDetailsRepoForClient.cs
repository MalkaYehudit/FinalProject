using Bl.BlApi;
using Bl.BlObjects;
using Dal;
using Dal.DalApi;
using Dal.DalImplementation;
using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace Bl.BlImplementation
{
    public class BusinessDetailsRepoForClient : IBusinessDetailsRepoForCliant
    { 
        AddressesRepo addressesRepo;
        BussinesDetailsRepo bussinesDetailsRepo;
        Profession profession;
        public BusinessDetailsRepoForClient(DalManager dalManager)
        {

            this.addressesRepo = dalManager.addresses;
            this.bussinesDetailsRepo = dalManager.bussinesDetails;
            this.profession = dalManager.profession;

        }

       List<BusinessDetailsRepoForCliant> IBusinessDetailsRepoForCliant.GetAllBussinesDetails()
        {
            List<BussinesDetail> temp = bussinesDetailsRepo.GetAllBussinesDetails();
            List<BusinessDetailsRepoForCliant> list = new List<BusinessDetailsRepoForCliant>();
            for (int i = 0; i < temp.Count; i++)
            {
                list.Add(new BusinessDetailsRepoForCliant()
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

            return list;

         

        }
            

        BusinessDetailsRepoForCliant IBusinessDetailsRepoForCliant.GetBussinesDetailsById(int id)
        {
            BussinesDetail details = bussinesDetailsRepo.GetBussinesDetailsById(id);
            return new BusinessDetailsRepoForCliant() { BussinesName = details.BussinesName,
                FirstNameOfOwner = details.FirstName,
                LastNameOfOwner = details.LastName,
                Profession = details.ProfessionId,
                PriceRange = details.PriceRange,
                City = details.AddressId };
        }
    }
}
