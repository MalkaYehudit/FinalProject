using Dal.DalApi;
using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.DalImplementation
{
    public class AddressesRepo : IAddressesRepo
    {
        LibraryContext context;
        public AddressesRepo(LibraryContext context)
        {
            this.context = context;
        }

        public List<Address> GetAllAddresses()
        {
            return context.Addresses.ToList();

        }

        public Address GetAddressById(int id)
        {
            return context.Addresses.FirstOrDefault(a => a.Id == id);
        }
    }
}
