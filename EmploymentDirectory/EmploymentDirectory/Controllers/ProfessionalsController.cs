using Dal.DalApi;
using Dal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmploymentDirectory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessionalsController : ControllerBase
    {
        IProfessionalRepo professionalRepo;
        public ProfessionalsController(IProfessionalRepo professionalRepo)
        {
            this.professionalRepo = professionalRepo;
        }
        [HttpGet]
        public ActionResult<List<Professional>> GetProfessionals()
        {
            return professionalRepo.GetAllProfessionals();
        }
    }
}
