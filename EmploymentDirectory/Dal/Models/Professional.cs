using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class Professional
{
    public int Id { get; set; }

    public int EmployersId { get; set; }

    public int BussinesDetailsId { get; set; }

    public virtual ICollection<BussinesDetail> BussinesDetails { get; set; } = new List<BussinesDetail>();

    public virtual ICollection<Employer> Employers { get; set; } = new List<Employer>();
}
