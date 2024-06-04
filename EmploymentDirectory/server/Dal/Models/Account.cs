using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class Account
{
    public string UserName { get; set; }

    public string Password { get; set; }

    public virtual ICollection<BussinesDetail> BussinesDetails { get; set; } = new List<BussinesDetail>();
}
