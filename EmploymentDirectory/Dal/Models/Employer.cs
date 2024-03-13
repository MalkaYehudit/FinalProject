using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class Employer
{
    public int Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public int AddressId { get; set; }

    public int ProfessionalId { get; set; }

    public virtual Address Address { get; set; }

    public virtual Professional Professional { get; set; }
}
