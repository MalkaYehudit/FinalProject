using Bl;
using Bl.BlApi;
using Bl.BlImplementation;
using Bl.BlObjects;
using Dal.DalApi;
using Dal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EmploymentDirectory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BussinesDetailsForBussinesOwnersController : ControllerBase
    {
        IBussinesDetailsRepoForBusinessOwner _bussinesDetailsRepoForBusinessOwner;
        public BussinesDetailsForBussinesOwnersController(BlManager blManager)
        {
            _bussinesDetailsRepoForBusinessOwner = blManager.BussinesDetailsRepoForBussinesOwner;
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
