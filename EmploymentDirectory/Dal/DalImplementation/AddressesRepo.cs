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
        public Address AddNewCity(Address city)
        {
            context.Addresses.Add(city);
            context.SaveChanges();
            return city;
        }

        public Address UpdateCity(int id, Address city)
        {
            Address a = context.Addresses.FirstOrDefault(x => x.Id == id);
            if (a != null)
            {
                a.City = city.City;
            }
            context.SaveChanges();
            return a;
        }
    }
}
