using Bl.BlApi;
using Bl.BlImplementation;
using Bl.BlObjects;
using Dal.DalApi;
using Dal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmploymentDirectory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BussinesDetailsForBussinesOwnersController : ControllerBase
    {
        IBussinesDetailsRepoForBusinessOwner _bussinesDetailsRepoForBusinessOwner;
        public BussinesDetailsForBussinesOwnersController(IBussinesDetailsRepoForBusinessOwner bussinesDetailsRepoForBusinessOwner, LibraryContext libraryContext)
        {
            _bussinesDetailsRepoForBusinessOwner = bussinesDetailsRepoForBusinessOwner;
        }
        [HttpGet]
        public ActionResult<List<BussinesDetailsForBusinessOwner>> GetAllBussinesDetailsForBussinesOwner()
        {
            List<BussinesDetailsForBusinessOwner> getAll = _bussinesDetailsRepoForBusinessOwner.GetAllBussinesDetailsForBusinessOwners();
            if (getAll != null)
            {
                return getAll;
            }
            return NotFound();
        }

        [HttpGet("{id}")]
        public ActionResult<BussinesDetailsForBusinessOwner> GetAllBussinesDetailsByIdForBussinesOwner(int id)
        {
            BussinesDetailsForBusinessOwner getById = _bussinesDetailsRepoForBusinessOwner.GetBussinesDetailsForBusinessOwnerById(id);
            if(getById != null)
            {
                return getById;
            }
            return NotFound();
        }
    }
}
