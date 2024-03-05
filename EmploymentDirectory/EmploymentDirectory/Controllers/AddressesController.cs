using Dal.DalApi;
using Dal.DalImplementation;
using Dal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static System.Reflection.Metadata.BlobBuilder;

namespace EmploymentDirectory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressesController : ControllerBase
    {
        IAddressesRepo addressesRepo;
        public AddressesController(IAddressesRepo addressesRepo)
        {
            this.addressesRepo = addressesRepo;
        }
        [HttpGet]
        public ActionResult<List<Address>> GetAddresses()
        {
            return addressesRepo.GetAllAddresses();
        }
        [HttpGet("{id}")]
        public ActionResult<Address> GetAddress(int id)
        {
            return addressesRepo.GetAddressById(id);
        }
        [HttpPost]
        public Address PostNewAddress(Address city)
        {
            Address address = addressesRepo.AddNewCity(city);
            return address;
        }

        [HttpPut("{id}")]
        public Address PutAddress(int id, [FromForm]string city)
        {
            return addressesRepo.UpdateCity(id, city);    
        }

        [HttpDelete("{id}")]
        public Address DeleteAddress(int id)
        {
            return addressesRepo.DeleteCity(id);
        }
    }
}
