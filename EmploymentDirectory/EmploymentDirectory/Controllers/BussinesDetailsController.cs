using Dal.DalApi;
using Dal.DalImplementation;
using Dal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmploymentDirectory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BussinesDetailsController : ControllerBase
    {
        IBussinesDetailsRepo bussinesDetailsRepo;
        LibraryContext libraryContext;
        public BussinesDetailsController(IBussinesDetailsRepo bussinesDetailsRepo, LibraryContext libraryContext)
        {
            this.bussinesDetailsRepo = bussinesDetailsRepo;
            this.libraryContext = libraryContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<BussinesDetail>>> GetAllBussineses() 
        {
            return await bussinesDetailsRepo.GetAllBussinesDetailsAsync();
        }

        //[HttpGet("{id}")]
        //public async Task<ActionResult<BussinesDetail>> GetBussinesDetails(int id)
        //{
        //    return await bussinesDetailsRepo.GetBussinesDetailsByIdAsync(id);
        //}

        //[HttpPost]
        //public BussinesDetail PostNewBussinesDetails(BussinesDetail bussinesDetail)
        //{
        //    BussinesDetail bussinesDetails  = bussinesDetailsRepo.AddNewBussinesDetails(bussinesDetail);
        //    return bussinesDetails;
        //}

        //[HttpPut("{id}")]
        //public BussinesDetail PutBussinesDetails(int id,  [FromForm]BussinesDetail bussinesDetail)
        //{
        //    return bussinesDetailsRepo.UpdateBussinesDetails(id, bussinesDetail);
        //}

        //[HttpDelete("{id}")]
        //public BussinesDetail DeleteBussinesDetails(int id)
        //{
        //    return bussinesDetailsRepo.DeleteBussinesDetails(id);
        //}
    }
}
