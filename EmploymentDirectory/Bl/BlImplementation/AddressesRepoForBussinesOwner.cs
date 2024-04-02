using Bl.BlApi;
using Bl.BlObjects;
using Dal;
using Dal.DalApi;
using Dal.DalImplementation;
using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.BlImplementation;

public class AddressesRepoForBussinesOwner : IAddressesRepoForBussinesOwner
{
    AddressesRepo addressesRepo;
    public AddressesRepoForBussinesOwner(DalManager dalManager)
    {
        this.addressesRepo = dalManager.addresses;
    }
    public List<AddressesForBussinesOwner> GetAllAddressesForBussinesOwners()
    {
        List<Address> addressList = addressesRepo.GetAllAddresses();
        List<AddressesForBussinesOwner> addressesForBussinesOwners = new List<AddressesForBussinesOwner>();
        for (int i = 0; i < addressList.Count; i++)
        {
            addressesForBussinesOwners.Add(new AddressesForBussinesOwner()
            {
                Id = addressList[i].Id,
                City = addressList[i].City,
            });
        }        
        return addressesForBussinesOwners;
    }
}

