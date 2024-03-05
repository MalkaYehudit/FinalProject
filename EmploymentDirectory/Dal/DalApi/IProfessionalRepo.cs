using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.DalApi;

public interface IProfessionalRepo
{
    List<Professional> GetAllProfessionals();
    Professional GetProfessionalById(int id);
    Professional AddNewProfessional(Professional professional);
    Professional UpdateProfessional(int id,  Professional professional);
    Professional DeleteProfessional(int id);
}
