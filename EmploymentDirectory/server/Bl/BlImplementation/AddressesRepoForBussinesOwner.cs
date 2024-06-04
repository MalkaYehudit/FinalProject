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
    /*public List<AddressesForBussinesOwner> GetAddressesByIdForClient(int id)
    {
        List<Address> addressList = addressesRepo.GetAddressById(id);
        List<AddressesForBussinesOwner> addressesForClient = new List<AddressesForBussinesOwner>();
        for (int i = 0; i < addressList.Count; i++)
        {
            addressesForClient.Add(new AddressesForBussinesOwner()
            {
                City = addressList[i].City,
            });
        }        
        return addressesForClient;
    }*/
}

