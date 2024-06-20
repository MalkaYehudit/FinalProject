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
        public Address GetAddressById(int id)
        {
            return context.Addresses.Where(a => a.Id == id).FirstOrDefault();
        }
    }
}
