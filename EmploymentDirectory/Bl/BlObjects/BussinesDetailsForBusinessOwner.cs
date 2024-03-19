using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.BlObjects;

public class BussinesDetailsForBusinessOwner
{
    public int Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public int ProfessionId { get; set; }

    public string BussinesName { get; set; }

    public int Experience { get; set; }

    public string PriceRange { get; set; }

    public int AddressId { get; set; }

    public string AccountId { get; set; }
}
