using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.DalApi;

public interface IBussinesDetailsRepo
{
    BussinesDetail AddNewBussinesDetails(BussinesDetail bussinesDetail);
    BussinesDetail UpdateBussinesDetails(int id,  BussinesDetail bussinesDetail);
}
