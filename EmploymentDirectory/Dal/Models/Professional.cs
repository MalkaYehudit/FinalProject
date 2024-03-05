using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class Professional
{
    public int Id { get; set; }

    public string Professional1 { get; set; }

    public virtual ICollection<BussinesDetail> BussinesDetails { get; set; } = new List<BussinesDetail>();
}
