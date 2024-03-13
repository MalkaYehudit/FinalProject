using Dal.DalApi;
using Dal.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.DalImplementation;

public class BussinesDetailsRepo : IBussinesDetailsRepo
{
    LibraryContext context;
    public BussinesDetailsRepo(LibraryContext context)
    {
        this.context = context;
    }

    public List<BussinesDetail> GetAllBussinesDetails()
    {
        return context.BussinesDetails.Include(p => p.Professional.BussinesDetailsId).ThenInclude(e => e.prof)
    }

    //public BussinesDetail GetBussinesDetailsById(int id)
    //{
    //    return context.BussinesDetails.FirstOrDefault(b => b.Id == id);
    //    //return context.BussinesDetails.Where(b => b.Id == id).Include(b => b.CityId).FirstOrDefault();
    //}

    //public BussinesDetail AddNewBussinesDetails(BussinesDetail bussinesDetail)
    //{
    //    context.BussinesDetails.Add(bussinesDetail);
    //    context.SaveChanges();
    //    return bussinesDetail;
    //}

    //public BussinesDetail UpdateBussinesDetails(int id, BussinesDetail bussinesDetail)
    //{
    //    BussinesDetail b = context.BussinesDetails.FirstOrDefault(x => x.Id == id);
    //    if (b != null)
    //    {
    //        b.ProfessionId = bussinesDetail.ProfessionId;
    //        b.BusinessName = bussinesDetail.BusinessName;
    //        b.Experience = bussinesDetail.Experience;
    //        b.CityId = bussinesDetail.CityId;
    //        b.PriceRange = bussinesDetail.PriceRange;
    //    }
    //    context.SaveChanges();
    //    return b;
    //}

    //public BussinesDetail DeleteBussinesDetails(int id)
    //{
    //    BussinesDetail bussinesDetail = context.BussinesDetails.FirstOrDefault(b => b.Id == id);
    //    if(bussinesDetail != null)
    //    {
    //        context.BussinesDetails.Remove(bussinesDetail);
    //    }
    //    context.SaveChanges();
    //    return bussinesDetail;
    //}
}
