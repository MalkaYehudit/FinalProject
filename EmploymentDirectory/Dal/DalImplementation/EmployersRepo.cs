using Dal.DalApi;
using Dal.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.DalImplementation;

public class EmployersRepo : IEmployersRepo
{
    LibraryContext context = new LibraryContext();
    public EmployersRepo(LibraryContext context)
    {
        this.context = context;
    }
    public Employer AddNewEmployer(Employer employer)
    {
        context.Employers.Add(employer);
        context.SaveChanges();
        return employer;
    }

    public Employer? UpdateEmployer(int id, Employer employer)
    {
        Employer e = context.Employers.FirstOrDefault(x => x.Id == id);
        if (e != null)
        {
            e.FirstName = employer.FirstName;
            e.LastName = employer.LastName;
            e.AddressId = employer.AddressId;
            e.BussinesDetailsId = employer.BussinesDetailsId;
        }

        context.SaveChanges();
        return e;
    }
}
