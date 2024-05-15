using Bl.BlImplementation;
using Bl.BlObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.BlApi;

public interface IAddressesRepoForClient
{
    List<AddressesForClient> GetAddressesByIdForClient(int id);
}
