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

    public Professional GetProfessionalById(int id)
    {
        return context.Professionals.FirstOrDefault(p => p.Id == id);
    }

    public Professional AddNewProfessional(Professional professional)
    {
        context.Professionals.Add(professional);
        context.SaveChanges();
        return professional;
    }

    public Professional UpdateProfessional(int id, Professional professional)
    {
        Professional p = context.Professionals.FirstOrDefault(p => p.Id == id);
        if (p != null)
        {
            p.Professionals = professional.Professionals;
        }
        context.SaveChanges();
        return p;
    }
    public Professional DeleteProfessional(int id)
    {
        Professional professional = context.Professionals.FirstOrDefault(p => p.Id == id);
        if (professional != null)
        {
            context.Professionals.Remove(professional);
        }
        context.SaveChanges();
        return professional;
    }
}
