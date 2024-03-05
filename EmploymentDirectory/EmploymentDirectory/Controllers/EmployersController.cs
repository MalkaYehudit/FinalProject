using Dal.DalApi;
using Dal.DalImplementation;
using Dal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmploymentDirectory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployersController : ControllerBase
    {
        IEmployersRepo employersRepo;
        public EmployersController(IEmployersRepo employersRepo)
        {
            this.employersRepo = employersRepo;
        }

        [HttpGet]
        public ActionResult<List<Employer>> GetEmployers()
        {
            return employersRepo.GetAllEmployers();
        }
        [HttpGet("{id}")]
        public ActionResult<Employer> GetEmployer(int id)
        {
            return employersRepo.GetEmployerById(id);
        }
        [HttpPost]
        public Employer PostNewEmployer(Employer employer)
        {
            Employer employers = employersRepo.AddNewEmployer(employer);
            return employers;
        }

        [HttpPut("{id}")]
        public Employer PutEmployer(int id, [FromForm] Employer employer)
        {
            return employersRepo.UpdateEmployer(id, employer);
        }

        [HttpDelete("{id}")]
        public Employer DeleteEmployer(int id)
        {
            return employersRepo.DeleteEmployer(id);
        }
    }
}

