using Dal.DalApi;
using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.DalImplementation;

public class BussinesDetailsRepo : IBussinesDetailsRepo
{
    LibraryContext context = new LibraryContext();
    public BussinesDetailsRepo(LibraryContext context)
    {
        this.context = context;
    }
    public BussinesDetail AddNewBussinesDetails(BussinesDetail bussinesDetail)
    {
        context.BussinesDetails.Add(bussinesDetail);
        context.SaveChanges();
        return bussinesDetail;
    }

    public BussinesDetail UpdateBussinesDetails(int id, BussinesDetail bussinesDetail)
    {
        BussinesDetail b = context.BussinesDetails.FirstOrDefault(x => x.Id == id);
        if (b != null)
        {
            b.ProfessionId = bussinesDetail.ProfessionId;
            b.BusinessName = bussinesDetail.BusinessName;
            b.Experience = bussinesDetail.Experience;
            b.CityId = bussinesDetail.CityId;
            b.PriceRange = bussinesDetail.PriceRange;
        }

        context.SaveChanges();
        return bussinesDetail;
    }
}
