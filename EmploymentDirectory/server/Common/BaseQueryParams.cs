using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common;

public class BaseQueryParams
{
    public int PageSize
    {
        get { return pageSize; }
        set { if (value > 0 && value < MAX_PAGE_SIZE) pageSize = value; }
    }






}
