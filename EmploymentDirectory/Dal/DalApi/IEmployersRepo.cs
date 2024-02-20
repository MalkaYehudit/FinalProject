using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.DalApi;

public interface IEmployersRepo
{
    Employer AddNewEmployer(Employer employer);
    Employer UpdateEmployer(int id, Employer employer);
}
