using Dal.DalApi;
using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.DalImplementation;

public class ProfessionalRepo : IProfessionalRepo
{
    LibraryContext context = new LibraryContext();
    public ProfessionalRepo(LibraryContext context)
    {
        this.context = context;
    }
    public List<Professional> GetAllProfessionals()
    {
        return context.Professionals.ToList();
    }
}
