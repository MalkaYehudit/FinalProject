using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Bl.BlObjects
{
    public class BussinesDetailsForClient
    {
        public string FirstNameOfOwner { get; set; }

        public string LastNameOfOwner { get; set; }

        public ProfessionsForBussinesOwner Profession { get; set; }

        public string BussinesName { get; set; }

        public int Experience { get; set; }

        public string PriceRange { get; set; }

        public AddressesForBussinesOwner City { get; set; }
    }
}
