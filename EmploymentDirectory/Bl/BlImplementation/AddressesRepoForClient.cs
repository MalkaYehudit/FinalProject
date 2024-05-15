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

public class AddressesRepoForClient : IAddressesRepoForClient
{
    AddressesRepo addressesRepo;
    public AddressesRepoForClient(DalManager dalManager)
    {
        this.addressesRepo = dalManager.addresses;
    }
    public List<AddressesForClient> GetAddressesByIdForClient(int id)
    {
        List<Address> addressList = addressesRepo.GetAddressById(id);
        List<AddressesForClient> addressesForClient = new List<AddressesForClient>();
        for (int i = 0; i < addressList.Count; i++)
        {
            addressesForClient.Add(new AddressesForClient()
            {
                City = addressList[i].City,
            });
        }        
        return addressesForClient;
    }
}

