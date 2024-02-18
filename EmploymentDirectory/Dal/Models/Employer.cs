using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class Employer
{
    public int Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public int AddressId { get; set; }

    public int BussinesDetailsId { get; set; }
}
