using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class Address
{
    public int Id { get; set; }

    public string City { get; set; }

    public virtual ICollection<BussinesDetail> BussinesDetails { get; set; } = new List<BussinesDetail>();

    public virtual ICollection<Client> Clients { get; set; } = new List<Client>();

    public virtual ICollection<Employer> Employers { get; set; } = new List<Employer>();
}
