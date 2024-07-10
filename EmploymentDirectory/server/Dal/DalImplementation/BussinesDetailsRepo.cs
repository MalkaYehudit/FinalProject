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

        return context.BussinesDetails
            .Include(b => b.Profession)
            .Include(a => a.Address)
            .Include(ac => ac.Account).ToList();
    }

    public BussinesDetail GetBussinesDetailsById(int id)
    {
        return context.BussinesDetails.Where(b => b.Id == id)
            .Include(p => p.Profession)
            .Include(a => a.Address)
            .Include(ac => ac.Account).FirstOrDefault();
    }

    public List<BussinesDetail> GetAllBussinesDetailsByCityName(string cityName)
    {
        return context.BussinesDetails.Where(c => c.Address.City == cityName)
            .Include(p => p.Profession)
            .Include(a => a.Address)
            .Include(ac => ac.Account).ToList();
    }

    public List<BussinesDetail> GetAllBussinesDetailsByProfession(string professionName)
    {
        return context.BussinesDetails.Where(p => p.Profession.Profession1 == professionName)
            .Include(p => p.Profession)
            .Include(a => a.Address)
            .Include(ac => ac.Account).ToList();
    }

    public List<BussinesDetail> GetAllBussinesDetailsByEmployersName(string employersName)
    {
        return context.BussinesDetails.Where(f => f.FirstName == employersName)
            .Include(p => p.Profession)
            .Include(a => a.Address)
            .Include(ac => ac.Account).ToList();
    }

    public List<BussinesDetail> GetAllBussinesDetailsByExprience(int experience)
    {
        return context.BussinesDetails.Where(ex => ex.Experience == experience)
            .Include(p => p.Profession)
            .Include(a => a.Address)
            .Include(ac => ac.Account).ToList();
    }

    public BussinesDetail GetAllBussinesDetailsByPassword(string password)
    {
        return context.BussinesDetails.Where(ex => ex.Account.Password == password)
            .Include(p => p.Profession)
            .Include(a => a.Address)
            .Include(ac => ac.Account).FirstOrDefault();
    }

    public int GetCityIdByName(string cityName)
    {
        var address = context.Addresses.FirstOrDefault(a => a.City == cityName);
        return address.Id;
    }

    public int GetProfessionIdByName(string professionName) 
    {
        var profession = context.Professions.FirstOrDefault(p => p.Profession1 == professionName);
        return profession.Id;
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
            b.FirstName = bussinesDetail.FirstName;
            b.LastName = bussinesDetail.LastName;
            b.ProfessionId = bussinesDetail.ProfessionId;
            b.BussinesName = bussinesDetail.BussinesName;
            b.Experience = bussinesDetail.Experience;
            b.PriceRange = bussinesDetail.PriceRange;
            b.AddressId = bussinesDetail.AddressId;
            b.AccountId = bussinesDetail.AccountId;
        }
        context.SaveChanges();
        return b;
        /*        context.BussinesDetails.Update(bussinesDetail);
                context.SaveChanges();
                return bussinesDetail;*/
    }

    public BussinesDetail DeleteBussinesDetails(int id)
    {
        BussinesDetail remove = context.BussinesDetails.FirstOrDefault(b => b.Id == id);
        context.BussinesDetails.Remove(remove);
        context.SaveChanges();
        return remove;
    }
}