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

        public Address AddNewCity(Address city)
        {
            context.Addresses.Add(city);
            context.SaveChanges();
            return city;
        }

        public Address UpdateCity(int id, string city)
        {
            Address a = context.Addresses.FirstOrDefault(x => x.Id == id);
            if (a != null)
            {
                a.City = city;
            }
            context.SaveChanges();
            return a;
        }

        public Address DeleteCity(int id)
        {
            Address address = context.Addresses.FirstOrDefault(a => a.Id == id);
            if (address != null)
            {
                context.Addresses.Remove(address);
            }
            context.SaveChanges();
            return address;
        }
    }
}
