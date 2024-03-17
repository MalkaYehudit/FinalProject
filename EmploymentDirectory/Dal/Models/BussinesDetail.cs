using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class BussinesDetail
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

    public virtual Account Account { get; set; }

    public virtual Address Address { get; set; }

    public virtual Profession Profession { get; set; }
}
