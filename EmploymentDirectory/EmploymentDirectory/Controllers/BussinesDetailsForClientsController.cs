using Bl;
using Bl.BlApi;
using Bl.BlObjects;
using Microsoft.AspNetCore.Http;

using Microsoft.AspNetCore.Mvc;

namespace EmploymentDirectory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BussinesDetailsForClientsController : ControllerBase
    {
        IBussinesDetailsRepoForClient _bussinesDetailsRepoForClient;
        public BussinesDetailsForClientsController(BlManager blManager)
        {
            _bussinesDetailsRepoForClient = blManager.BussinesDetailsRepoForClient;
        }

        [HttpGet]
        public ActionResult<List<BussinesDetailsForClient>> GetAllBussinesDetailsForClient()
        {
            List<BussinesDetailsForClient> getAll = _bussinesDetailsRepoForClient.GetAllBusinessDetailsForClients();
            if (getAll != null)
            {
                return getAll;
            }
            return NotFound();
        }
        [HttpGet("{id}")]
        public ActionResult<BussinesDetailsForClient> GetAllBussinesDetailsByIdForClient(int id)
        {
            BussinesDetailsForClient getById = _bussinesDetailsRepoForClient.GetBussinesDetailsForClientsById(id);
            if (getById != null)
            {
                return getById;
            }
            return NotFound();
        }
    }

}

    

