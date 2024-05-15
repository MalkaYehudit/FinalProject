using Bl;
using Bl.BlApi;
using Bl.BlImplementation;
using Bl.BlObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EmploymentDirectory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressesForClientsController : ControllerBase
    {
        IAddressesRepoForClient _addressesRepoForClient;

        public AddressesForClientsController(BlManager blManager)
        {
            _addressesRepoForClient = blManager.AddressesRepoForClient;
        }

        [HttpGet("{id}")]
        public ActionResult<List<AddressesForClient>> GetAddressesByIdForClient(int id)
        {
            List<AddressesForClient> getAll = _addressesRepoForClient.GetAddressesByIdForClient(id);
            if(getAll != null)
            {
                return getAll;
            }
            return NotFound();
        }
    }
}
