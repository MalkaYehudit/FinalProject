using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.DalApi;

public interface IAddressesRepo
{
    Address AddNewCity(Address city);
    Address UpdateCity(int id, Address city);
}
