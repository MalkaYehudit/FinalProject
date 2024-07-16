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

    public ProfessionsForBussinesOwner Profession { get; set; }

    public string BussinesName { get; set; }

    public int Experience { get; set; }

    public string PriceRange { get; set; }

    public AddressesForBussinesOwner City { get; set; }

    public string AccountId { get; set; }
}
