using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class BussinesDetail
{
    public int Id { get; set; }

    public int ProfessionId { get; set; }

    public string BusinessName { get; set; }

    public int Experience { get; set; }

    public int CityId { get; set; }

    public string PriceRange { get; set; }
}
