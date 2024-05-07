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

        [HttpGet]
        public ActionResult<List<AddressesForClient>> GetAllAddressesForClient()
        {
            List<AddressesForClient> getAll = _addressesRepoForClient.GetAllAddressesForClient();
            if(getAll != null)
            {
                return getAll;
            }
            return NotFound();
        }
    }
}
