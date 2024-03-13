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

    public List<Employer> GetAllEmployers()
    {
        return context.Employers.ToList();

    }

    //public Employer GetEmployerById(int id)
    //{
    //    return context.Employers.FirstOrDefault(e => e.Id == id);
    //}

    //public Employer AddNewEmployer(Employer employer)
    //{
    //    context.Employers.Add(employer);
    //    context.SaveChanges();
    //    return employer;
    //}

    //public Employer UpdateEmployer(int id, Employer employer)
    //{
    //    Employer e = context.Employers.FirstOrDefault(x => x.Id == id);
    //    if (e != null)
    //    {
    //        e.FirstName = employer.FirstName;
    //        e.LastName = employer.LastName;
    //        e.AddressId = employer.AddressId;
    //        e.BussinesDetailsId = employer.BussinesDetailsId;
    //    }
    //    context.SaveChanges();
    //    return e;
    //}

    //public Employer DeleteEmployer(int id)
    //{
    //    Employer employer = context.Employers.FirstOrDefault(e => e.Id == id);
    //    if (employer != null)
    //    {
    //        context.Employers.Remove(employer);
    //    }
    //    context.SaveChanges();
    //    return employer;
    //}
}
