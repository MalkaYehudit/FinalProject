using Dal.DalApi;
using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.DalImplementation;

public class ProfessionsRepo : IProfessionsRepo
{
    LibraryContext context;

    public ProfessionsRepo( LibraryContext context)
    { 
        this.context = context;
    }
    public Profession GetProfessionById(int id)
    {
        return context.Professions.Where(p => p.Id == id).FirstOrDefault();
    }
}
