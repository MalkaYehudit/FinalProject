using Bl;
using Bl.BlApi;
using Bl.BlObjects;
using Microsoft.AspNetCore.Http;

using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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

        [HttpGet("GetBussinesDetailsForClientsById/{id}")]
        public ActionResult<BussinesDetailsForClient> GetBussinesDetailsForClientsById(int id)
        {
            BussinesDetailsForClient getById = _bussinesDetailsRepoForClient.GetBussinesDetailsForClientsById(id);
            if (getById != null)
            {
                return getById;
            }
            return NotFound();
        }

        [HttpGet("GetAllBussinesDetailsForClientsByCityName/{cityName}")]
        public ActionResult<List<BussinesDetailsForClient>> GetAllBussinesDetailsForClientsByCityName(string cityName)
        {
            List<BussinesDetailsForClient> getByCityName = _bussinesDetailsRepoForClient.GetAllBussinesDetailsForClientByCityName(cityName);  
            if (getByCityName != null)
            {
                return getByCityName;
            }
            return NotFound();
        }

        [HttpGet("GetAllBussinesDetailsForClientsByProfession/{professionName}")]
        public ActionResult<List<BussinesDetailsForClient>> GetAllBussinesDetailsForClientsByProfession(string professionName)
        {
            List<BussinesDetailsForClient> getByProfessionName = _bussinesDetailsRepoForClient.GetAllBussinesDetailsForClientByCityName(professionName);
            if (getByProfessionName != null)
            {
                return getByProfessionName;
            }
            return NotFound();
        }

        [HttpGet("GetAllBussinesDetailsForClientsByEmployersName/{employersName}")]
        public ActionResult<List<BussinesDetailsForClient>> GetAllBussinesDetailsForClientsByEmployersName(string employersName)
        {
            List<BussinesDetailsForClient> getByEmployerName = _bussinesDetailsRepoForClient.GetAllBussinesDetailsForClientByCityName(employersName);
            if (getByEmployerName != null)
            {
                return getByEmployerName;
            }
            return NotFound();
        }

        [HttpGet("GetAllBussinesDetailsForClientsByExperience/{experience}")]
        public ActionResult<List<BussinesDetailsForClient>> GetAllBussinesDetailsForClientsByExperience(int experience)
        {
            List<BussinesDetailsForClient> getByExperience = _bussinesDetailsRepoForClient.GetAllBussinesDetailsForClientByExperience(experience);
            if (getByExperience != null)
            {
                return getByExperience;
            }
            return NotFound();
        }

    }

}

    

