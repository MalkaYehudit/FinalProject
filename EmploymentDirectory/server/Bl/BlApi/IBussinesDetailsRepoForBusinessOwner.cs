﻿using Bl.BlObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.BlApi;

public interface IBussinesDetailsRepoForBusinessOwner
{
    List<BussinesDetailsForBusinessOwner> GetAllBussinesDetailsForBusinessOwners();
    BussinesDetailsForBusinessOwner GetBussinesDetailsForBusinessOwnerById(int id);
    BussinesDetailsForBusinessOwner AddBussinesDetailsForBusinessOwner(BussinesDetailsForBusinessOwner bussinesDetailsForBusinessOwner, string cityName);
    BussinesDetailsForBusinessOwner UpdateBussinesDetailsForBusinessOwner(int id, BussinesDetailsForBusinessOwner bussinesDetailsForBusinessOwner);
    BussinesDetailsForBusinessOwner DeleteBussinesDetailsForBusinessOwner(int id);

}
