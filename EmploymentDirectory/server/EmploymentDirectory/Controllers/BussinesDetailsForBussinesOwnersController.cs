﻿using Bl;
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
        BussinesDetailsRepoForBussinesOwner _bussinesDetailsRepoForBusinessOwner;
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
            if (getById != null)
            {
                return getById;
            }
            return NotFound();
        }

        [HttpGet("GetBussinesDetailsForBussinesOwnerByPassword")]
        public ActionResult<BussinesDetailsForBusinessOwner> GetBussinesDetailsForBussinesOwnerByPassword([FromQuery]string password)
        {
            BussinesDetailsForBusinessOwner getByProfessionName = _bussinesDetailsRepoForBusinessOwner.GetBussinesDetailsForBusinessOwnerByPassword(password);
            if (getByProfessionName != null)
            {
                return getByProfessionName;
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult<BussinesDetailsForBusinessOwner> AddNewBussinesDetailsForBussinesOwner([FromBody]BussinesDetailsForBusinessOwner bussinesDetailsForBusinessOwner, [FromQuery]string cityName, [FromQuery]string professionName)
        {
            BussinesDetailsForBusinessOwner addNewBussines = _bussinesDetailsRepoForBusinessOwner.AddBussinesDetailsForBusinessOwner(bussinesDetailsForBusinessOwner, cityName, professionName);
            if (addNewBussines != null)
            {
                return addNewBussines;
            }
            return NotFound();
        }


        [HttpPut("{id}")]
        public ActionResult<BussinesDetailsForBusinessOwner> UpdateBussinesDetailsForBussinesOwner(int id, [FromBody]BussinesDetailsForBusinessOwner bussinesDetailsForBusinessOwner, [FromQuery]string cityName, [FromQuery]string professionName)
        {
            BussinesDetailsForBusinessOwner update = _bussinesDetailsRepoForBusinessOwner.UpdateBussinesDetailsForBusinessOwner(id, bussinesDetailsForBusinessOwner, cityName, professionName);
            if(update != null)
            {
                return update;
            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public ActionResult<BussinesDetailsForBusinessOwner> DeleteBussinesDetailsForBussinesOwner(int id)
        {
            BussinesDetailsForBusinessOwner delete = _bussinesDetailsRepoForBusinessOwner.DeleteBussinesDetailsForBusinessOwner(id);
            if(delete != null)
            {
                return delete;
            }
            return NotFound();
        }
    }
}
