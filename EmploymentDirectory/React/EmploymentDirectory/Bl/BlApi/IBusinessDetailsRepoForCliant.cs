using Bl.BlObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.BlApi
{
    public interface IBusinessDetailsRepoForCliant
    {
        
       List<BusinessDetailsRepoForCliant> GetAllBussinesDetails();
        BusinessDetailsRepoForCliant GetBussinesDetailsById(int id);
        //BusinessDetailsForCliant AddNewBussinesDetails(BusinessDetailsForCliant bussinesDetail);
        //BusinessDetailsForCliant UpdateBussinesDetails(int id,  BusinessDetailsForCliant bussinesDetail);
        //BusinessDetailsForCliant DeleteBussinesDetails(int id);

    }
}
